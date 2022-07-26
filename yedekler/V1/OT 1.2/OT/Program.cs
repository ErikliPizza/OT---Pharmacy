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
			MessageBoxManager.Abort = "iptal";
			MessageBoxManager.Retry = "yeni barkod";
			MessageBoxManager.Ignore = "çakışan barkodu göster ve düzenle";
			MessageBoxManager.Register();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
