/*
 * Created by Ranorex
 * User: Mary
 * Date: 12/11/2017
 * Time: 15:03
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
    /// Description of ListOfMeasurements.
    /// </summary>
    [TestModule("B7BCFD3F-B782-4156-B66E-EE161EBF1251", ModuleType.UserCode, 1)]
    public class ListOfMeasurements : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ListOfMeasurements()
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
            
            IList<Ranorex.Button> bButtons = Host.Local.Find <Ranorex.Button>("element/container/container/list[1]");
            
            foreach (Ranorex.Button bButton in bButtons)
            {
            	bButton.MoveTo();
            
            	Ranorex.Report.Screenshot (bButton);
            	Ranorex.Report.Info("List of measurements");
            	Ranorex.Delay.Milliseconds(200);
            }
        }
    }
}
