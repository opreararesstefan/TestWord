/*
 * Created by Ranorex
 * User: Oprea Rares
 * Date: 31/03/2021
 * Time: 08:51
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
    /// Description of WordKeyTest.
    /// </summary>
    [TestModule("76EADE5F-B2DC-44E4-9A49-D94E85CB265E", ModuleType.UserCode, 1)]
    public class WordKeyTest : ITestModule
    {
    	#region C'tor
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WordKeyTest()
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
            
            #region Test
            
            Controller.WordStart();
            Controller.OpenWithKeys();
            Controller.Durchsuchen();
            Controller.Dateiname = @"C:\Workspace\PRO\RoSpro\server\CV.docx";
            Controller.OpenFile();
            Controller.WordClose();
            
            #endregion
        }
    }
}
