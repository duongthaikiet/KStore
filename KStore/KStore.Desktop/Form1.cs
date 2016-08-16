using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KStore.DMS.GoogleDrive;
using DevExpress.XtraEditors.Repository;

namespace KStore.Desktop
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		public Form1()
		{
			InitializeComponent();
			GoogleDrive test = new GoogleDrive();
			bindingSource1.DataSource = test.GetGoogleDriveFiles();
			gridGoogle.DataSource = bindingSource1;
			//test
		}

		private void ribbonStatusBar1_Click(object sender, EventArgs e)
		{

		}

		private void cardView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{
			if (e.IsGetData)
			{
				var file = (e.Row as Google.Apis.Drive.v3.Data.File);
				e.Value = Image.FromFile(file.ThumbnailLink);
			}
		}
	}
}
