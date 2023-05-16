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

namespace R_jk1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the R_jk1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("18e830b5-44bc-44d8-8e6b-50d124786b46")]
    public partial class R_jk1Repository : RepoGenBaseFolder
    {
        static R_jk1Repository instance = new R_jk1Repository();
        R_jk1RepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        R_jk1RepositoryFolders.DESKTOP2U76B3EAppFolder _desktop2u76b3e;

        /// <summary>
        /// Gets the singleton class instance representing the R_jk1Repository element repository.
        /// </summary>
        [RepositoryFolder("18e830b5-44bc-44d8-8e6b-50d124786b46")]
        public static R_jk1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public R_jk1Repository() 
            : base("R_jk1Repository", "/", null, 0, false, "18e830b5-44bc-44d8-8e6b-50d124786b46", ".\\RepositoryImages\\R_jk1Repository18e830b5.rximgres")
        {
            _rxmainframe = new R_jk1RepositoryFolders.RxMainFrameAppFolder(this);
            _desktop2u76b3e = new R_jk1RepositoryFolders.DESKTOP2U76B3EAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("18e830b5-44bc-44d8-8e6b-50d124786b46")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("bf19aeee-7192-41a8-8fab-9e5f042ad97a")]
        public virtual R_jk1RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }

        /// <summary>
        /// The DESKTOP2U76B3E folder.
        /// </summary>
        [RepositoryFolder("ee3be217-061c-444d-b938-b9385d50b751")]
        public virtual R_jk1RepositoryFolders.DESKTOP2U76B3EAppFolder DESKTOP2U76B3E
        {
            get { return _desktop2u76b3e; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class R_jk1RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("bf19aeee-7192-41a8-8fab-9e5f042ad97a")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@automationid='RxMainFrame']", parentFolder, 30000, null, true, "bf19aeee-7192-41a8-8fab-9e5f042ad97a", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@automationid='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "631e694e-5508-477e-8849-36682db600a8");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@automationid='RxTabIntroduction']/button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "7210bfae-d886-4cf4-b3a2-7d854f41581e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bf19aeee-7192-41a8-8fab-9e5f042ad97a")]
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
            [RepositoryItemInfo("bf19aeee-7192-41a8-8fab-9e5f042ad97a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("631e694e-5508-477e-8849-36682db600a8")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("631e694e-5508-477e-8849-36682db600a8")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("7210bfae-d886-4cf4-b3a2-7d854f41581e")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("7210bfae-d886-4cf4-b3a2-7d854f41581e")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

        /// <summary>
        /// The DESKTOP2U76B3EAppFolder folder.
        /// </summary>
        [RepositoryFolder("ee3be217-061c-444d-b938-b9385d50b751")]
        public partial class DESKTOP2U76B3EAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _desktop2u76b3eInfo;

            /// <summary>
            /// Creates a new DESKTOP2U76B3E  folder.
            /// </summary>
            public DESKTOP2U76B3EAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DESKTOP2U76B3E", "", parentFolder, 30000, null, true, "ee3be217-061c-444d-b938-b9385d50b751", "")
            {
                _desktop2u76b3eInfo = new RepoItemInfo(this, "DESKTOP2U76B3E", "", "", 30000, null, "df8eaaff-62e9-4609-bf9d-bef66742f0cd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ee3be217-061c-444d-b938-b9385d50b751")]
            public virtual Ranorex.Host Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ee3be217-061c-444d-b938-b9385d50b751")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DESKTOP2U76B3E item.
            /// </summary>
            [RepositoryItem("df8eaaff-62e9-4609-bf9d-bef66742f0cd")]
            public virtual Ranorex.Host DESKTOP2U76B3E
            {
                get
                {
                    return _desktop2u76b3eInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The DESKTOP2U76B3E item info.
            /// </summary>
            [RepositoryItemInfo("df8eaaff-62e9-4609-bf9d-bef66742f0cd")]
            public virtual RepoItemInfo DESKTOP2U76B3EInfo
            {
                get
                {
                    return _desktop2u76b3eInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
