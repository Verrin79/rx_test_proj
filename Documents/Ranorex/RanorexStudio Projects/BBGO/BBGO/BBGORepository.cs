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

namespace BBGO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the BBGORepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("2cdc25d9-57c3-44aa-825e-964c74a33e48")]
    public partial class BBGORepository : RepoGenBaseFolder
    {
        static BBGORepository instance = new BBGORepository();
        BBGORepositoryFolders.StartAppFolder _start;
        BBGORepositoryFolders.BankenFoerHelaDinEkonomiNordeaSeAppFolder _bankenfoerheladinekonominordease;

        /// <summary>
        /// Gets the singleton class instance representing the BBGORepository element repository.
        /// </summary>
        [RepositoryFolder("2cdc25d9-57c3-44aa-825e-964c74a33e48")]
        public static BBGORepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public BBGORepository() 
            : base("BBGORepository", "/", null, 0, false, "2cdc25d9-57c3-44aa-825e-964c74a33e48", ".\\RepositoryImages\\BBGORepository2cdc25d9.rximgres")
        {
            _start = new BBGORepositoryFolders.StartAppFolder(this);
            _bankenfoerheladinekonominordease = new BBGORepositoryFolders.BankenFoerHelaDinEkonomiNordeaSeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2cdc25d9-57c3-44aa-825e-964c74a33e48")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Start folder.
        /// </summary>
        [RepositoryFolder("52d7c480-16a5-4d06-a554-65c39a0528a8")]
        public virtual BBGORepositoryFolders.StartAppFolder Start
        {
            get { return _start; }
        }

        /// <summary>
        /// The BankenFoerHelaDinEkonomiNordeaSe folder.
        /// </summary>
        [RepositoryFolder("8be1b3ca-f912-4648-bf23-7387aa22eaba")]
        public virtual BBGORepositoryFolders.BankenFoerHelaDinEkonomiNordeaSeAppFolder BankenFoerHelaDinEkonomiNordeaSe
        {
            get { return _bankenfoerheladinekonominordease; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class BBGORepositoryFolders
    {
        /// <summary>
        /// The StartAppFolder folder.
        /// </summary>
        [RepositoryFolder("52d7c480-16a5-4d06-a554-65c39a0528a8")]
        public partial class StartAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _tilepkingcomcandycrushsodasagakgqvnInfo;

            /// <summary>
            /// Creates a new Start  folder.
            /// </summary>
            public StartAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Start", "/winapp[@appid='App' and @name='Start']", parentFolder, 30000, null, true, "52d7c480-16a5-4d06-a554-65c39a0528a8", "")
            {
                _tilepkingcomcandycrushsodasagakgqvnInfo = new RepoItemInfo(this, "TilePKingComCandyCrushSodaSagaKgqvn", ".//container[@automationid='{2bbc7557-94ae-4dc2-9265-dfac98148b8c}']/listitem[@automationid='tile-P~king.com.CandyCrushSodaSaga_kgqvnymyfvs32!App']", 30000, null, "6929f489-8425-48c0-9a3b-32b946fda761");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("52d7c480-16a5-4d06-a554-65c39a0528a8")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("52d7c480-16a5-4d06-a554-65c39a0528a8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TilePKingComCandyCrushSodaSagaKgqvn item.
            /// </summary>
            [RepositoryItem("6929f489-8425-48c0-9a3b-32b946fda761")]
            public virtual Ranorex.ListItem TilePKingComCandyCrushSodaSagaKgqvn
            {
                get
                {
                    return _tilepkingcomcandycrushsodasagakgqvnInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The TilePKingComCandyCrushSodaSagaKgqvn item info.
            /// </summary>
            [RepositoryItemInfo("6929f489-8425-48c0-9a3b-32b946fda761")]
            public virtual RepoItemInfo TilePKingComCandyCrushSodaSagaKgqvnInfo
            {
                get
                {
                    return _tilepkingcomcandycrushsodasagakgqvnInfo;
                }
            }
        }

        /// <summary>
        /// The BankenFoerHelaDinEkonomiNordeaSeAppFolder folder.
        /// </summary>
        [RepositoryFolder("8be1b3ca-f912-4648-bf23-7387aa22eaba")]
        public partial class BankenFoerHelaDinEkonomiNordeaSeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _element1351658240Info;

            /// <summary>
            /// Creates a new BankenFoerHelaDinEkonomiNordeaSe  folder.
            /// </summary>
            public BankenFoerHelaDinEkonomiNordeaSeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("BankenFoerHelaDinEkonomiNordeaSe", "/form[@title~'^Banken\\ för\\ hela\\ din\\ ekono']", parentFolder, 30000, null, true, "8be1b3ca-f912-4648-bf23-7387aa22eaba", "")
            {
                _element1351658240Info = new RepoItemInfo(this, "Element1351658240", "element[@controlid='-1351658240']", 30000, null, "183db084-9c14-4bcb-8f18-38b07b50c57b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8be1b3ca-f912-4648-bf23-7387aa22eaba")]
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
            [RepositoryItemInfo("8be1b3ca-f912-4648-bf23-7387aa22eaba")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Element1351658240 item.
            /// </summary>
            [RepositoryItem("183db084-9c14-4bcb-8f18-38b07b50c57b")]
            public virtual Ranorex.Unknown Element1351658240
            {
                get
                {
                    return _element1351658240Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element1351658240 item info.
            /// </summary>
            [RepositoryItemInfo("183db084-9c14-4bcb-8f18-38b07b50c57b")]
            public virtual RepoItemInfo Element1351658240Info
            {
                get
                {
                    return _element1351658240Info;
                }
            }
        }

    }
#pragma warning restore 0436
}