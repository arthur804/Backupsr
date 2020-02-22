using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Backupser {
	public static class ZippingClass {
		//string NameOfFolder;
		public static bool ZipToFolder(string folderToBackUpName, string backupLocation, string zipName) {
			if (!Directory.Exists(folderToBackUpName))
				return false;
			if (!Directory.Exists(backupLocation))
				Directory.CreateDirectory(backupLocation);
			ZipFile.CreateFromDirectory(folderToBackUpName, backupLocation + '\\' + zipName + ".zip");
			return true;
		}
		public static bool ExtractFolder(string folderName, string extractLocation, string zipName) {
			if (!Directory.Exists(folderName))
				return false;
			bool exists = Directory.Exists(extractLocation);
			if (!exists)
				Directory.CreateDirectory(extractLocation);
			ZipFile.ExtractToDirectory(folderName + '\\' + zipName + ".zip", extractLocation);
			return true;		
		}
		public static bool DeleteUntillAmount(string backupLocation, int amount) {
			DirectoryInfo d = new DirectoryInfo(backupLocation);
			FileInfo[] Files = d.GetFiles("*.zip");
			var v = Array.ConvertAll(Files, x => x.FullName);
			if (v.Length > amount) {
				v.OrderBy(x => x);
			}
			for (int i = amount; i < v.Length; i++) {
				File.Delete(v[i]);
			}
			return false;
		}
		public static string[] AllNames(string backupLocation) {
			DirectoryInfo d = new DirectoryInfo(backupLocation);
			FileInfo[] Files = d.GetFiles("*.zip");
			return Array.ConvertAll(Files, x => x.Name);
		}
		public static void DeleteFile(string fullName) {
			if (File.Exists(fullName)) {
				File.Delete(fullName);
			}
		}
	}
}
