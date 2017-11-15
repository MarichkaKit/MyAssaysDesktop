/*
 * Created by Ranorex
 * User: User
 * Date: 15.11.2017
 * Time: 13:51
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
    /// Description of Close.
    /// </summary>
    [TestModule("178057AE-A48E-4BB1-9A2C-68767058EB3F", ModuleType.UserCode, 1)]
    public class Close : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close()
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Закрити' at 19;17.", repo.NewProtocolWizard.ЗакритиInfo);
            //repo.NewProtocolWizard.Закрити.Click();

            //Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'MyAssaysExplorer'.", repo.MyAssaysExplorer.SelfInfo, new RecordItemIndex(4));
            //Host.Local.CloseApplication(repo.MyAssaysExplorer.Self, new Duration(0));
            Delay.Milliseconds(0);
            
         
            //Button закрити = "/form[@wpfnative='True' and @title='New Protocol Wizard' and @processname='MyAssays.Desktop.Explorer']/?/?/button[@accessiblename='Закрити']";
            
            //закрити.Click();
        }
    }
}
