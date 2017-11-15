/*
 * Created by Ranorex
 * User: Mary
 * Date: 12/11/2017
 * Time: 15:18
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
    /// Description of CloseSUT.
    /// </summary>
    [TestModule("E0450D66-EE7D-4180-A636-8522CED3EFC6", ModuleType.UserCode, 1)]
    public class CloseSUT : ITestModule
    	
    {
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseSUT()
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
           
           List someList = "/form[@wpfnative='True' and @title='New Protocol Wizard' and @processname='MyAssays.Desktop.Explorer']/element/container/element/container/container/list[1]";
           someList.Click();
           
           Unknown someElement = "/form[@wpfnative='True' and @title='New Protocol Wizard' and @processname='MyAssays.Desktop.Explorer']/element/container/element/container/container/list[1]/element";
           
           Button закрити = "/form[@wpfnative='True' and @title='New Protocol Wizard' and @processname='MyAssays.Desktop.Explorer']/?/?/button[@accessiblename='Закрити']";
           закрити.Click();
           
        }
    }
}
