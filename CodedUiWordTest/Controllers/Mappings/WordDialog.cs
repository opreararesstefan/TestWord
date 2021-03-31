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

namespace CodedUiWordTest.Controllers.Mappings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WordDialog element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1803ad4e-d4bc-4d4d-97f2-a3dafe476ebd")]
    public partial class WordDialog : RepoGenBaseFolder
    {
        static WordDialog instance = new WordDialog();
        WordDialogFolders.WordProccesAppFolder _wordprocces;
        RepoItemInfo _ersteschritcloseInfo;
        RepoItemInfo _offnenInfo;
        RepoItemInfo _durchsuchenInfo;
        RepoItemInfo _startseiteInfo;
        RepoItemInfo _wordcloseInfo;
        RepoItemInfo _schliessenInfo;

        /// <summary>
        /// Gets the singleton class instance representing the WordDialog element repository.
        /// </summary>
        [RepositoryFolder("1803ad4e-d4bc-4d4d-97f2-a3dafe476ebd")]
        public static WordDialog Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WordDialog() 
            : base("WordDialog", "/", null, 0, false, "1803ad4e-d4bc-4d4d-97f2-a3dafe476ebd", ".\\RepositoryImages\\WordDialog1803ad4e.rximgres")
        {
            _wordprocces = new WordDialogFolders.WordProccesAppFolder(this);
            _ersteschritcloseInfo = new RepoItemInfo(this, "ErsteSchritClose", "/form[@title>'Erste Schritte mit Microsoft']/titlebar/button[@automationid='Close']", 30000, null, "1d1f4232-2525-4df2-ad0f-3b0fb12b63d5");
            _offnenInfo = new RepoItemInfo(this, "Offnen", "/form[@title>'Word (Nicht lizenziertes']/element[@class='FullpageUIHost']/container[@class='NetUIHWND']/container[1]/list[@automationid='NavBarMenu']/listitem[@name='Öffnen']", 30000, null, "bf8a3810-8d2f-462c-8ce8-8c4d55a8d991");
            _durchsuchenInfo = new RepoItemInfo(this, "Durchsuchen", "/form[@title>'Word (Nicht lizenziertes']//container[@automationid='BackstageView']/container[@name='Öffnen']/container[@name='Öffnen']/?/?/contextmenu[@name='Öffnen']/?/?/button[@name='Durchsuchen']", 30000, null, "1ca1d9dd-8ba6-48c1-8e1a-0be7cd90b8b3");
            _startseiteInfo = new RepoItemInfo(this, "Startseite", "/form[@title>'Word (Nicht lizenziertes']/element[@class='FullpageUIHost']/container[@class='NetUIHWND']/container[1]/list[@automationid='NavBarMenu']/listitem[@name='Startseite']", 30000, null, "617df558-e830-46ee-a736-33e24eeb7546");
            _wordcloseInfo = new RepoItemInfo(this, "WordClose", "/form[@title>'CV.docx']/element[@class='FullpageUIHost']/container/button[@name='Schließen']", 30000, null, "2bcaf7af-f10a-4054-a952-2b8a516ffcda");
            _schliessenInfo = new RepoItemInfo(this, "Schliessen", "/form[@title>'CV.docx - Word (Nicht lizenziertes']/container[@caption='MsoDockTop']/container[@caption='Ribbon']/element/element/container/container[@name='Ribbon']/button[@name='Schließen']", 30000, null, "223e1de9-404f-4f32-b4c9-0df83d1c7dcb");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1803ad4e-d4bc-4d4d-97f2-a3dafe476ebd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ErsteSchritClose item.
        /// </summary>
        [RepositoryItem("1d1f4232-2525-4df2-ad0f-3b0fb12b63d5")]
        public virtual Ranorex.Button ErsteSchritClose
        {
            get
            {
                 return _ersteschritcloseInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The ErsteSchritClose item info.
        /// </summary>
        [RepositoryItemInfo("1d1f4232-2525-4df2-ad0f-3b0fb12b63d5")]
        public virtual RepoItemInfo ErsteSchritCloseInfo
        {
            get
            {
                return _ersteschritcloseInfo;
            }
        }

        /// <summary>
        /// The Offnen item.
        /// </summary>
        [RepositoryItem("bf8a3810-8d2f-462c-8ce8-8c4d55a8d991")]
        public virtual Ranorex.ListItem Offnen
        {
            get
            {
                 return _offnenInfo.CreateAdapter<Ranorex.ListItem>(true);
            }
        }

        /// <summary>
        /// The Offnen item info.
        /// </summary>
        [RepositoryItemInfo("bf8a3810-8d2f-462c-8ce8-8c4d55a8d991")]
        public virtual RepoItemInfo OffnenInfo
        {
            get
            {
                return _offnenInfo;
            }
        }

        /// <summary>
        /// The Durchsuchen item.
        /// </summary>
        [RepositoryItem("1ca1d9dd-8ba6-48c1-8e1a-0be7cd90b8b3")]
        public virtual Ranorex.Button Durchsuchen
        {
            get
            {
                 return _durchsuchenInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The Durchsuchen item info.
        /// </summary>
        [RepositoryItemInfo("1ca1d9dd-8ba6-48c1-8e1a-0be7cd90b8b3")]
        public virtual RepoItemInfo DurchsuchenInfo
        {
            get
            {
                return _durchsuchenInfo;
            }
        }

        /// <summary>
        /// The Startseite item.
        /// </summary>
        [RepositoryItem("617df558-e830-46ee-a736-33e24eeb7546")]
        public virtual Ranorex.ListItem Startseite
        {
            get
            {
                 return _startseiteInfo.CreateAdapter<Ranorex.ListItem>(true);
            }
        }

        /// <summary>
        /// The Startseite item info.
        /// </summary>
        [RepositoryItemInfo("617df558-e830-46ee-a736-33e24eeb7546")]
        public virtual RepoItemInfo StartseiteInfo
        {
            get
            {
                return _startseiteInfo;
            }
        }

        /// <summary>
        /// The WordClose item.
        /// </summary>
        [RepositoryItem("2bcaf7af-f10a-4054-a952-2b8a516ffcda")]
        public virtual Ranorex.Button WordClose
        {
            get
            {
                 return _wordcloseInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The WordClose item info.
        /// </summary>
        [RepositoryItemInfo("2bcaf7af-f10a-4054-a952-2b8a516ffcda")]
        public virtual RepoItemInfo WordCloseInfo
        {
            get
            {
                return _wordcloseInfo;
            }
        }

        /// <summary>
        /// The Schliessen item.
        /// </summary>
        [RepositoryItem("223e1de9-404f-4f32-b4c9-0df83d1c7dcb")]
        public virtual Ranorex.Button Schliessen
        {
            get
            {
                 return _schliessenInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The Schliessen item info.
        /// </summary>
        [RepositoryItemInfo("223e1de9-404f-4f32-b4c9-0df83d1c7dcb")]
        public virtual RepoItemInfo SchliessenInfo
        {
            get
            {
                return _schliessenInfo;
            }
        }

        /// <summary>
        /// The WordProcces folder.
        /// </summary>
        [RepositoryFolder("0954f7e7-8e6a-47ab-bde1-060a414d8375")]
        public virtual WordDialogFolders.WordProccesAppFolder WordProcces
        {
            get { return _wordprocces; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class WordDialogFolders
    {
        /// <summary>
        /// The WordProccesAppFolder folder.
        /// </summary>
        [RepositoryFolder("0954f7e7-8e6a-47ab-bde1-060a414d8375")]
        public partial class WordProccesAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new WordProcces  folder.
            /// </summary>
            public WordProccesAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WordProcces", "/form[@title>'Word (Nicht lizenziertes']", parentFolder, 30000, null, true, "0954f7e7-8e6a-47ab-bde1-060a414d8375", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0954f7e7-8e6a-47ab-bde1-060a414d8375")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0954f7e7-8e6a-47ab-bde1-060a414d8375")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}