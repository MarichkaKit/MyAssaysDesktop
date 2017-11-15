/*
 * Created by Ranorex
 * User: Mary
 * Date: 12/11/2017
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace MyAssaysDesktopExplorer
{
    /// <summary>
    /// Description of AddSampleTypeCode.
    /// </summary>
    [TestModule("CFDF7E56-9CFD-4B76-9D1A-93EC569AFF32", ModuleType.UserCode, 1)]
    public class AddSampleTypeCodeClose : ITestModule
    	
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
       
        public AddSampleTypeCodeClose()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = MyAssaysDesktopExplorerRepository.Instance;
            var addSampleType = repo.SampleTypesEditor.SomeContainer2.AddSampleType;
            var someContainer = repo.MyAssaysExplorer.SomeContainer1.SomeContainer;
          
           Button закрити = "/form[@wpfnative='True' and @title='Sample Types Editor' and @processname='MyAssays.Desktop.Explorer']/?/?/button[@accessiblename='Закрити']";
           закрити.Click();

        }
    }
}
