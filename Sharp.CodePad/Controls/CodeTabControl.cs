using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGSoftware.Sharp.CodePad.Controls
{
	public class CodeTabControl : TabControl
	{
		public new CodeTab SelectedTab
		{
			get { return base.SelectedTab as CodeTab; }
			set { base.SelectedTab = value; }
		}

		public void DeselectTab(CodeTab codeTab)
		{
			base.DeselectTab(codeTab);
		}

		public void SelectTab(CodeTab codeTab)
		{
			base.SelectTab(codeTab);
		}

		public new CodeTabCollection TabPages
		{
			get { return new CodeTabCollection(this, base.TabPages); }
		}
	}

	public class CodeTabCollection : TabControl.TabPageCollection
	{
		private TabControl.TabPageCollection _tabPages;
		public CodeTabCollection(CodeTabControl owner, TabControl.TabPageCollection tabPages)
			: base(owner)
		{
			_tabPages = tabPages;
		}

		public new CodeTab this[int index]
		{
			get { return _tabPages[index] as CodeTab; }
			set { _tabPages[index] = value; }
		}

		public void Add(CodeTab value)
		{
			_tabPages.Add(value);
		}

		public void AddRange(CodeTab[] pages)
		{
			_tabPages.AddRange(pages);
		}

		public bool Contains(CodeTab page)
		{
			return _tabPages.Contains(page);
		}

		public int IndexOf(CodeTab page)
		{
			return _tabPages.IndexOf(page);
		}

		public void Insert(int index, CodeTab page)
		{
			_tabPages.Insert(index, page);
		}

		public void Remove(CodeTab value)
		{
			_tabPages.Remove(value);
		}
	}
}
