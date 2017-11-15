/*
 * Created by Ranorex
 * User: Mary
 * Date: 12/11/2017
 * Time: 13:41
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
    /// Description of FormatCode.
    /// </summary>
    [TestModule("B639B2B9-3C96-4CF6-975A-B9EA2D75C693", ModuleType.UserCode, 1)]
    public class FormatCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormatCode()
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
            var next = repo.NewProtocolWizard.SomeContainer2.Next;
            
            next.Click();

        }
    }
}
