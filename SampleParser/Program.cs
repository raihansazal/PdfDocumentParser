//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Cliver.SampleParser
{
    /*
 TBD:
- download Matt's invoices and fix: Oremus Materials
Sales and Service
SMS_

- !!!all the templates must be tested and fixed after changing anchor functioning!!!
- ? store each template in separate file;

     */
    class Program
    {
        static Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += delegate (object sender, UnhandledExceptionEventArgs args)
            {
                Exception e = (Exception)args.ExceptionObject;
                LogMessage.Error(e);
                Environment.Exit(0);
            };

            Version = AssemblyRoutines.GetAssemblyCompiledTime(Assembly.GetEntryAssembly()).ToString("yyMMdd-HHmmss"); //String.Format("Version {0}", AssemblyVersion);
            Name = Application.ProductName;

            Message.TopMost = true;

            Config.Reload();
            LogMessage.DisableStumblingDialogs = false;
            Log.ShowDeleteOldLogsDialog = false;
            Log.Initialize(Log.Mode.ONLY_LOG, Log.CompanyCommonDataDir, true);
        }
        public static readonly string Version;
        public static readonly string Name;

        [STAThread]
        static void Main()
        {
            try
            {
                PdfDocumentParser.Program.Initialize();
                
                Application.Run(MainForm.This);
            }
            catch (Exception e)
            {
                Message.Error(e);
            }
            Environment.Exit(0);
        }
    }
}