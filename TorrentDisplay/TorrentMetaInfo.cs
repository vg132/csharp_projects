using System;
using System.IO;
using System.Collections;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for TorrentMetaInfo.
	/// </summary>
	public class TorrentMetaInfo
	{
		public TorrentMetaInfo()
		{
			ReadMetaInfo("W:\\torrent\\Sahara.DVDR-aNBc.torrent");
		}

		public void ReadMetaInfo(string file)
		{
			int elementType=0;
			Hashtable ht=new Hashtable();
			FileStream fs=new FileStream(file,FileMode.Open);
			while((elementType=fs.ReadByte())!=-1)
			{
				switch(elementType)
				{
					case 'i':
						ReadInteger(fs);
						break;
					case 'd':
						ht=ReadDirectory(fs);
						break;
					case 'l':
						ReadList(fs);
						break;
					default:
						string tmp="";
						do
						{
							tmp+=(char)elementType;
							elementType=fs.ReadByte();
						}while(elementType!=':');
						ReadString(fs,Int32.Parse(tmp));
						break;
				}
			}
			fs.Close();
		}

		private ArrayList ReadList(FileStream fs)
		{
			int elementType=0;
			ArrayList al=new ArrayList();
			while((elementType=fs.ReadByte())!='e')
			{
				switch(elementType)
				{
					case 'i':
						al.Add(ReadInteger(fs));
						break;
					case 'd':
						al.Add(ReadDirectory(fs));
						break;
					case 'l':
						al.Add(ReadList(fs));
						break;
					default:
						string tmp="";
						do
						{
							tmp+=(char)elementType;
							elementType=fs.ReadByte();
						}while(elementType!=':');
						al.Add(ReadString(fs,Int32.Parse(tmp)));
						break;
				}
			}
			return(al);
		}

		private Hashtable ReadDirectory(FileStream fs)
		{
			Hashtable ht=new Hashtable();
			int elementType=0;
			string key=null;
			while((elementType=fs.ReadByte())!='e')
			{
				switch(elementType)
				{
					case 'i':
						ht.Add(key,ReadInteger(fs));
						key=null;
						break;
					case 'd':
						ht.Add(key,ReadDirectory(fs));
						key=null;
						break;
					case 'l':
						ht.Add(key,ReadList(fs));
						key=null;
						break;
					default:
						string tmp="";
						do
						{
							tmp+=(char)elementType;
							elementType=fs.ReadByte();
						}while(elementType!=':');
						if(key==null)
						{
							key=ReadString(fs,Int32.Parse(tmp));
						}
						else
						{
							ht.Add(key,ReadString(fs,Int32.Parse(tmp)));
							key=null;
						}
						break;
				}
			}
			return(ht);
		}

		private int ReadInteger(FileStream fs)
		{
			int elementType=0;
			string tmp="";
			while((elementType=fs.ReadByte())!='e')
			{
				tmp+=(char)elementType;
			}
			return(Int32.Parse(tmp));
		}

		private string ReadString(FileStream fs,int length)
		{
			byte[] buffer=new byte[length];
			fs.Read(buffer,0,length);
			return(new System.Text.ASCIIEncoding().GetString(buffer));
		}
	}
}
