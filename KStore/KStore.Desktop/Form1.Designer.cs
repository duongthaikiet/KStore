namespace KStore.Desktop
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panRoot = new DevExpress.XtraEditors.PanelControl();
			this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
			this.tabGoogleDrive = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.gridGoogle = new DevExpress.XtraGrid.GridControl();
			this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.bindingSource1 = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.panRoot)).BeginInit();
			this.panRoot.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.tabGoogleDrive.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridGoogle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// panRoot
			// 
			this.panRoot.Controls.Add(this.tabPane1);
			this.panRoot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panRoot.Location = new System.Drawing.Point(0, 0);
			this.panRoot.Name = "panRoot";
			this.panRoot.Size = new System.Drawing.Size(717, 581);
			this.panRoot.TabIndex = 0;
			// 
			// tabPane1
			// 
			this.tabPane1.Controls.Add(this.tabGoogleDrive);
			this.tabPane1.Controls.Add(this.tabNavigationPage2);
			this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPane1.Location = new System.Drawing.Point(2, 2);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabGoogleDrive,
            this.tabNavigationPage2});
			this.tabPane1.RegularSize = new System.Drawing.Size(713, 577);
			this.tabPane1.SelectedPage = this.tabNavigationPage2;
			this.tabPane1.SelectedPageIndex = 0;
			this.tabPane1.Size = new System.Drawing.Size(713, 577);
			this.tabPane1.TabIndex = 0;
			this.tabPane1.Text = "tabPane1";
			// 
			// tabGoogleDrive
			// 
			this.tabGoogleDrive.Caption = "Google Drive";
			this.tabGoogleDrive.Controls.Add(this.gridGoogle);
			this.tabGoogleDrive.Name = "tabGoogleDrive";
			this.tabGoogleDrive.Size = new System.Drawing.Size(695, 532);
			// 
			// tabNavigationPage2
			// 
			this.tabNavigationPage2.Caption = "tabNavigationPage2";
			this.tabNavigationPage2.Name = "tabNavigationPage2";
			this.tabNavigationPage2.Size = new System.Drawing.Size(695, 532);
			// 
			// gridGoogle
			// 
			this.gridGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridGoogle.Location = new System.Drawing.Point(0, 0);
			this.gridGoogle.MainView = this.cardView1;
			this.gridGoogle.Name = "gridGoogle";
			this.gridGoogle.Size = new System.Drawing.Size(695, 532);
			this.gridGoogle.TabIndex = 0;
			this.gridGoogle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
			// 
			// cardView1
			// 
			this.cardView1.FocusedCardTopFieldIndex = 0;
			this.cardView1.GridControl = this.gridGoogle;
			this.cardView1.Name = "cardView1";
			this.cardView1.OptionsView.ShowEmptyFields = false;
			this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
			this.cardView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.cardView1_CustomUnboundColumnData);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 581);
			this.Controls.Add(this.panRoot);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.panRoot)).EndInit();
			this.panRoot.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
			this.tabPane1.ResumeLayout(false);
			this.tabGoogleDrive.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridGoogle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panRoot;
		private DevExpress.XtraBars.Navigation.TabPane tabPane1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabGoogleDrive;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
		private DevExpress.XtraGrid.GridControl gridGoogle;
		private DevExpress.XtraGrid.Views.Card.CardView cardView1;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}

