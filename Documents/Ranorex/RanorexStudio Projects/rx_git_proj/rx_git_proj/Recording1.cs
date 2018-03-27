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

namespace rx_git_proj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("9c8e9f8c-5a3c-4469-be9d-49f4b525a9a4", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the rx_git_projRepository repository.
        /// </summary>
        public static rx_git_projRepository repo = rx_git_projRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Users\\Giovanni Hanselius\\Documents\\Ranorex\\RanorexStudio Projects\\Samples\\KeePassTestSuite\\KeePassTestSuite\\KeePass\\KeePass.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Users\\Giovanni Hanselius\\Documents\\Ranorex\\RanorexStudio Projects\\Samples\\KeePassTestSuite\\KeePassTestSuite\\KeePass\\KeePass.exe", "", "C:\\Users\\Giovanni Hanselius\\Documents\\Ranorex\\RanorexStudio Projects\\Samples\\KeePassTestSuite\\KeePassTestSuite\\KeePass", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Documents.Clipboard' at 609;186.", repo.Documents.ClipboardInfo, new RecordItemIndex(1));
            repo.Documents.Clipboard.Click("609;186");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Documents.TitleBar' at 729;48.", repo.Documents.TitleBarInfo, new RecordItemIndex(2));
            repo.Documents.TitleBar.Click("729;48");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.TortoiseGitClient1RunningWindow' at 69;50.", repo.Explorer.TortoiseGitClient1RunningWindowInfo, new RecordItemIndex(3));
            repo.Explorer.TortoiseGitClient1RunningWindow.Click("69;50");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.RanorexStudio1RunningWindow' at 75;55.", repo.Explorer.RanorexStudio1RunningWindowInfo, new RecordItemIndex(4));
            repo.Explorer.RanorexStudio1RunningWindow.Click("75;55");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Explorer1.List1' at 2601;3414.", repo.Explorer1.List1Info, new RecordItemIndex(5));
            repo.Explorer1.List1.MoveTo("2601;3414");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Explorer1.List1' at 2575;3287.", repo.Explorer1.List1Info, new RecordItemIndex(6));
            repo.Explorer1.List1.MoveTo("2575;3287");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.RanorexStudio1RunningWindow' at 49;69.", repo.Explorer.RanorexStudio1RunningWindowInfo, new RecordItemIndex(7));
            repo.Explorer.RanorexStudio1RunningWindow.Click("49;69");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{p up}{LWin up}'.", new RecordItemIndex(8));
            Keyboard.Press("{p up}{LWin up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LWin down}{p up}{LWin up}'.", new RecordItemIndex(9));
            Keyboard.Press("{LWin down}{p up}{LWin up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LWin down}{p up}{LWin up}'.", new RecordItemIndex(10));
            Keyboard.Press("{LWin down}{p up}{LWin up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
