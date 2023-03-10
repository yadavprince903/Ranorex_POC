///////////////////////////////////////////////////////////////////////////////
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

namespace MyCRM.Recordings.Company.RG_004
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validate_default_values_comapny_tab recording.
    /// </summary>
    [TestModule("17f1c75a-8e40-4313-b549-5d5d3afb8d2a", ModuleType.Recording, 1)]
    public partial class Validate_default_values_comapny_tab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MyCRM.MyCRMRepository repository.
        /// </summary>
        public static global::MyCRM.MyCRMRepository repo = global::MyCRM.MyCRMRepository.Instance;

        static Validate_default_values_comapny_tab instance = new Validate_default_values_comapny_tab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_default_values_comapny_tab()
        {
            ComapnyName = "";
            AddLine1 = "";
            AddLine2 = "";
            City = "";
            State = "";
            Zip = "";
            Main = "";
            Other = "";
            Comments = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_default_values_comapny_tab Instance
        {
            get { return instance; }
        }

#region Variables

        string _ComapnyName;

        /// <summary>
        /// Gets or sets the value of variable ComapnyName.
        /// </summary>
        [TestVariable("604d1701-166b-4026-b1e4-6dac4cfdf5aa")]
        public string ComapnyName
        {
            get { return _ComapnyName; }
            set { _ComapnyName = value; }
        }

        string _AddLine1;

        /// <summary>
        /// Gets or sets the value of variable AddLine1.
        /// </summary>
        [TestVariable("db095ef4-5ea7-4ffa-b7b2-f118b3594c72")]
        public string AddLine1
        {
            get { return _AddLine1; }
            set { _AddLine1 = value; }
        }

        string _AddLine2;

        /// <summary>
        /// Gets or sets the value of variable AddLine2.
        /// </summary>
        [TestVariable("f2a83b62-ab24-4c9b-a969-67f4709ad6c1")]
        public string AddLine2
        {
            get { return _AddLine2; }
            set { _AddLine2 = value; }
        }

        string _City;

        /// <summary>
        /// Gets or sets the value of variable City.
        /// </summary>
        [TestVariable("4ed5f607-2ed4-4c98-8319-6da0a54ef415")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        string _State;

        /// <summary>
        /// Gets or sets the value of variable State.
        /// </summary>
        [TestVariable("6756e9dd-6d74-47b3-9ee5-bd7bf7202366")]
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        string _Zip;

        /// <summary>
        /// Gets or sets the value of variable Zip.
        /// </summary>
        [TestVariable("29423ec6-2a2b-490a-a143-0e9cc5e91c42")]
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }

        string _Main;

        /// <summary>
        /// Gets or sets the value of variable Main.
        /// </summary>
        [TestVariable("4ad0d2c6-1015-4027-8903-6159800c8977")]
        public string Main
        {
            get { return _Main; }
            set { _Main = value; }
        }

        string _Other;

        /// <summary>
        /// Gets or sets the value of variable Other.
        /// </summary>
        [TestVariable("f4f3cca3-6e33-4c09-8584-796c6d2918bf")]
        public string Other
        {
            get { return _Other; }
            set { _Other = value; }
        }

        string _Comments;

        /// <summary>
        /// Gets or sets the value of variable Comments.
        /// </summary>
        [TestVariable("5344634c-87f6-4089-afb0-7147fadb6a0b")]
        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyCRM.Navigation.Company' at Center.", repo.MyCRM.Navigation.CompanyInfo, new RecordItemIndex(0));
            repo.MyCRM.Navigation.Company.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ComapnyName) on item 'MyCRM.Company.CompanyName'.", repo.MyCRM.Company.CompanyNameInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MyCRM.Company.CompanyNameInfo, "Text", ComapnyName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddLine1) on item 'MyCRM.Company.TxtAddressLine1'.", repo.MyCRM.Company.TxtAddressLine1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtAddressLine1Info, "Text", AddLine1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddLine2) on item 'MyCRM.Company.TxtAddressLine2'.", repo.MyCRM.Company.TxtAddressLine2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtAddressLine2Info, "Text", AddLine2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$City) on item 'MyCRM.Company.TxtCity'.", repo.MyCRM.Company.TxtCityInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtCityInfo, "Text", City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zip) on item 'MyCRM.Company.TxtZip'.", repo.MyCRM.Company.TxtZipInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtZipInfo, "Text", Zip);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Main) on item 'MyCRM.Company.TxtMain'.", repo.MyCRM.Company.TxtMainInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtMainInfo, "Text", Main);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Other) on item 'MyCRM.Company.TxtOther'.", repo.MyCRM.Company.TxtOtherInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MyCRM.Company.TxtOtherInfo, "Text", Other);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
