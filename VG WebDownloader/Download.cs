using System;
using mshtml;
using System.Xml;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace VGSoftware.PageSaver
{
	/// <summary>
	/// Summary description for HTMLDownload.
	/// </summary>
	public class Download
	{
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
		struct INTERNET_CACHE_ENTRY_INFO
		{
			public int dwStructSize;
			public string lpszSourceUrlName;
			public string lpszLocalFileName;
			public int CacheEntryType;
			public int dwUseCount;
			public int dwHitRate;
			public int dwSizeLow;
			public int dwSizeHigh;
			public FILETIME LastModifiedTime;
			public FILETIME ExpireTime;
			public FILETIME LastAccessTime;
			public FILETIME LastSyncTime;
			public IntPtr lpHeaderInfo;
			public int dwHeaderInfoSize;
			public string lpszFileExtension;
			public int dwExemptDelta;
		}
		
		[DllImport("wininet.dll", CharSet=CharSet.Auto)]
		static extern bool RetrieveUrlCacheEntryFile(string lpszUrlName, IntPtr lpCacheEntryInfo, ref int lpdwCacheEntryInfoBufferSize, int dwReserved);

		[DllImport("Wininet.dll")]
		private static extern bool InternetGetCookie(string lpszUrlName,string lpszCookieName,System.Text.StringBuilder lpszCookieData,ref int lpdwSize);

		private string m_Html;
		private Project m_Project;
		private Uri m_BaseURI;

		///<summary>
		///Default constructor.
		///</summary>
		///<param name="project">The current project file.</param>
		///<param name="baseURI">The base url for this file.</param>
		public Download(ref Project project, Uri baseURI)
		{
			m_Project=project;
			m_BaseURI=baseURI;
		}

		///<summary>
		///Start the downloading thread.
		///</summary>
		public void Run()
		{
			if(m_Project.DirectoryStructure==1)
				new DirectoryInfo(m_Project.Folder+"\\"+m_Project.DirectoryName).Create();
			else
				new DirectoryInfo(m_Project.Folder).Create();
			DownloadSource();
			StartDownload("<img[^>]*>","src=");
			StartDownload("<link[^>]*>","href=");
			StartDownload("<body[^>]*>","background=");
			StartDownload("<td[^>]*>","background=");
			StartDownload("<script[^>]*>","src=");
			StartDownload("<embed[^>]*>","src=");
			StartDownload("<frame[^>]*>","src=");
			SaveSource();
		}

		private void DownloadSource()
		{
			m_Html=GetSource(m_BaseURI);
		}

		private void SaveSource()
		{
			string Title="",Dir="";
			int Tmp=0,Len=0;

			if(m_BaseURI.AbsoluteUri.Substring(m_BaseURI.AbsoluteUri.Length-1,1).Equals("/"))
			{
				if(m_Html.IndexOf("<title>")!=-1)
				{
					do
					{
						if(Tmp==0)
							Title=m_Html.Substring(m_Html.IndexOf("<title>",0)+7,m_Html.IndexOf("</title>")-(m_Html.IndexOf("<title>",0)+7))+".html";
						else
							Title=m_Html.Substring(m_Html.IndexOf("<title>",0)+7,m_Html.IndexOf("</title>")-(m_Html.IndexOf("<title>",0)+7))+"_"+Tmp.ToString()+".html";
						Tmp++;
					}while(new FileInfo(m_Project.Folder +"\\"+Title).Exists);
				}
				else
				{
					do
					{
						if(Tmp==0)
							Title="Index.html";
						else
							Title="Index_"+Tmp+".html";
						Tmp++;
					}while(new FileInfo(m_Project.Folder+"\\"+Title).Exists);
				}
			}
			else if(m_Project.DirectoryStructure!=0)
			{
				Title=m_BaseURI.Segments[m_BaseURI.Segments.Length-1];
			}
			if(m_Project.DirectoryStructure==0)
			{
				Tmp=m_BaseURI.AbsoluteUri.IndexOf("/",0);
				while(!m_BaseURI.AbsoluteUri.Substring(Tmp++,1).Equals("/"));
				Dir=FixPath(m_BaseURI.AbsoluteUri.Substring(Tmp+1));
			}
			if(Title.LastIndexOf(".")!=-1)
				Title=Title.Substring(0,Title.LastIndexOf("."))+".html";
			if((Dir.LastIndexOf(".")!=-1)&&(m_Project.DirectoryStructure==0))
			{
				string sTmp="";
				Tmp=0;
				do
				{
					if(Tmp==0)
						sTmp=Dir.Substring(0,Dir.LastIndexOf("."))+".html";
					else
						sTmp=Dir.Substring(0,Dir.LastIndexOf("."))+"_"+Tmp+".html";
					Tmp++;
				}while(new FileInfo(m_Project.Folder+"\\"+sTmp).Exists);
				Dir=sTmp;
			}

			FileInfo f=new FileInfo(m_Project.Folder +"\\"+Dir+Title);
			StreamWriter sw = f.CreateText();
			sw.WriteLine(m_Html);
			sw.Close();
		}

		private void StartDownload(string regex, string find)
		{
			int StartPos;
			int EndPos;
			int CurPos=0;
			int Tmp=0;
			string MatchStr;
			string URL;
			string SplitChar;
			string NewText="";
			string CatchedFilePath;
			string TempHTML="";
			string FileName="";
			Regex reg=new Regex(regex);
			Match match = reg.Match(m_Html);
			while(match.Success)
			{
				MatchStr=match.ToString();
				StartPos=MatchStr.IndexOf(find,0);
				if(StartPos!=-1)
				{
					SplitChar=MatchStr.Substring(StartPos+find.Length,1);
					if((SplitChar.Equals("\""))||(SplitChar.Equals("\'")))
					{
						EndPos=MatchStr.IndexOf(SplitChar,StartPos+find.Length+1);
						if(EndPos!=-1)
							URL=MatchStr.Substring(StartPos+find.Length+1,EndPos-(StartPos+find.Length+1));
						else
							URL="";
					}
					else
					{
						EndPos=MatchStr.IndexOf(" ",StartPos+find.Length);
						if(EndPos==-1)
							EndPos=MatchStr.IndexOf(">",StartPos+find.Length);
						if(EndPos!=-1)
							URL=MatchStr.Substring(StartPos+find.Length,EndPos-(StartPos+find.Length));
						else
							URL="";
					}
					if(URL!="")
					{
						XmlUrlResolver URLResolver=new System.Xml.XmlUrlResolver();
						//						if((!URL.StartsWith("http://"))&&(!URL.StartsWith("https://")))*/
						URL=URLResolver.ResolveUri(m_BaseURI,URL).AbsoluteUri;
						Uri uri=new Uri(URL);

						FileName=m_Project.GetPath(uri.AbsoluteUri);
						if(FileName==null)
						{
							if(m_Project.DirectoryStructure==0)
							{
								Tmp=uri.AbsoluteUri.IndexOf("/",0);
								while(!uri.AbsoluteUri.Substring(Tmp++,1).Equals("/"));
								FileName=FixPath(uri.AbsoluteUri.Substring(Tmp+1));
								new DirectoryInfo(m_Project.Folder+"\\"+FileName.Substring(0,FileName.LastIndexOf("\\"))).Create();
								//FileName=FileName.Substring(0,FileName.LastIndexOf("\\"));
							}
							else if(m_Project.DirectoryStructure==1)
							{
								FileName=m_Project.DirectoryName +"\\"+ uri.AbsolutePath.Substring(uri.AbsolutePath.LastIndexOf("/")+1);
							}
							else if(m_Project.DirectoryStructure==2)
							{
								//FileName=uri.AbsolutePath.Substring(uri.AbsolutePath.LastIndexOf("/")+1);
							}
						}

						//Check if the file is in the IE catch.
						CatchedFilePath=null;
						CatchedFilePath=CheckIECatch(uri);
						if(CatchedFilePath==null)
						{
							if(m_Project.GetPath(uri.AbsoluteUri)==null)
							{
								//Read file from URL.
								byte[] DataBuffer=GetBinary(uri);
								if(DataBuffer!=null)
								{
									//Write file to disk.
									FileStream f = new FileStream(m_Project.Folder+"\\"+FileName,FileMode.Create);
									f.Write(DataBuffer,0,DataBuffer.Length);
									f.Close();
									m_Project.AddPage(uri.AbsoluteUri,FileName);
								}
							}
						}
						else
						{
							//Copy file from IE catch.
							FileInfo f=new FileInfo(CatchedFilePath);
							f.CopyTo(m_Project.Folder+"\\"+FileName,true);
							m_Project.AddPage(uri.AbsoluteUri,FileName);
						}
						if(m_Project.DirectoryStructure==0)
						{
							if(m_BaseURI.MakeRelative(uri).Equals(uri.AbsoluteUri))
							{
								string SchemeDelimiter=Uri.SchemeDelimiter;
								FileName="../"+m_BaseURI.MakeRelative(new Uri(m_BaseURI.Scheme+SchemeDelimiter+m_BaseURI.Host))+FileName;
							}
							else
							{
								FileName=m_BaseURI.MakeRelative(uri);
							}
						}
						NewText=MatchStr.Substring(0,StartPos+find.Length)+"\""+FileName;
						if(!MatchStr.Substring(EndPos,1).Equals("\""))
							NewText+="\"";
						NewText+=MatchStr.Substring(EndPos);

						TempHTML+=m_Html.Substring(CurPos,match.Index-CurPos)+NewText;
						CurPos=match.Index+match.Length;
					}
				}
				NewText="";
				match = match.NextMatch();
			};
			m_Html=TempHTML+m_Html.Substring(CurPos);
		}

		private string CheckIECatch(Uri uri)
		{
			if(m_Project.Cache==false)
				return(null);
			else
				return(CheckIECatch(uri.AbsoluteUri));
		}

		private string CheckIECatch(string uri)
		{
			int cb = 0;
			string url=uri;
			RetrieveUrlCacheEntryFile(url, IntPtr.Zero, ref cb, 0);
			IntPtr p = Marshal.AllocHGlobal(cb);
			try 
			{
				if ( RetrieveUrlCacheEntryFile(url, p, ref cb, 0) ) 
				{
					INTERNET_CACHE_ENTRY_INFO icei = (INTERNET_CACHE_ENTRY_INFO)Marshal.PtrToStructure(p, typeof(INTERNET_CACHE_ENTRY_INFO));
					return(icei.lpszLocalFileName);
				}
			}
			finally 
			{
				if(p!=IntPtr.Zero)
					Marshal.FreeHGlobal(p);
			}
			return(null);
		}

		private string FixPath(string path)
		{
			path=path.Replace("/","\\");
			path=path.Replace(":","");
			path=path.Replace("*","");
			path=path.Replace("?","");
			path=path.Replace("\"","");
			path=path.Replace("<","");
			path=path.Replace(">","");
			return(path.Replace("|",""));
		}

		private byte[] GetBinary(Uri uri)
		{
			WebClient Client=new WebClient();
			if(m_Project.Cookie)
			{
				System.Text.StringBuilder CookieData=new System.Text.StringBuilder(4096);
				int DataLen=CookieData.Capacity;
				if(InternetGetCookie(uri.AbsoluteUri,null,CookieData,ref DataLen))
					Client.Headers.Set("Cookie",CookieData.ToString().Trim());
			}
			try
			{
				byte[] buffer=Client.DownloadData(uri.AbsoluteUri);
				return(buffer);
			}
			catch(Exception e)
			{
			}
			return(null);
		}

		private string GetSource(Uri uri)
		{
			StreamReader    BodyReader;
			string          BodyText = "", Line;
			Stream          ResponseStream;

			WebClient Client=new WebClient();
			if(m_Project.Cookie)
			{
				System.Text.StringBuilder CookieData=new System.Text.StringBuilder(4096);
				int DataLen=CookieData.Capacity;
				if(InternetGetCookie(uri.AbsoluteUri,null,CookieData,ref DataLen))
					Client.Headers.Set("Cookie",CookieData.ToString().Trim());
			}

			ResponseStream = Client.OpenRead(uri.AbsoluteUri);
			if (ResponseStream != null)
			{
				BodyReader = new StreamReader(ResponseStream);
				while((Line=BodyReader.ReadLine())!=null)
				{
					BodyText+=Line+"\r\n";
				}
				BodyReader.Close();
				BodyReader = null;
			}
			return(BodyText);
		}
	}
}
