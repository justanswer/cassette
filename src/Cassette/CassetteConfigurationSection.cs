﻿using System.Configuration;

namespace Cassette
{
    public sealed class CassetteConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("debug", DefaultValue = null)]
        public bool? Debug
        {
            get { return (bool?)this["debug"]; }
            set { this["debug"] = value; }
        }

        [ConfigurationProperty("rewriteHtml", DefaultValue = true)]
        public bool RewriteHtml
        {
            get { return (bool)this["rewriteHtml"]; }
            set { this["rewriteHtml"] = value; }
        }

        [ConfigurationProperty("allowRemoteDiagnostics", DefaultValue = false)]
        public bool AllowRemoteDiagnostics
        {
            get { return (bool)this["allowRemoteDiagnostics"]; }
            set { this["allowRemoteDiagnostics"] = value; }
        }

        [ConfigurationProperty("cacheDirectory", DefaultValue = null)]
        public string CacheDirectory
        {
            get { return (string)this["cacheDirectory"]; }
            set { this["cacheDirectory"] = value; }
        }

        [ConfigurationProperty("performCompression", DefaultValue = true)]
        public bool? PerformCompression
        {
            get { return (bool)this["performCompression"]; }
            set { this["performCompression"] = value; }
        }

        [ConfigurationProperty("disableFileWatcher", DefaultValue = false)]
        public bool DisableFileWatcher
        {
            get { return (bool) this["disableFileWatcher"]; }
            set { this["disableFileWatcher"] = value; }
        }

        [ConfigurationProperty("disableHashCheck", DefaultValue = false)]
        public bool DisableHashCheck
        {
            get { return (bool) this["disableHashCheck"]; }
            set { this["disableHashCheck"] = value; }
        }
    }
}