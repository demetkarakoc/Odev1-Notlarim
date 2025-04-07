using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSSWithNews
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			XmlTextReader xmloku = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");
			while (xmloku.Read())
			{
				if(xmloku.Name=="title")
				{
					listBox1.Items.Add(xmloku.ReadString());
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			XmlTextReader xmloku2 = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
			while (xmloku2.Read())
			{
				if (xmloku2.Name == "title")
				{
					listBox1.Items.Add(xmloku2.ReadString());
				}
			}
		}
	}
}
