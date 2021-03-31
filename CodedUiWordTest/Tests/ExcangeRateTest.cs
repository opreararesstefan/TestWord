/*
 * Created by Ranorex
 * User: Oprea Rares
 * Date: 31/03/2021
 * Time: 09:28
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Controller = CodedUiWordTest.Controllers.Controllers;

namespace CodedUiWordTest.Tests
{
    /// <summary>
    /// Description of RateExcangeTest.
    /// </summary>
    [TestModule("5C036F94-EC0A-4772-880F-7CDA41AF644B", ModuleType.UserCode, 1)]
    public class ExcangeRateTest : ITestModule
    {
    	#region C'tor
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExcangeRateTest()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        #endregion

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	#region Initialize
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            #endregion
            
            #region test
            
            Controller.OpenEdge(Controller.FirstLink);
            double FirstContent = Convert.ToDouble(Controller.GetActualValue(Controller.FirstLink));
            Report.Log(ReportLevel.Info, "FirstContent " + FirstContent);
            Controller.CloseEdge();
            Controller.OpenEdge(Controller.SecondLink);
            double SecondContent = Convert.ToDouble(Controller.GetActualValue(Controller.SecondLink));
            Report.Log(ReportLevel.Info, "SecondContent " + SecondContent);
            Controller.CloseEdge();
            Controller.PrintMess(FirstContent, SecondContent);
            
            #endregion
        }
    }
}
