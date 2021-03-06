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

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InstallWelcomeCrystal recording.
    /// </summary>
    [TestModule("61b87029-e35d-459c-a403-ec3c8744d87c", ModuleType.Recording, 1)]
    public partial class InstallWelcomeCrystal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static InstallWelcomeCrystal instance = new InstallWelcomeCrystal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallWelcomeCrystal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallWelcomeCrystal Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'CrystalInstallation.CrystalInstaller'", repo.CrystalInstallation.CrystalInstaller.SelfInfo, new ActionTimeout(300000), new RecordItemIndex(0));
            repo.CrystalInstallation.CrystalInstaller.SelfInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 15s to exist. Associated repository item: 'CrystalInstallation.CrystalInstaller.NextButton'", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new ActionTimeout(15000), new RecordItemIndex(2));
                repo.CrystalInstallation.CrystalInstaller.NextButtonInfo.WaitForExists(15000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'CrystalInstallation.CrystalInstaller.NextButton' at Center.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(3));
                repo.CrystalInstallation.CrystalInstaller.NextButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 15s to exist. Associated repository item: 'CrystalInstallation.CrystalInstaller.InstallButton'", repo.CrystalInstallation.CrystalInstaller.InstallButtonInfo, new ActionTimeout(15000), new RecordItemIndex(4));
                repo.CrystalInstallation.CrystalInstaller.InstallButtonInfo.WaitForExists(15000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'CrystalInstallation.CrystalInstaller.InstallButton' at Center.", repo.CrystalInstallation.CrystalInstaller.InstallButtonInfo, new RecordItemIndex(5));
                repo.CrystalInstallation.CrystalInstaller.InstallButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'CrystalInstallation.CrystalInstaller.FinishButton'", repo.CrystalInstallation.CrystalInstaller.FinishButtonInfo, new ActionTimeout(30000), new RecordItemIndex(6));
                repo.CrystalInstallation.CrystalInstaller.FinishButtonInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'CrystalInstallation.CrystalInstaller.FinishButton' at Center.", repo.CrystalInstallation.CrystalInstaller.FinishButtonInfo, new RecordItemIndex(7));
                repo.CrystalInstallation.CrystalInstaller.FinishButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
