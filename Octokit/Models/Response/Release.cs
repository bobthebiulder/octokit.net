using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Release
    {
        public Release()
        {
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
        public Release(string uploadUrl)
        {
            UploadUrl = uploadUrl;
        }

        public string Url { get; protected set; }

        public string HtmlUrl { get; protected set; }

        public string AssetsUrl { get; protected set; }

        public string UploadUrl { get; protected set; }

        public int Id { get; protected set; }

        public string TagName { get; protected set; }

        public string TargetCommitish { get; protected set; }

        public string Name { get; protected set; }

        public string Body { get; protected set; }

        public bool Draft { get; protected set; }

        public bool Prerelease { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset? PublishedAt { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Name: {0} PublishedAt: {1}", Name, PublishedAt); }
        }

        public ReleaseUpdate ToUpdate()
        {
            return new ReleaseUpdate
            {
                Body = Body,
                Draft = Draft,
                Name = Name,
                Prerelease = Prerelease,
                TargetCommitish = TargetCommitish,
                TagName = TagName
            };
        }
    }
}
