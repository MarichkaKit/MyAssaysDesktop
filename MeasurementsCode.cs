/*
 * Created by Ranorex
 * User: Mary
 * Date: 12/11/2017
 * Time: 13:39
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
    /// Description of MeasurementsCode.
    /// </summary>
    [TestModule("9E0FB859-E169-4A50-8336-54026972C35C", ModuleType.UserCode, 1)]
    public class MeasurementsCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MeasurementsCode()
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
