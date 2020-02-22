namespace Backupser {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LocationStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderToBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(13, 27);
			this.MainPanel.Size = new System.Drawing.Size(775, 411);
			this.MainPanel.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Size = new System.Drawing.Size(800, 24);
			this.MenuStrip.TabIndex = 1;
			// 
			// optionsToolStripMenuItem
			// 
			this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocationStorageToolStripMenuItem,
            this.FolderToBackupToolStripMenuItem});
			this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.OptionsToolStripMenuItem.Text = "Options";
			// 
			// locationStorageToolStripMenuItem
			// 
			this.LocationStorageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.LocationStorageToolStripMenuItem.Text = "Location Storage";
			this.LocationStorageToolStripMenuItem.Click += new System.EventHandler(this.LocationStorageToolStripMenuItem_Click);
			// 
			// folderToBackupToolStripMenuItem
			// 
			this.FolderToBackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.FolderToBackupToolStripMenuItem.Text = "Folder To Backup";
			this.FolderToBackupToolStripMenuItem.Click += new System.EventHandler(this.FolderToBackupToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Text = "Backupsr";
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LocationStorageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FolderToBackupToolStripMenuItem;
	}
}

