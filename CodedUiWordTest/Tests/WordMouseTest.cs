/*
 * Created by Ranorex
 * User: Oprea Rares
 * Date: 29/03/2021
 * Time: 17:21
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
using CodedUiWordTest.Controllers;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Controller = CodedUiWordTest.Controllers.Controllers;

namespace CodedUiWordTest.Tests
{
    /// <summary>
    /// Description of CodedUIWordTest.
    /// </summary>
    [TestModule("0037B6F8-FF52-4AC0-B51C-D0BD1A39F832", ModuleType.UserCode, 1)]
    public class WordMouseTest : ITestModule
    {
    	#region C'tor
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WordMouseTest()
        {
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
            Controller.OpenClick();
            Controller.Durchsuchen();
            Controller.Dateiname = @"C:\Workspace\PRO\RoSpro\server\CV.docx";
            Controller.OpenFile();
            Controller.WordClose();
            
            #endregion 
        }
    }
}
