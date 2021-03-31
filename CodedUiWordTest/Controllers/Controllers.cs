/*
 * Created by Ranorex
 * User: Oprea Rares
 * Date: 29/03/2021
 * Time: 17:20
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ranorex;

namespace CodedUiWordTest.Controllers
{
	/// <summary>
	/// Description of Controllers.
	/// </summary>
	public class Controllers
	{
		#region C'tor
		
		public Controllers()
		{
		}
		
		#endregion
		
		#region Word
		
		#region Properties
		
		private static Mappings.WordDialog Word 
		{
			get 
			{
				return Mappings.WordDialog.Instance;
			}
		}
		
		private static Mappings.DateiSystemDialog Datei 
		{
			get 
			{
				return Mappings.DateiSystemDialog.Instance;
			}
		}
		
		public static String Dateiname 
		{
			get
			{
				return Datei.Dateiname.TextValue;
			}
			set
			{
				Report.Log(ReportLevel.Info, "Dateiname: " + value);
				Datei.Dateiname.PressKeys(value);
			}
		}
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// WordStart
		/// </summary>
		public static void WordStart()
		{
			Report.Log(ReportLevel.Info, "WordStart");
			ForceCloseProcess("WINWORD.EXE");
			Delay.Seconds(1);
            Host.Local.RunApplication("C:\\Program Files\\WindowsApps\\Microsoft.Office.Desktop.Word_16051.13801.20360.0_x86__8wekyb3d8bbwe\\Office16\\WINWORD.EXE", "", "", true);
            Word.WordProcces.SelfInfo.WaitForExists(20 * 1000);
            ErsteSchrittDialog();
		}
		
		/// <summary>
		/// OpenClick
		/// </summary>
		public static void OpenClick()
		{
			Report.Log(ReportLevel.Info, "Open Click");	
			Word.Offnen.EnsureVisible();
			Word.Offnen.Click();
			if(!Word.DurchsuchenInfo.Exists())
				Report.Failure("Error on Open Button!!!");
			else
				Report.Success("Open Button Succes!!");
		}
		
		/// <summary>
		/// OpenWithKeys
		/// </summary>
		public static void OpenWithKeys()
		{
			Report.Log(ReportLevel.Info, "Open With Keys");	
			Word.Startseite.Click();
			Keyboard.Press(System.Windows.Forms.Keys.Down);
			Keyboard.Press(System.Windows.Forms.Keys.Down);
			if(!Word.DurchsuchenInfo.Exists())
				Report.Failure("Error on Open Button!!!");
			else
				Report.Log(ReportLevel.Info, "Open Button Succes!!");
		}
		
		/// <summary>
		/// ErsteSchrittDialog
		/// </summary>
		public static void ErsteSchrittDialog()
		{
			Report.Log(ReportLevel.Info, "ErsteSchrittDialog");
			Word.ErsteSchritCloseInfo.WaitForExists(10 * 1000);
			if (Word.ErsteSchritCloseInfo.Exists(5 * 1000)) 
			{
				Word.ErsteSchritClose.MoveTo();
				Word.ErsteSchritClose.Click();
			}
		}
		
		/// <summary>
		/// Durchsuchen
		/// </summary>
		public static void Durchsuchen()
		{
			Report.Log(ReportLevel.Info, "Durchsuchen");
			Word.Durchsuchen.EnsureVisible();
			Word.Durchsuchen.Click();
		}
		
		/// <summary>
		/// OpenFile
		/// </summary>
		public static void OpenFile()
		{
			Report.Log(ReportLevel.Info, "OpenFile");
			Datei.Offnen.Click();
		}
		
		/// <summary>
		/// WordClose
		/// </summary>
		public static void WordClose()
		{
			Report.Log(ReportLevel.Info, "WordClose");
			if(Word.WordCloseInfo.Exists(Duration.FromMilliseconds(5 * 1000)))
				Word.WordClose.Click();
			else
				Word.Schliessen.Click();
			ForceCloseProcess("WINWORD.EXE");
		}
		
		/// <summary>
		/// ForceClose
		/// </summary>
		private static void ForceCloseProcess(string proc)
		{
			SpinWait.SpinUntil(
				() => { 
					var container = Process.GetProcessesByName(proc);
					if( container.Length != 0)
					{
						container[0].WaitForInputIdle();
	                    IntPtr s = container[0].MainWindowHandle;
						Report.Log(ReportLevel.Info, "kill " + container.First().ProcessName);
						container[0].Kill();
						Delay.Seconds(5);
						return false;
					}
					 return true;
				}
				, 30 * 1000);
			Delay.Seconds(4);
		}
		
		#endregion
		
		#endregion
		
		#region ExchangeRate
		
		#region Properties
		
		private static Mappings.Edge IEdge 
		{
			get 
			{
				return Mappings.Edge.Instance;
			}
		}
		
		public const string FirstLink = @"http://api.currencylayer.com/live?access_key=ca2efa55a751808737f72d415f1ca387";
		public const string SecondLink = @"https://openexchangerates.org/api/latest.json?app_id=1de86dfd996b4c9da20c0b3fa6eefaa4&amp;base=USD";
		
		#endregion
		
		#region methods
		
		/// <summary>
		/// OpenEdge
		/// </summary>
		/// <param name="link"></param>
		public static void OpenEdge(string link)
		{
			Report.Log(ReportLevel.Info, "Open Edge");
			ForceCloseProcess("msedge");
            Host.Current.OpenBrowser(link, "Edge", "", false, false, false, false, false, true);
            WaitDomRender(link);
		}
		
		/// <summary>
		/// GetActualValue
		/// </summary>
		/// <param name="link"></param>
		/// <returns></returns>
		public static string GetActualValue(string link)
		{
			Report.Log(ReportLevel.Info, "GetActualValue");
			string json;
			using (WebClient wc = new WebClient())
			{
			   json = wc.DownloadString(link);
			}
			var container = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
			foreach(var item in container)
			{
				if(link == FirstLink && item.Key == "quotes")
					return item.Value["USDEUR"].ToString() ;
				else if(link == SecondLink && item.Key == "rates")			
					return item.Value["EUR"].ToString();
			}
			return null;
		}
		
		
		/// <summary>
		/// ForceClose
		/// </summary>
		public static void CloseEdge()
		{
			Report.Log(ReportLevel.Info, "Close Edge");
			IEdge.HaupFenster.EnsureVisible();
			Keyboard.Press("{LControlKey down}{Wkey}{LControlKey up}");
			ForceCloseProcess("msedge.exe");
		}
		
		/// <summary>
		/// WaitDomRender
		/// </summary>
		/// <param name="link"></param>
		private static void WaitDomRender(string link)
		{
			Report.Log(ReportLevel.Info, "WaitDomRender");
			var domList = IEdge.Currencyplayer.SelfInfo.CreateAdapters<Unknown>();
			if(link == SecondLink)
				domList = IEdge.OpenChange.SelfInfo.CreateAdapters<Unknown>();
			foreach(var dom in domList){
				if(dom.GetAttributeValue<string>("browsername").Equals("Edge")){
					SpinWait.SpinUntil(() => {
					                   	if(!dom.GetAttributeValue<string>("state").Equals("complete"))
					                   	{
					                   		Delay.Duration(1000);
					                   		return false;
					                   	}
					                   	else
					                   		return true;
					                   }, 40 * 1000);
				}
			}
		}
		
		/// <summary>
		/// PrintMess
		/// </summary>
		/// <param name="FirstContent"></param>
		/// <param name="SecondContent"></param>
		public static void PrintMess(double FirstContent, double SecondContent)
		{
			Report.Log(ReportLevel.Info, "PrintMess");
			string sAttr =  ConfigurationManager.AppSettings.Get("PrintMode");
            if(sAttr == "Console")
            {
            	if(FirstContent > SecondContent)
	            	Console.WriteLine("The best rate is: " + FirstContent);
	            else
	            	Console.WriteLine("The best rate is: " + SecondContent);
	            Console.ReadLine();
            }
            else
            {
            	if(FirstContent > SecondContent)
	            	MessageBox.Show("The best rate is: " + FirstContent, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            else
	            	MessageBox.Show("The best rate is: " + SecondContent, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}
		
		#endregion
		
		#endregion
	}
}
