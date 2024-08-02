using System;
using System.Collections.Generic;
using System.Text;

namespace IE7SearchEdit
{
	class SearchEngine : IComparable<SearchEngine>
	{
		private string m_Name=null;
		private string m_DisplayName=null;
		private string m_Url=null;
		private int m_SortIndex=-1;

		public SearchEngine()
		{
		}

		public SearchEngine(string name, string displayName, string url, int sortOrder)
		{
			m_Name=name;
			m_DisplayName=displayName;
			m_Url=url;
			m_SortIndex=sortOrder;
		}

		/// <summary>
		/// Gets and sets the string value of m_Name.
		/// </summary>
		public string Name
		{
			get
			{
				return(this.m_Name);
			}
			set
			{
				this.m_Name=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of m_DisplayName.
		/// </summary>
		public string DisplayName
		{
			get
			{
				return(this.m_DisplayName);
			}
			set
			{
				this.m_DisplayName=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of m_Url.
		/// </summary>
		public string Url
		{
			get
			{
				return (this.m_Url);
			}
			set
			{
				this.m_Url=value;
			}
		}

		/// <summary>
		/// Gets and sets the int value of m_SortIndex.
		/// </summary>
		public int SortIndex
		{
			get
			{
				return(this.m_SortIndex);
			}
			set
			{
				this.m_SortIndex=value;
			}
		}

		public int CompareTo(SearchEngine se)
		{
			if(se.SortIndex==-1)
				return(-1);
			else if(m_SortIndex==-1)
				return(1);
			else
				return(m_SortIndex.CompareTo(se.SortIndex));
		}
	}
}
