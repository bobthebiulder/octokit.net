﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RepositoryPermissions
    {
        /// <summary>
        /// Whether the current user has administrative permissions
        /// </summary>
        public bool Admin { get; protected set; }

        /// <summary>
        /// Whether the current user has push permissions
        /// </summary>
        public bool Push { get; protected set; }

        /// <summary>
        /// Whether the current user has pull permissions
        /// </summary>
        public bool Pull { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Admin: {0}, Push: {1}, Pull: {2}", Admin, Push, Pull); }
        }
    }
}
