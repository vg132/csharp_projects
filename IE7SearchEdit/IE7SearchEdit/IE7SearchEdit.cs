using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IE7SearchEdit
{
	public partial class IE7SearchEdit : Form
	{
		private List<SearchEngine> m_SearchEngines=new List<SearchEngine>();
		private SearchEngine m_CurrentSearchEngine=null;
		private SearchEngine m_DefaultSearchEngine=null;
		private Boolean m_ChangeSearchEngine=true;

		public IE7SearchEdit()
		{
			InitializeComponent();

			LoadSearchEngines();
			chkSameAsName.Checked=true;
		}

		private void SaveSearchEngines()
		{
			RegistryKey headKey=Registry.CurrentUser;
			RegistryKey subKey=null;
			try
			{
				headKey=headKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\SearchScopes",true);
				headKey.SetValue("DefaultScope",m_DefaultSearchEngine.Name,RegistryValueKind.String);
				foreach(string str in headKey.GetSubKeyNames())
					headKey.DeleteSubKey(str);
				foreach(SearchEngine se in m_SearchEngines)
				{
					headKey.CreateSubKey(se.Name);
					subKey=headKey.OpenSubKey(se.Name,true);
					subKey.SetValue("DisplayName", se.DisplayName, RegistryValueKind.String);
					subKey.SetValue("URL",se.Url,RegistryValueKind.String);
					subKey.SetValue("SortIndex",se.SortIndex,RegistryValueKind.DWord);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Error when saving search enignes to the registry.\n"+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadSearchEngines()
		{
			RegistryKey headKey=Registry.CurrentUser;
			RegistryKey subKey=null;
			SearchEngine se=null;
			string def=null;
			try
			{
				headKey=headKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\SearchScopes");
				def=(string)headKey.GetValue("DefaultScope", "");
				foreach(string str in headKey.GetSubKeyNames())
				{
					se=new SearchEngine();
					if(def.Equals(str))
						m_DefaultSearchEngine=se;
					subKey=headKey.OpenSubKey(str);
					se.Name=str;
					se.DisplayName=(string)subKey.GetValue("DisplayName","");
					se.Url=(string)subKey.GetValue("Url","");
					se.SortIndex=(int)subKey.GetValue("SortIndex",-1);
					m_SearchEngines.Add(se);
				}
				UpdateListBox();
			}
			catch(Exception e)
			{
				MessageBox.Show("Error when loading search enignes from registry.\n"+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void chkSameAsName_CheckedChanged(object sender, EventArgs e)
		{
			if(chkSameAsName.Checked)
			{
				txtDisplayName.Enabled = false;
				lblDisplayName.Enabled = false;
			}
			else
			{
				txtDisplayName.Enabled = true;
				lblDisplayName.Enabled = true;
			}
		}

		private void lstSearchEngines_SelectedIndexChanged(object sender, EventArgs e)
		{
			if((m_ChangeSearchEngine==true)&&(m_SearchEngines.Count>lstSearchEngines.SelectedIndex)&&(lstSearchEngines.SelectedIndex>=0))
			{
				grpSettings.Enabled=true;
				m_CurrentSearchEngine=m_SearchEngines[lstSearchEngines.SelectedIndex];
				txtName.Text=m_CurrentSearchEngine.Name;
				txtDisplayName.Text=m_CurrentSearchEngine.DisplayName;
				txtURL.Text=m_CurrentSearchEngine.Url;
				txtSortIndex.Text=m_CurrentSearchEngine.SortIndex+"";
			}
			if(lstSearchEngines.SelectedIndex==0)
				cmdMoveUp.Enabled=false;
			else
				cmdMoveUp.Enabled=true;
			if(lstSearchEngines.SelectedIndex==(lstSearchEngines.Items.Count-1))
				cmdMoveDown.Enabled=false;
			else
				cmdMoveDown.Enabled=true;
		}

		private void UpdateListBox()
		{
			m_ChangeSearchEngine=false;
			lstSearchEngines.Items.Clear();
			m_SearchEngines.Sort();
			for(int i=0;i<m_SearchEngines.Count;i++)
			{
				if(m_DefaultSearchEngine==m_SearchEngines[i])
					lstSearchEngines.Items.Add(m_SearchEngines[i].DisplayName+" *");
				else
					lstSearchEngines.Items.Add(m_SearchEngines[i].DisplayName);
				m_SearchEngines[i].SortIndex=i+1;
			}
			if(m_CurrentSearchEngine!=null)
			{
				if(m_DefaultSearchEngine==m_CurrentSearchEngine)
					lstSearchEngines.SelectedIndex=lstSearchEngines.Items.IndexOf(m_CurrentSearchEngine.DisplayName+" *");
				else
					lstSearchEngines.SelectedIndex=lstSearchEngines.Items.IndexOf(m_CurrentSearchEngine.DisplayName);
			}
			m_ChangeSearchEngine=true;
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
			m_SearchEngines.Add(new SearchEngine("New","New","",-1));
			UpdateListBox();
			lstSearchEngines.SelectedIndex=lstSearchEngines.Items.Count-1;
		}

		private void cmdRemove_Click(object sender, EventArgs e)
		{
			if(lstSearchEngines.SelectedIndex!=-1)
			{
				if(MessageBox.Show("Are you sure you want to remove this search engine?","Confirm removal",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					m_SearchEngines.RemoveAt(lstSearchEngines.SelectedIndex);
					UpdateListBox();
				}
			}
		}

		private void cmdMoveUp_Click(object sender, EventArgs e)
		{
			m_ChangeSearchEngine=false;
			m_SearchEngines[lstSearchEngines.SelectedIndex--].SortIndex--;
			m_ChangeSearchEngine=true;
			UpdateListBox();
		}

		private void cmdMoveDown_Click(object sender, EventArgs e)
		{
			m_ChangeSearchEngine=false;
			m_SearchEngines[lstSearchEngines.SelectedIndex++].SortIndex++;
			m_ChangeSearchEngine=true;
			UpdateListBox();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			m_CurrentSearchEngine.Name=txtName.Text;
			if(chkSameAsName.Checked==true)
				txtDisplayName.Text=txtName.Text;
			UpdateListBox();
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cmdSaveAndExit_Click(object sender, EventArgs e)
		{
			SaveSearchEngines();
			Application.Exit();
		}

		private void txtDisplayName_TextChanged(object sender, EventArgs e)
		{
			m_CurrentSearchEngine.DisplayName=txtDisplayName.Text;
		}

		private void txtURL_TextChanged(object sender, EventArgs e)
		{
			m_CurrentSearchEngine.Url=txtURL.Text;
		}

		private void txtSortIndex_TextChanged(object sender, EventArgs e)
		{
			m_CurrentSearchEngine.SortIndex=Int32.Parse(txtSortIndex.Text);
			UpdateListBox();
		}

		private void cmdDefault_Click(object sender, EventArgs e)
		{
			if(lstSearchEngines.SelectedIndex>-1)
			{
				m_DefaultSearchEngine=m_SearchEngines[lstSearchEngines.SelectedIndex];
				UpdateListBox();
			}
		}
	}
}