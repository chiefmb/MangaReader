﻿// -----------------------------------------------------------------------
// <copyright file="MainOptions.cs" company="GihanSoft">
// Copyright (c) 2021 GihanSoft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace MangaReader.Options
{
    public partial class MainOptions
    {
        public const string Key = "C2620BE2-F092-4807-B867-3DD8426E9F45";

        public Appearance Appearance { get; set; } = new Appearance();

        public string? MangaRootFolder { get; set; }
        public string? Version { get; set; }
    }
}