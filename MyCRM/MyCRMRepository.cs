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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyCRM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyCRMRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("320422cc-3ab0-40a5-848a-96c127c13395")]
    public partial class MyCRMRepository : RepoGenBaseFolder
    {
        static MyCRMRepository instance = new MyCRMRepository();
        MyCRMRepositoryFolders.MyCRMAppFolder _mycrm;

        /// <summary>
        /// Gets the singleton class instance representing the MyCRMRepository element repository.
        /// </summary>
        [RepositoryFolder("320422cc-3ab0-40a5-848a-96c127c13395")]
        public static MyCRMRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyCRMRepository() 
            : base("MyCRMRepository", "/", null, 0, false, "320422cc-3ab0-40a5-848a-96c127c13395", ".\\RepositoryImages\\MyCRMRepository320422cc.rximgres")
        {
            _mycrm = new MyCRMRepositoryFolders.MyCRMAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("320422cc-3ab0-40a5-848a-96c127c13395")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MyCRM folder.
        /// </summary>
        [RepositoryFolder("49c06412-954f-4f86-8daa-ddc85200f715")]
        public virtual MyCRMRepositoryFolders.MyCRMAppFolder MyCRM
        {
            get { return _mycrm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyCRMRepositoryFolders
    {
        /// <summary>
        /// The MyCRMAppFolder folder.
        /// </summary>
        [RepositoryFolder("49c06412-954f-4f86-8daa-ddc85200f715")]
        public partial class MyCRMAppFolder : RepoGenBaseFolder
        {
            MyCRMRepositoryFolders.PeopleFolder _people;
            MyCRMRepositoryFolders.CompanyFolder _company;
            MyCRMRepositoryFolders.NavigationFolder _navigation;

            /// <summary>
            /// Creates a new MyCRM  folder.
            /// </summary>
            public MyCRMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MyCRM", "/form[@controlname='Form1']/?/?", parentFolder, 30000, null, false, "49c06412-954f-4f86-8daa-ddc85200f715", "")
            {
                _people = new MyCRMRepositoryFolders.PeopleFolder(this);
                _company = new MyCRMRepositoryFolders.CompanyFolder(this);
                _navigation = new MyCRMRepositoryFolders.NavigationFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("49c06412-954f-4f86-8daa-ddc85200f715")]
            public virtual Ranorex.Unknown Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("49c06412-954f-4f86-8daa-ddc85200f715")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The People folder.
            /// </summary>
            [RepositoryFolder("e94d6010-509d-4b53-8f15-61503a6a1411")]
            public virtual MyCRMRepositoryFolders.PeopleFolder People
            {
                get { return _people; }
            }

            /// <summary>
            /// The Company folder.
            /// </summary>
            [RepositoryFolder("6741e82e-ec3b-4d2f-8c4c-23dc101f2b01")]
            public virtual MyCRMRepositoryFolders.CompanyFolder Company
            {
                get { return _company; }
            }

            /// <summary>
            /// The Navigation folder.
            /// </summary>
            [RepositoryFolder("3c3167bb-0bd8-4bbe-ab1d-1513efefc36e")]
            public virtual MyCRMRepositoryFolders.NavigationFolder Navigation
            {
                get { return _navigation; }
            }
        }

        /// <summary>
        /// The PeopleFolder folder.
        /// </summary>
        [RepositoryFolder("e94d6010-509d-4b53-8f15-61503a6a1411")]
        public partial class PeopleFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstInfo;
            RepoItemInfo _lastInfo;
            RepoItemInfo _maleInfo;
            RepoItemInfo _femaleInfo;
            RepoItemInfo _addressline1Info;
            RepoItemInfo _addressline2Info;
            RepoItemInfo _cityInfo;
            RepoItemInfo _stateInfo;
            RepoItemInfo _zipInfo;
            RepoItemInfo _homeInfo;
            RepoItemInfo _workInfo;
            RepoItemInfo _mobileInfo;
            RepoItemInfo _personalmailInfo;
            RepoItemInfo _workmailInfo;
            RepoItemInfo _activeInfo;
            RepoItemInfo _commentsInfo;

            /// <summary>
            /// Creates a new People  folder.
            /// </summary>
            public PeopleFolder(RepoGenBaseFolder parentFolder) :
                    base("People", "", parentFolder, 0, null, false, "e94d6010-509d-4b53-8f15-61503a6a1411", "")
            {
                _firstInfo = new RepoItemInfo(this, "First", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox5']/?/?/text[@accessiblename='First:']", "", 30000, null, "38ff9c73-1bdf-468e-8567-eebdc3569b75");
                _lastInfo = new RepoItemInfo(this, "Last", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox5']/?/?/text[@accessiblename='Last:']", "", 30000, null, "1ff75e9c-8f84-4076-9191-c4bf9dc43cdb");
                _maleInfo = new RepoItemInfo(this, "Male", "tabpage[@controlname='tabPagePeople']/?/?/radiobutton[@controlname='radioButtonMale']", "", 30000, null, "e1801a9f-06ff-4048-a697-8099022b84f8");
                _femaleInfo = new RepoItemInfo(this, "Female", "tabpage[@controlname='tabPagePeople']/?/?/radiobutton[@controlname='radioButtonFemale']", "element", 30000, null, "875b9d47-71c9-4223-b268-7962bc5ee414");
                _addressline1Info = new RepoItemInfo(this, "Addressline1", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox1']/?/?/text[@accessiblename='Add Line 1:']", "element", 30000, null, "cdb4eb91-b0ee-4ca9-b162-29e8be384b9c");
                _addressline2Info = new RepoItemInfo(this, "Addressline2", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox1']/?/?/text[@accessiblename='Add Line 2:']", "element", 30000, null, "9ed4d4de-23e7-459f-b7e9-95e858087ab0");
                _cityInfo = new RepoItemInfo(this, "City", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox1']/?/?/text[@accessiblename='City:']", "element", 30000, null, "580cf3d3-59f7-4c3e-a161-f70ec03171b3");
                _stateInfo = new RepoItemInfo(this, "State", "tabpage[@controlname='tabPagePeople']/?/?/combobox[@controlname='comboBoxPeopleAddressState']", "element", 30000, null, "dda4586d-d628-4561-84d2-f0a3b845f13d");
                _zipInfo = new RepoItemInfo(this, "Zip", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox1']/?/?/text[@accessiblename='Zip:']", "element", 30000, null, "c9c0e1ea-89e5-4064-8a77-08ae5fade462");
                _homeInfo = new RepoItemInfo(this, "Home", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox2']/?/?/text[@accessiblename='Home:']", "element", 30000, null, "4fbaed2d-4c54-4b73-8030-6fe9e4a3ce8f");
                _workInfo = new RepoItemInfo(this, "Work", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox2']/?/?/text[@accessiblename='Work:']", "element", 30000, null, "fa3af862-a7cf-4af6-9f1a-c4ab39cfb8ec");
                _mobileInfo = new RepoItemInfo(this, "Mobile", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox2']/?/?/text[@accessiblename='Mobile:']", "element", 30000, null, "b3421d84-682e-4fad-b99f-1e9963912f88");
                _personalmailInfo = new RepoItemInfo(this, "Personalmail", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox4']/?/?/text[@accessiblename='Personal:']", "element", 30000, null, "3fc55c3a-aa05-4fc9-93a4-02b1a53a1324");
                _workmailInfo = new RepoItemInfo(this, "Workmail", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox4']/?/?/text[@accessiblename='Work:']", "element", 30000, null, "9fc16568-08b1-487a-9cbd-9726e9d4a2e7");
                _activeInfo = new RepoItemInfo(this, "Active", "tabpage[@controlname='tabPagePeople']/?/?/checkbox[@controlname='checkBox1']", "element", 30000, null, "11efd133-881c-477d-b063-d645a2d2e2a2");
                _commentsInfo = new RepoItemInfo(this, "Comments", "tabpage[@controlname='tabPagePeople']/container[@controlname='groupBox3']/?/?/text[@accessiblerole='Text']", "element", 30000, null, "ed6ea948-49ca-483c-abda-e08c8ca260b0");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e94d6010-509d-4b53-8f15-61503a6a1411")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The First item.
            /// </summary>
            [RepositoryItem("38ff9c73-1bdf-468e-8567-eebdc3569b75")]
            public virtual Ranorex.Text First
            {
                get
                {
                    return _firstInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The First item info.
            /// </summary>
            [RepositoryItemInfo("38ff9c73-1bdf-468e-8567-eebdc3569b75")]
            public virtual RepoItemInfo FirstInfo
            {
                get
                {
                    return _firstInfo;
                }
            }

            /// <summary>
            /// The Last item.
            /// </summary>
            [RepositoryItem("1ff75e9c-8f84-4076-9191-c4bf9dc43cdb")]
            public virtual Ranorex.Text Last
            {
                get
                {
                    return _lastInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Last item info.
            /// </summary>
            [RepositoryItemInfo("1ff75e9c-8f84-4076-9191-c4bf9dc43cdb")]
            public virtual RepoItemInfo LastInfo
            {
                get
                {
                    return _lastInfo;
                }
            }

            /// <summary>
            /// The Male item.
            /// </summary>
            [RepositoryItem("e1801a9f-06ff-4048-a697-8099022b84f8")]
            public virtual Ranorex.RadioButton Male
            {
                get
                {
                    return _maleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Male item info.
            /// </summary>
            [RepositoryItemInfo("e1801a9f-06ff-4048-a697-8099022b84f8")]
            public virtual RepoItemInfo MaleInfo
            {
                get
                {
                    return _maleInfo;
                }
            }

            /// <summary>
            /// The Female item.
            /// </summary>
            [RepositoryItem("875b9d47-71c9-4223-b268-7962bc5ee414")]
            public virtual Ranorex.RadioButton Female
            {
                get
                {
                    return _femaleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Female item info.
            /// </summary>
            [RepositoryItemInfo("875b9d47-71c9-4223-b268-7962bc5ee414")]
            public virtual RepoItemInfo FemaleInfo
            {
                get
                {
                    return _femaleInfo;
                }
            }

            /// <summary>
            /// The Addressline1 item.
            /// </summary>
            [RepositoryItem("cdb4eb91-b0ee-4ca9-b162-29e8be384b9c")]
            public virtual Ranorex.Text Addressline1
            {
                get
                {
                    return _addressline1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Addressline1 item info.
            /// </summary>
            [RepositoryItemInfo("cdb4eb91-b0ee-4ca9-b162-29e8be384b9c")]
            public virtual RepoItemInfo Addressline1Info
            {
                get
                {
                    return _addressline1Info;
                }
            }

            /// <summary>
            /// The Addressline2 item.
            /// </summary>
            [RepositoryItem("9ed4d4de-23e7-459f-b7e9-95e858087ab0")]
            public virtual Ranorex.Text Addressline2
            {
                get
                {
                    return _addressline2Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Addressline2 item info.
            /// </summary>
            [RepositoryItemInfo("9ed4d4de-23e7-459f-b7e9-95e858087ab0")]
            public virtual RepoItemInfo Addressline2Info
            {
                get
                {
                    return _addressline2Info;
                }
            }

            /// <summary>
            /// The City item.
            /// </summary>
            [RepositoryItem("580cf3d3-59f7-4c3e-a161-f70ec03171b3")]
            public virtual Ranorex.Text City
            {
                get
                {
                    return _cityInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The City item info.
            /// </summary>
            [RepositoryItemInfo("580cf3d3-59f7-4c3e-a161-f70ec03171b3")]
            public virtual RepoItemInfo CityInfo
            {
                get
                {
                    return _cityInfo;
                }
            }

            /// <summary>
            /// The State item.
            /// </summary>
            [RepositoryItem("dda4586d-d628-4561-84d2-f0a3b845f13d")]
            public virtual Ranorex.ComboBox State
            {
                get
                {
                    return _stateInfo.CreateAdapter<Ranorex.ComboBox>(true);
                }
            }

            /// <summary>
            /// The State item info.
            /// </summary>
            [RepositoryItemInfo("dda4586d-d628-4561-84d2-f0a3b845f13d")]
            public virtual RepoItemInfo StateInfo
            {
                get
                {
                    return _stateInfo;
                }
            }

            /// <summary>
            /// The Zip item.
            /// </summary>
            [RepositoryItem("c9c0e1ea-89e5-4064-8a77-08ae5fade462")]
            public virtual Ranorex.Text Zip
            {
                get
                {
                    return _zipInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Zip item info.
            /// </summary>
            [RepositoryItemInfo("c9c0e1ea-89e5-4064-8a77-08ae5fade462")]
            public virtual RepoItemInfo ZipInfo
            {
                get
                {
                    return _zipInfo;
                }
            }

            /// <summary>
            /// The Home item.
            /// </summary>
            [RepositoryItem("4fbaed2d-4c54-4b73-8030-6fe9e4a3ce8f")]
            public virtual Ranorex.Text Home
            {
                get
                {
                    return _homeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Home item info.
            /// </summary>
            [RepositoryItemInfo("4fbaed2d-4c54-4b73-8030-6fe9e4a3ce8f")]
            public virtual RepoItemInfo HomeInfo
            {
                get
                {
                    return _homeInfo;
                }
            }

            /// <summary>
            /// The Work item.
            /// </summary>
            [RepositoryItem("fa3af862-a7cf-4af6-9f1a-c4ab39cfb8ec")]
            public virtual Ranorex.Text Work
            {
                get
                {
                    return _workInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Work item info.
            /// </summary>
            [RepositoryItemInfo("fa3af862-a7cf-4af6-9f1a-c4ab39cfb8ec")]
            public virtual RepoItemInfo WorkInfo
            {
                get
                {
                    return _workInfo;
                }
            }

            /// <summary>
            /// The Mobile item.
            /// </summary>
            [RepositoryItem("b3421d84-682e-4fad-b99f-1e9963912f88")]
            public virtual Ranorex.Text Mobile
            {
                get
                {
                    return _mobileInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Mobile item info.
            /// </summary>
            [RepositoryItemInfo("b3421d84-682e-4fad-b99f-1e9963912f88")]
            public virtual RepoItemInfo MobileInfo
            {
                get
                {
                    return _mobileInfo;
                }
            }

            /// <summary>
            /// The Personalmail item.
            /// </summary>
            [RepositoryItem("3fc55c3a-aa05-4fc9-93a4-02b1a53a1324")]
            public virtual Ranorex.Text Personalmail
            {
                get
                {
                    return _personalmailInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Personalmail item info.
            /// </summary>
            [RepositoryItemInfo("3fc55c3a-aa05-4fc9-93a4-02b1a53a1324")]
            public virtual RepoItemInfo PersonalmailInfo
            {
                get
                {
                    return _personalmailInfo;
                }
            }

            /// <summary>
            /// The Workmail item.
            /// </summary>
            [RepositoryItem("9fc16568-08b1-487a-9cbd-9726e9d4a2e7")]
            public virtual Ranorex.Text Workmail
            {
                get
                {
                    return _workmailInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Workmail item info.
            /// </summary>
            [RepositoryItemInfo("9fc16568-08b1-487a-9cbd-9726e9d4a2e7")]
            public virtual RepoItemInfo WorkmailInfo
            {
                get
                {
                    return _workmailInfo;
                }
            }

            /// <summary>
            /// The Active item.
            /// </summary>
            [RepositoryItem("11efd133-881c-477d-b063-d645a2d2e2a2")]
            public virtual Ranorex.CheckBox Active
            {
                get
                {
                    return _activeInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The Active item info.
            /// </summary>
            [RepositoryItemInfo("11efd133-881c-477d-b063-d645a2d2e2a2")]
            public virtual RepoItemInfo ActiveInfo
            {
                get
                {
                    return _activeInfo;
                }
            }

            /// <summary>
            /// The Comments item.
            /// </summary>
            [RepositoryItem("ed6ea948-49ca-483c-abda-e08c8ca260b0")]
            public virtual Ranorex.Text Comments
            {
                get
                {
                    return _commentsInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Comments item info.
            /// </summary>
            [RepositoryItemInfo("ed6ea948-49ca-483c-abda-e08c8ca260b0")]
            public virtual RepoItemInfo CommentsInfo
            {
                get
                {
                    return _commentsInfo;
                }
            }
        }

        /// <summary>
        /// The CompanyFolder folder.
        /// </summary>
        [RepositoryFolder("6741e82e-ec3b-4d2f-8c4c-23dc101f2b01")]
        public partial class CompanyFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labeladdline1Info;
            RepoItemInfo _labeladdline2Info;
            RepoItemInfo _labelcityInfo;
            RepoItemInfo _labelstateInfo;
            RepoItemInfo _labelzipInfo;
            RepoItemInfo _labemainInfo;
            RepoItemInfo _labelotherInfo;
            RepoItemInfo _dropdownstateInfo;
            RepoItemInfo _commentboxInfo;
            RepoItemInfo _txtaddressline1Info;
            RepoItemInfo _txtaddressline2Info;
            RepoItemInfo _txtcityInfo;
            RepoItemInfo _txtzipInfo;
            RepoItemInfo _txtmainInfo;
            RepoItemInfo _txtotherInfo;

            /// <summary>
            /// Creates a new Company  folder.
            /// </summary>
            public CompanyFolder(RepoGenBaseFolder parentFolder) :
                    base("Company", "", parentFolder, 0, null, false, "6741e82e-ec3b-4d2f-8c4c-23dc101f2b01", "")
            {
                _labeladdline1Info = new RepoItemInfo(this, "LabelAddLine1", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label22']", "element", 30000, null, "7b75f60f-32b6-4f20-9418-16e6c61b62d6");
                _labeladdline2Info = new RepoItemInfo(this, "LabelAddLine2", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label21']", "element", 30000, null, "7e363e15-abc4-4287-a46b-bcee1a06d4f1");
                _labelcityInfo = new RepoItemInfo(this, "LabelCity", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label20']", "element", 30000, null, "779072db-e2e8-470f-adc0-5380f608e5a4");
                _labelstateInfo = new RepoItemInfo(this, "LabelState", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label19']", "element", 30000, null, "df73478f-20e8-4720-95cb-13764a4229e4");
                _labelzipInfo = new RepoItemInfo(this, "LabelZip", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label18']", "element", 30000, null, "f5c6e247-fa1d-43ee-80d1-5712f26e316f");
                _labemainInfo = new RepoItemInfo(this, "LabeMain", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label17']", "element", 30000, null, "8337b98d-a2b2-4def-b286-35bcd8c48525");
                _labelotherInfo = new RepoItemInfo(this, "LabelOther", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='label16']", "element", 30000, null, "5d4a6c93-4aae-4ed3-8730-9121950548a5");
                _dropdownstateInfo = new RepoItemInfo(this, "DropDownState", "tabpage[@controlname='tabPageCompanies']/?/?/combobox[@controlname='comboBoxCompaniesAddressState']", "element", 30000, null, "e65fc614-8bd2-4d04-9252-de0eb6329387");
                _commentboxInfo = new RepoItemInfo(this, "CommentBox", "tabpage[@controlname='tabPageCompanies']/container[@controlname='groupBox7']/?/?/text[@accessiblerole='Text']", "element", 30000, null, "f6838123-bdd2-4b00-9eb6-cb045d61d0e3");
                _txtaddressline1Info = new RepoItemInfo(this, "TxtAddressLine1", "tabpage[@controlname='tabPageCompanies']/container[@controlname='groupBox9']/?/?/text[@accessiblename='Add Line 1:']", "element", 30000, null, "b60ecbbf-17c2-4de7-933e-459db99e9516");
                _txtaddressline2Info = new RepoItemInfo(this, "TxtAddressLine2", "tabpage[@controlname='tabPageCompanies']/container[@controlname='groupBox9']/?/?/text[@accessiblename='Add Line 2:']", "element", 30000, null, "49a26305-d674-4995-8ccd-341ed6f8f41d");
                _txtcityInfo = new RepoItemInfo(this, "TxtCity", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='textBoxCompaniesAddressCity']", "element", 30000, null, "d87c6fc7-70eb-4d03-b9fa-f153e34ced75");
                _txtzipInfo = new RepoItemInfo(this, "TxtZip", "tabpage[@controlname='tabPageCompanies']/?/?/text[@controlname='textBoxCompaniesAddressZip']", "element", 30000, null, "4ab49ece-250a-4c49-9613-d35e539e5a1e");
                _txtmainInfo = new RepoItemInfo(this, "TxtMain", "tabpage[@controlname='tabPageCompanies']/container[@controlname='groupBox8']/?/?/text[@accessiblename='Main:']", "element", 30000, null, "c0fe8e77-830f-4264-baa5-eab05b48b368");
                _txtotherInfo = new RepoItemInfo(this, "TxtOther", "tabpage[@controlname='tabPageCompanies']/container[@controlname='groupBox8']/?/?/text[@accessiblename='Other:']", "element", 30000, null, "202b68c9-d382-4b20-897b-bf688bb3e1b3");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6741e82e-ec3b-4d2f-8c4c-23dc101f2b01")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LabelAddLine1 item.
            /// </summary>
            [RepositoryItem("7b75f60f-32b6-4f20-9418-16e6c61b62d6")]
            public virtual Ranorex.Text LabelAddLine1
            {
                get
                {
                    return _labeladdline1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelAddLine1 item info.
            /// </summary>
            [RepositoryItemInfo("7b75f60f-32b6-4f20-9418-16e6c61b62d6")]
            public virtual RepoItemInfo LabelAddLine1Info
            {
                get
                {
                    return _labeladdline1Info;
                }
            }

            /// <summary>
            /// The LabelAddLine2 item.
            /// </summary>
            [RepositoryItem("7e363e15-abc4-4287-a46b-bcee1a06d4f1")]
            public virtual Ranorex.Text LabelAddLine2
            {
                get
                {
                    return _labeladdline2Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelAddLine2 item info.
            /// </summary>
            [RepositoryItemInfo("7e363e15-abc4-4287-a46b-bcee1a06d4f1")]
            public virtual RepoItemInfo LabelAddLine2Info
            {
                get
                {
                    return _labeladdline2Info;
                }
            }

            /// <summary>
            /// The LabelCity item.
            /// </summary>
            [RepositoryItem("779072db-e2e8-470f-adc0-5380f608e5a4")]
            public virtual Ranorex.Text LabelCity
            {
                get
                {
                    return _labelcityInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelCity item info.
            /// </summary>
            [RepositoryItemInfo("779072db-e2e8-470f-adc0-5380f608e5a4")]
            public virtual RepoItemInfo LabelCityInfo
            {
                get
                {
                    return _labelcityInfo;
                }
            }

            /// <summary>
            /// The LabelState item.
            /// </summary>
            [RepositoryItem("df73478f-20e8-4720-95cb-13764a4229e4")]
            public virtual Ranorex.Text LabelState
            {
                get
                {
                    return _labelstateInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelState item info.
            /// </summary>
            [RepositoryItemInfo("df73478f-20e8-4720-95cb-13764a4229e4")]
            public virtual RepoItemInfo LabelStateInfo
            {
                get
                {
                    return _labelstateInfo;
                }
            }

            /// <summary>
            /// The LabelZip item.
            /// </summary>
            [RepositoryItem("f5c6e247-fa1d-43ee-80d1-5712f26e316f")]
            public virtual Ranorex.Text LabelZip
            {
                get
                {
                    return _labelzipInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelZip item info.
            /// </summary>
            [RepositoryItemInfo("f5c6e247-fa1d-43ee-80d1-5712f26e316f")]
            public virtual RepoItemInfo LabelZipInfo
            {
                get
                {
                    return _labelzipInfo;
                }
            }

            /// <summary>
            /// The LabeMain item.
            /// </summary>
            [RepositoryItem("8337b98d-a2b2-4def-b286-35bcd8c48525")]
            public virtual Ranorex.Text LabeMain
            {
                get
                {
                    return _labemainInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabeMain item info.
            /// </summary>
            [RepositoryItemInfo("8337b98d-a2b2-4def-b286-35bcd8c48525")]
            public virtual RepoItemInfo LabeMainInfo
            {
                get
                {
                    return _labemainInfo;
                }
            }

            /// <summary>
            /// The LabelOther item.
            /// </summary>
            [RepositoryItem("5d4a6c93-4aae-4ed3-8730-9121950548a5")]
            public virtual Ranorex.Text LabelOther
            {
                get
                {
                    return _labelotherInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelOther item info.
            /// </summary>
            [RepositoryItemInfo("5d4a6c93-4aae-4ed3-8730-9121950548a5")]
            public virtual RepoItemInfo LabelOtherInfo
            {
                get
                {
                    return _labelotherInfo;
                }
            }

            /// <summary>
            /// The DropDownState item.
            /// </summary>
            [RepositoryItem("e65fc614-8bd2-4d04-9252-de0eb6329387")]
            public virtual Ranorex.ComboBox DropDownState
            {
                get
                {
                    return _dropdownstateInfo.CreateAdapter<Ranorex.ComboBox>(true);
                }
            }

            /// <summary>
            /// The DropDownState item info.
            /// </summary>
            [RepositoryItemInfo("e65fc614-8bd2-4d04-9252-de0eb6329387")]
            public virtual RepoItemInfo DropDownStateInfo
            {
                get
                {
                    return _dropdownstateInfo;
                }
            }

            /// <summary>
            /// The CommentBox item.
            /// </summary>
            [RepositoryItem("f6838123-bdd2-4b00-9eb6-cb045d61d0e3")]
            public virtual Ranorex.Text CommentBox
            {
                get
                {
                    return _commentboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The CommentBox item info.
            /// </summary>
            [RepositoryItemInfo("f6838123-bdd2-4b00-9eb6-cb045d61d0e3")]
            public virtual RepoItemInfo CommentBoxInfo
            {
                get
                {
                    return _commentboxInfo;
                }
            }

            /// <summary>
            /// The TxtAddressLine1 item.
            /// </summary>
            [RepositoryItem("b60ecbbf-17c2-4de7-933e-459db99e9516")]
            public virtual Ranorex.Text TxtAddressLine1
            {
                get
                {
                    return _txtaddressline1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtAddressLine1 item info.
            /// </summary>
            [RepositoryItemInfo("b60ecbbf-17c2-4de7-933e-459db99e9516")]
            public virtual RepoItemInfo TxtAddressLine1Info
            {
                get
                {
                    return _txtaddressline1Info;
                }
            }

            /// <summary>
            /// The TxtAddressLine2 item.
            /// </summary>
            [RepositoryItem("49a26305-d674-4995-8ccd-341ed6f8f41d")]
            public virtual Ranorex.Text TxtAddressLine2
            {
                get
                {
                    return _txtaddressline2Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtAddressLine2 item info.
            /// </summary>
            [RepositoryItemInfo("49a26305-d674-4995-8ccd-341ed6f8f41d")]
            public virtual RepoItemInfo TxtAddressLine2Info
            {
                get
                {
                    return _txtaddressline2Info;
                }
            }

            /// <summary>
            /// The TxtCity item.
            /// </summary>
            [RepositoryItem("d87c6fc7-70eb-4d03-b9fa-f153e34ced75")]
            public virtual Ranorex.Text TxtCity
            {
                get
                {
                    return _txtcityInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtCity item info.
            /// </summary>
            [RepositoryItemInfo("d87c6fc7-70eb-4d03-b9fa-f153e34ced75")]
            public virtual RepoItemInfo TxtCityInfo
            {
                get
                {
                    return _txtcityInfo;
                }
            }

            /// <summary>
            /// The TxtZip item.
            /// </summary>
            [RepositoryItem("4ab49ece-250a-4c49-9613-d35e539e5a1e")]
            public virtual Ranorex.Text TxtZip
            {
                get
                {
                    return _txtzipInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtZip item info.
            /// </summary>
            [RepositoryItemInfo("4ab49ece-250a-4c49-9613-d35e539e5a1e")]
            public virtual RepoItemInfo TxtZipInfo
            {
                get
                {
                    return _txtzipInfo;
                }
            }

            /// <summary>
            /// The TxtMain item.
            /// </summary>
            [RepositoryItem("c0fe8e77-830f-4264-baa5-eab05b48b368")]
            public virtual Ranorex.Text TxtMain
            {
                get
                {
                    return _txtmainInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtMain item info.
            /// </summary>
            [RepositoryItemInfo("c0fe8e77-830f-4264-baa5-eab05b48b368")]
            public virtual RepoItemInfo TxtMainInfo
            {
                get
                {
                    return _txtmainInfo;
                }
            }

            /// <summary>
            /// The TxtOther item.
            /// </summary>
            [RepositoryItem("202b68c9-d382-4b20-897b-bf688bb3e1b3")]
            public virtual Ranorex.Text TxtOther
            {
                get
                {
                    return _txtotherInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtOther item info.
            /// </summary>
            [RepositoryItemInfo("202b68c9-d382-4b20-897b-bf688bb3e1b3")]
            public virtual RepoItemInfo TxtOtherInfo
            {
                get
                {
                    return _txtotherInfo;
                }
            }
        }

        /// <summary>
        /// The NavigationFolder folder.
        /// </summary>
        [RepositoryFolder("3c3167bb-0bd8-4bbe-ab1d-1513efefc36e")]
        public partial class NavigationFolder : RepoGenBaseFolder
        {
            RepoItemInfo _companyInfo;

            /// <summary>
            /// Creates a new Navigation  folder.
            /// </summary>
            public NavigationFolder(RepoGenBaseFolder parentFolder) :
                    base("Navigation", "", parentFolder, 0, null, false, "3c3167bb-0bd8-4bbe-ab1d-1513efefc36e", "")
            {
                _companyInfo = new RepoItemInfo(this, "Company", "tabpage[@accessiblename='Company ']", "element", 30000, null, "c3394663-c50f-4003-8abf-2e349bdfca82");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3c3167bb-0bd8-4bbe-ab1d-1513efefc36e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Company item.
            /// </summary>
            [RepositoryItem("c3394663-c50f-4003-8abf-2e349bdfca82")]
            public virtual Ranorex.TabPage Company
            {
                get
                {
                    return _companyInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Company item info.
            /// </summary>
            [RepositoryItemInfo("c3394663-c50f-4003-8abf-2e349bdfca82")]
            public virtual RepoItemInfo CompanyInfo
            {
                get
                {
                    return _companyInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
