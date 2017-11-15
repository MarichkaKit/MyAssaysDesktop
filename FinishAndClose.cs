﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace MyAssaysDesktopExplorer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FinishAndClose recording.
    /// </summary>
    [TestModule("3befec8c-fac3-46c8-991d-167fde75defd", ModuleType.Recording, 1)]
    public partial class FinishAndClose : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssaysDesktopExplorerRepository repository.
        /// </summary>
        public static MyAssaysDesktopExplorerRepository repo = MyAssaysDesktopExplorerRepository.Instance;

        static FinishAndClose instance = new FinishAndClose();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FinishAndClose()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FinishAndClose Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(0));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Focus() on item 'NewProtocolWizard'.", repo.NewProtocolWizard.SelfInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.Self.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.LaunchProtocol'.", repo.NewProtocolWizard.SomeContainer2.LaunchProtocolInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.SomeContainer2.LaunchProtocol.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(100);
            
            Mouse_Click_Finish();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'MyAssaysExplorer'.", repo.MyAssaysExplorer.SelfInfo, new RecordItemIndex(4));
            Host.Local.CloseApplication(repo.MyAssaysExplorer.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}