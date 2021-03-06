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

namespace HBAuto_Install2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UninstallHB recording.
    /// </summary>
    [TestModule("aeb16780-eaa5-4bdc-8a60-f7b5e29157b7", ModuleType.Recording, 1)]
    public partial class UninstallHB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HBAuto_Install2Repository repository.
        /// </summary>
        public static HBAuto_Install2Repository repo = HBAuto_Install2Repository.Instance;

        static UninstallHB instance = new UninstallHB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UninstallHB()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UninstallHB Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 30s.", new RecordItemIndex(0));
                Delay.Duration(30000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s to exist. Associated repository item: 'ProgramsAndFeatures.SearchEditBox'", repo.ProgramsAndFeatures.SearchEditBoxInfo, new ActionTimeout(5000), new RecordItemIndex(1));
                repo.ProgramsAndFeatures.SearchEditBoxInfo.WaitForExists(5000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.SearchEditBox' at 2;10.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(2));
                repo.ProgramsAndFeatures.SearchEditBox.Click("2;10");
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence 'heavybid{Space}workstation' with focus on 'ProgramsAndFeatures.SearchEditBox'.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(3));
                repo.ProgramsAndFeatures.SearchEditBox.PressKeys("heavybid{Space}workstation");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstation'", repo.ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstationInfo, new ActionTimeout(10000), new RecordItemIndex(4));
                repo.ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstationInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstation' at Center.", repo.ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstationInfo, new RecordItemIndex(5));
                repo.ProgramsAndFeatures.UninstallProgramTable.HeavyBidWorkstation.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.ButtinUninstallOrChange'", repo.ProgramsAndFeatures.ButtinUninstallOrChangeInfo, new ActionTimeout(10000), new RecordItemIndex(6));
                repo.ProgramsAndFeatures.ButtinUninstallOrChangeInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.ButtinUninstallOrChange' at Center.", repo.ProgramsAndFeatures.ButtinUninstallOrChangeInfo, new RecordItemIndex(7));
                repo.ProgramsAndFeatures.ButtinUninstallOrChange.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'HeavyBidUninstall.ButtonYes'", repo.HeavyBidUninstall.ButtonYesInfo, new ActionTimeout(10000), new RecordItemIndex(8));
                repo.HeavyBidUninstall.ButtonYesInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidUninstall.ButtonYes' at Center.", repo.HeavyBidUninstall.ButtonYesInfo, new RecordItemIndex(9));
                repo.HeavyBidUninstall.ButtonYes.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
