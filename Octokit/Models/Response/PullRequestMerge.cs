﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestMerge
    {
        /// <summary>
        /// The sha reference of the commit.
        /// </summary>
        public string Sha { get; protected set; }

        /// <summary>
        /// True if merged successfully, otherwise false.
        /// </summary>
        public bool Merged { get; protected set; }

        /// <summary>
        /// The message that will be used for the merge commit.
        /// </summary>
        public string Message { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Sha: {0} Message: {1}", Sha, Message);
            }
        }
    }
}
