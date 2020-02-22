using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

//TODO
//0 give possiblity to back up (date as name)
//2 load from backup and replace
//3 change max backups
//4 backup with an .exe file you don't have to use 
namespace Backupser {
	public partial class MainForm : Form {
		private Storage _storage;
		public MainForm() {
			InitializeComponent();
			OptionsMap();
			SetFiles();
		}
		private void OptionsMap() {
			var workDir = Directory.GetCurrentDirectory() + Program.STANDARD_LOCATION;
			if (!Directory.Exists(workDir))
				Directory.CreateDirectory(workDir);
			_storage = new Storage(workDir + "\\options");
			StorageCheck();
		}

		private void StorageCheck() {
			if (_storage.Folder.Equals("")) _storage.Folder = Directory.GetCurrentDirectory() + Program.STANDARD_LOCATION;
			if (_storage.MaxStrorage.Equals("")) _storage.MaxStrorage = "10";
		}

		private void SetFiles() {
			var names = ZippingClass.AllNames(_storage.Folder);
			names.OrderBy(x => x);
			for (int i = 0; i < names.Length; i++) {
				var fileDisplay = new Button() {
					Text = names[i].Substring(0, names[i].Length - 4)					
				};
				int b = i;
				fileDisplay.Click += (obj, e) => { ZippingClass.DeleteFile(_storage.Folder + '\\' + names[b]); MainPanel.Controls.Remove(fileDisplay); };
				MainPanel.Controls.Add(fileDisplay);
			}
		}

		private void FolderToBackupToolStripMenuItem_Click(object sender, EventArgs e) {
			_storage.FileName = GetFolderPick();
		}

		private void LocationStorageToolStripMenuItem_Click(object sender, EventArgs e) {
			_storage.Folder = GetFolderPick();
		}

		private string GetFolderPick() {
			using (var fbd = new FolderBrowserDialog()) {
				DialogResult result = fbd.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
					return (fbd.SelectedPath);
				}
				return "";
			}
		}
	}
}
