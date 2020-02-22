﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Backupser {
	public static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public const string STANDARD_LOCATION = "\\Backups-upsr";
		[STAThread]
		static void Main(string[] s) {
			if (s.Length != 0) {
				MakeBackup(); 
			} else { 
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}

		private static void MakeBackup() {
			var workDir = Directory.GetCurrentDirectory() + STANDARD_LOCATION;
			if (!Directory.Exists(workDir))
				return;
			var storage = new Storage(workDir + "\\options");
			if (Directory.Exists(storage.FileName) && Directory.Exists(storage.Folder))
				ZippingClass.ZipToFolder(storage.FileName, storage.Folder, DateTime.Now.ToString("yyyyMMddTHHmmssfff"));
		}
	}
}