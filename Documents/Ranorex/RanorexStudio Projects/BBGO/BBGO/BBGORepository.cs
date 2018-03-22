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
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class BBGORepositoryFolders
    {
    }
#pragma warning restore 0436
}