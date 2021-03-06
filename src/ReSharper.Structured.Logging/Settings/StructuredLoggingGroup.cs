﻿using JetBrains.ReSharper.Feature.Services.Daemon;

using ReSharper.Structured.Logging.Settings;

namespace ReSharper.Structured.Logging.Settings
{
    [RegisterConfigurableHighlightingsGroup(Id, Name)]
    public class StructuredLoggingGroup
    {
        public const string Id = "StructuredLogging";

        public const string Name = "Structured Logging Misuse";
    }
}
