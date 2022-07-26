using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT
{
	static class Program
	{
		/// <summary>
		/// Uygulamanın ana girdi noktası.
		/// </summary>
		[STAThread]
		static void Main()
		{
			MessageBoxManager.Abort = "İptal";
			MessageBoxManager.Retry = "Düzenle";
			MessageBoxManager.Ignore = "Tamam";
			MessageBoxManager.OK = "Tamam";
			MessageBoxManager.Cancel = "Çıkış";
			MessageBoxManager.Register();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
