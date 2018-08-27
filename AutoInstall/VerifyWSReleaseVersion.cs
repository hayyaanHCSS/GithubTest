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
    ///The VerifyWSReleaseVersion recording.
    /// </summary>
    [TestModule("cb4c18c0-63ba-4cc4-bb7a-9db4ac88a1ad", ModuleType.Recording, 1)]
    public partial class VerifyWSReleaseVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static VerifyWSReleaseVersion instance = new VerifyWSReleaseVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyWSReleaseVersion()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyWSReleaseVersion Instance
        {
            get { return instance; }
        }

#region Variables

        string _YearVersion;

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("7fa8b9cc-abd0-4357-8128-2d858c526e99")]
        public string YearVersion
        {
            get { return _YearVersion; }
            set { _YearVersion = value; }
        }

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup'", repo.HeavyBidServerSetup.SelfInfo, new ActionTimeout(60000), new RecordItemIndex(0));
            repo.HeavyBidServerSetup.SelfInfo.WaitForExists(60000);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'HeavyBid') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("HeavyBid"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'Workstation') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(2));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("Workstation"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(3));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleText'.", repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleTextInfo, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleTextInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainText'.", repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainTextInfo, new RecordItemIndex(5));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainTextInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.NextButton'", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.HeavyBidServerSetup.Buttons.NextButtonInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.NextButton' at Center.", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new RecordItemIndex(7));
            repo.HeavyBidServerSetup.Buttons.NextButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}