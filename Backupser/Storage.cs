using System.IO;

namespace Backupser {
	public class Storage {
		private string _location;
		private string[] data;
		public Storage(string location) {
			_location = location;
		}
		public string FileName { get { return ReadStorageFile()[0]; } set { 
				var v = ReadStorageFile(); 
				v[0] = value; StoreStorageFile(v); 
			} 
		}
		public string Folder {
			get { return ReadStorageFile()[1]; }
			set {
				var v = ReadStorageFile();
				v[1] = value; StoreStorageFile(v);
			}
		}
		public string MaxStrorage {
			get { return ReadStorageFile()[2]; }
			set {
				var v = ReadStorageFile();
				v[2] = value; StoreStorageFile(v);
			}
		}

		private string[] ReadStorageFile() {
			if (data == null)
				if (File.Exists(_location)) {
					data = File.ReadAllLines(_location);
				} 
			if (data?.Length != 3) {
				data = new string[] { "", "", "" };
			}
			return data;
		}
		private void StoreStorageFile(string[] stores) {
			data = stores;
			if (File.Exists(_location))
				File.SetAttributes(_location, FileAttributes.Normal);
			using (var tw = new StreamWriter(_location, false)) {
				tw.Write(string.Join("\n", stores));
			}
			//File.WriteAllLines(_location, stores);
			File.SetAttributes(_location, FileAttributes.Hidden);
		}
		
	}
}
