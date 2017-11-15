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
    ///The NewProtocol recording.
    /// </summary>
    [TestModule("6c560d9e-e426-4a2a-90b8-ce3ac5171024", ModuleType.Recording, 1)]
    public partial class NewProtocol : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssaysDesktopExplorerRepository repository.
        /// </summary>
        public static MyAssaysDesktopExplorerRepository repo = MyAssaysDesktopExplorerRepository.Instance;

        static NewProtocol instance = new NewProtocol();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewProtocol()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewProtocol Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.SomeContainer1.SomeText' at 22;9.", repo.MyAssaysExplorer.SomeContainer1.SomeTextInfo, new RecordItemIndex(0));
            repo.MyAssaysExplorer.SomeContainer1.SomeText.Click("22;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.OptionMark' at Center.", repo.NewProtocolWizard.SomeContainer2.OptionMarkInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.SomeContainer2.OptionMark.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.Next' at Center.", repo.NewProtocolWizard.SomeContainer2.NextInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.SomeContainer2.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}