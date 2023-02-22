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

namespace MyCRM.Recordings.Other.RG_006
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateInputDataInOthers recording.
    /// </summary>
    [TestModule("73f85410-2773-44da-b139-8e067ed28f29", ModuleType.Recording, 1)]
    public partial class ValidateInputDataInOthers : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MyCRM.MyCRMRepository repository.
        /// </summary>
        public static global::MyCRM.MyCRMRepository repo = global::MyCRM.MyCRMRepository.Instance;

        static ValidateInputDataInOthers instance = new ValidateInputDataInOthers();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateInputDataInOthers()
        {
            Generic1 = "";
            Generic2 = "";
            Generic3 = "";
            Generic4 = "";
            Generic5 = "";
            Generic6 = "";
            Generic7 = "";
            Generic8 = "";
            Generic9 = "";
            Generic10 = "";
            BrowseButtonText = "";
            SaveButtonText = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateInputDataInOthers Instance
        {
            get { return instance; }
        }

#region Variables

        string _Generic1;

        /// <summary>
        /// Gets or sets the value of variable Generic1.
        /// </summary>
        [TestVariable("89e10b23-f9e4-4412-8cc2-07ba40ab3055")]
        public string Generic1
        {
            get { return _Generic1; }
            set { _Generic1 = value; }
        }

        string _Generic2;

        /// <summary>
        /// Gets or sets the value of variable Generic2.
        /// </summary>
        [TestVariable("9c10ba08-a147-4764-8243-c77a42f6e7a8")]
        public string Generic2
        {
            get { return _Generic2; }
            set { _Generic2 = value; }
        }

        string _Generic3;

        /// <summary>
        /// Gets or sets the value of variable Generic3.
        /// </summary>
        [TestVariable("cbcdd142-bfb9-4b3d-8438-88e37704c727")]
        public string Generic3
        {
            get { return _Generic3; }
            set { _Generic3 = value; }
        }

        string _Generic4;

        /// <summary>
        /// Gets or sets the value of variable Generic4.
        /// </summary>
        [TestVariable("85844364-96ba-44fe-b6cb-b50da941c74d")]
        public string Generic4
        {
            get { return _Generic4; }
            set { _Generic4 = value; }
        }

        string _Generic5;

        /// <summary>
        /// Gets or sets the value of variable Generic5.
        /// </summary>
        [TestVariable("421abfc4-3e5c-4d25-99a1-d92cb4f247a1")]
        public string Generic5
        {
            get { return _Generic5; }
            set { _Generic5 = value; }
        }

        string _Generic6;

        /// <summary>
        /// Gets or sets the value of variable Generic6.
        /// </summary>
        [TestVariable("d0d50fb2-39f8-4a42-9b5d-3e425dcccd29")]
        public string Generic6
        {
            get { return _Generic6; }
            set { _Generic6 = value; }
        }

        string _Generic7;

        /// <summary>
        /// Gets or sets the value of variable Generic7.
        /// </summary>
        [TestVariable("1090490a-9390-46bb-9f7d-59f6a1587c1f")]
        public string Generic7
        {
            get { return _Generic7; }
            set { _Generic7 = value; }
        }

        string _Generic8;

        /// <summary>
        /// Gets or sets the value of variable Generic8.
        /// </summary>
        [TestVariable("ae62bbda-c470-4b14-8b8f-9a65edcc84a9")]
        public string Generic8
        {
            get { return _Generic8; }
            set { _Generic8 = value; }
        }

        string _Generic9;

        /// <summary>
        /// Gets or sets the value of variable Generic9.
        /// </summary>
        [TestVariable("29f2e16c-1bfa-4526-b063-6c630a2e22cc")]
        public string Generic9
        {
            get { return _Generic9; }
            set { _Generic9 = value; }
        }

        string _Generic10;

        /// <summary>
        /// Gets or sets the value of variable Generic10.
        /// </summary>
        [TestVariable("398e12c6-b27e-4b8a-bdb1-0d120ebdadf1")]
        public string Generic10
        {
            get { return _Generic10; }
            set { _Generic10 = value; }
        }

        string _BrowseButtonText;

        /// <summary>
        /// Gets or sets the value of variable BrowseButtonText.
        /// </summary>
        [TestVariable("53b0b9d9-deff-445c-9c04-b4e4f7a1b500")]
        public string BrowseButtonText
        {
            get { return _BrowseButtonText; }
            set { _BrowseButtonText = value; }
        }

        string _SaveButtonText;

        /// <summary>
        /// Gets or sets the value of variable SaveButtonText.
        /// </summary>
        [TestVariable("0f367d7b-155e-4e32-a99d-3ac2f02c31a0")]
        public string SaveButtonText
        {
            get { return _SaveButtonText; }
            set { _SaveButtonText = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyCRM.Navigation.Other' at Center.", repo.MyCRM.Navigation.OtherInfo, new RecordItemIndex(0));
            repo.MyCRM.Navigation.Other.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic1' with focus on 'MyCRM.Other.TxtGeneric1'.", repo.MyCRM.Other.TxtGeneric1Info, new RecordItemIndex(1));
            repo.MyCRM.Other.TxtGeneric1.PressKeys(Generic1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic1) on item 'MyCRM.Other.TxtGeneric1'.", repo.MyCRM.Other.TxtGeneric1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric1Info, "Text", Generic1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic2' with focus on 'MyCRM.Other.TxtGeneric2'.", repo.MyCRM.Other.TxtGeneric2Info, new RecordItemIndex(3));
            repo.MyCRM.Other.TxtGeneric2.PressKeys(Generic2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic2) on item 'MyCRM.Other.TxtGeneric2'.", repo.MyCRM.Other.TxtGeneric2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric2Info, "Text", Generic2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic3' with focus on 'MyCRM.Other.TxtGeneric3'.", repo.MyCRM.Other.TxtGeneric3Info, new RecordItemIndex(5));
            repo.MyCRM.Other.TxtGeneric3.PressKeys(Generic3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic3) on item 'MyCRM.Other.TxtGeneric3'.", repo.MyCRM.Other.TxtGeneric3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric3Info, "Text", Generic3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic4' with focus on 'MyCRM.Other.TxtGeneric4'.", repo.MyCRM.Other.TxtGeneric4Info, new RecordItemIndex(7));
            repo.MyCRM.Other.TxtGeneric4.PressKeys(Generic4);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic4) on item 'MyCRM.Other.TxtGeneric4'.", repo.MyCRM.Other.TxtGeneric4Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric4Info, "Text", Generic4);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic5' with focus on 'MyCRM.Other.TxtGeneric5'.", repo.MyCRM.Other.TxtGeneric5Info, new RecordItemIndex(9));
            repo.MyCRM.Other.TxtGeneric5.PressKeys(Generic5);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic5) on item 'MyCRM.Other.TxtGeneric5'.", repo.MyCRM.Other.TxtGeneric5Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric5Info, "Text", Generic5);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic6' with focus on 'MyCRM.Other.TxtGeneric6'.", repo.MyCRM.Other.TxtGeneric6Info, new RecordItemIndex(11));
            repo.MyCRM.Other.TxtGeneric6.PressKeys(Generic6);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic6) on item 'MyCRM.Other.TxtGeneric6'.", repo.MyCRM.Other.TxtGeneric6Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric6Info, "Text", Generic6);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic7' with focus on 'MyCRM.Other.TxtGeneric7'.", repo.MyCRM.Other.TxtGeneric7Info, new RecordItemIndex(13));
            repo.MyCRM.Other.TxtGeneric7.PressKeys(Generic7);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic7) on item 'MyCRM.Other.TxtGeneric7'.", repo.MyCRM.Other.TxtGeneric7Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric7Info, "Text", Generic7);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic8' with focus on 'MyCRM.Other.TxtGeneric8'.", repo.MyCRM.Other.TxtGeneric8Info, new RecordItemIndex(15));
            repo.MyCRM.Other.TxtGeneric8.PressKeys(Generic8);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic8) on item 'MyCRM.Other.TxtGeneric8'.", repo.MyCRM.Other.TxtGeneric8Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric8Info, "Text", Generic8);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic9' with focus on 'MyCRM.Other.TxtGeneric9'.", repo.MyCRM.Other.TxtGeneric9Info, new RecordItemIndex(17));
            repo.MyCRM.Other.TxtGeneric9.PressKeys(Generic9);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic9) on item 'MyCRM.Other.TxtGeneric9'.", repo.MyCRM.Other.TxtGeneric9Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric9Info, "Text", Generic9);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Generic10' with focus on 'MyCRM.Other.TxtGeneric10'.", repo.MyCRM.Other.TxtGeneric10Info, new RecordItemIndex(19));
            repo.MyCRM.Other.TxtGeneric10.PressKeys(Generic10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Generic10) on item 'MyCRM.Other.TxtGeneric10'.", repo.MyCRM.Other.TxtGeneric10Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.MyCRM.Other.TxtGeneric10Info, "Text", Generic10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyCRM.Other.Browse' at Center.", repo.MyCRM.Other.BrowseInfo, new RecordItemIndex(21));
            repo.MyCRM.Other.Browse.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BrowseButtonText) on item 'Alert.Title'.", repo.Alert.TitleInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.Alert.TitleInfo, "Text", BrowseButtonText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Alert.OkButton' at Center.", repo.Alert.OkButtonInfo, new RecordItemIndex(23));
            repo.Alert.OkButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyCRM.Other.Save' at Center.", repo.MyCRM.Other.SaveInfo, new RecordItemIndex(24));
            repo.MyCRM.Other.Save.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$SaveButtonText) on item 'Alert.Title'.", repo.Alert.TitleInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.Alert.TitleInfo, "Text", SaveButtonText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Alert.OkButton' at Center.", repo.Alert.OkButtonInfo, new RecordItemIndex(26));
            repo.Alert.OkButton.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}