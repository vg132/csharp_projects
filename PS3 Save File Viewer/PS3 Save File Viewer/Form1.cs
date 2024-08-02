using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS3_Save_File_Viewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			var imageList = new ImageList();
			int imageIndex = 0;
			foreach (var dir in Directory.GetDirectories(@"C:\Temp\saves"))
			{
				var sfo = Directory.GetFiles(dir, "PARAM.SFO").FirstOrDefault();
				if(sfo!=null)
				{
					SFOReader.Kalle(sfo);
				}
				var image = Directory.GetFiles(dir, "*.png").FirstOrDefault();
				if (!string.IsNullOrEmpty(image))
				{
					panel1.Controls.Add(new PictureBox
					{
						Width = 320,
						Height = 176,
						Image = Image.FromFile(image),
						Top = 205 * imageIndex,
						Left = 20,
					});
					panel1.Controls.Add(new Label
					{
						Text = dir,
						Top = 205 * imageIndex+185,
						Left = 20,
						Width=1000,
						Height=20
					});
					imageIndex++;
				}
			}
		}
	}


	public class SFOReader
	{
		public struct Header
		{
			public char[] magic;
			public float version;
			public uint keyTableOffset;
			public uint dataTableOffset;
			public uint tableEntries;
		}

		public struct IndexTable
		{
			public ushort param_key_offset;
			public ushort param_data_fmt;
			public ushort param_data_len;
			public ushort param_data_max_len;
			public ushort param_data_offset;
		}

		public static void Kalle(string path)
		{
			using (var reader = new BinaryReader(new FileStream(path, FileMode.Open)))
			{
				var header = new Header();
				header.magic = new char[4];
				header.magic = reader.ReadChars(4);
				header.version = (float)BitConverter.ToUInt32(reader.ReadBytes(4).Reverse().ToArray(), 0);
				header.keyTableOffset = reader.ReadUInt32();
				header.dataTableOffset = reader.ReadUInt32();
				header.tableEntries = reader.ReadUInt32();

				reader.BaseStream.Seek(header.keyTableOffset, SeekOrigin.Begin);
				for(int i =0;i<header.tableEntries;i++)
				{
					var table = new IndexTable();
					table.param_key_offset = reader.ReadUInt16();
					table.param_data_fmt = reader.ReadUInt16();
					table.param_data_len = reader.ReadUInt16();
					table.param_data_max_len = reader.ReadUInt16();
					table.param_data_offset = reader.ReadUInt16();
				}
			}
		}
	}
}
