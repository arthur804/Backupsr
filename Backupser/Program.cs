using System;
using System.IO;
using System.Windows.Forms;

namespace Backupser {
	public static class Program {
		static void Main(string[] args)
        	{
			if (args.Length > 2)
				MakeBackup(args[0], args[1], args[2]);
        	}
		[STAThread]
		private static void MakeBackup(string target, string destination, string amoung)
		{
			var workDir = Directory.GetCurrentDirectory();
			if (Directory.Exists(target) && Directory.Exists(destination))
			{
				ZippingClass.ZipToFolder(target, destination, DateTime.Now.ToString("yyyyMMddTHHmmss"));
				int.TryParse(amoung, out int val);
				if (val < 1) val = 100;
				ZippingClass.DeleteUntillAmount(destination, val);
			}
			else
				Console.WriteLine("A directory missing");
		}
	}
}
