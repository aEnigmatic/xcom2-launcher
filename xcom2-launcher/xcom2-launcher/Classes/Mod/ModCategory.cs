﻿using System.Collections.Generic;

namespace XCOM2Launcher.Mod
{
    public class ModCategory
    {
        public int Index { get; set; } = -1;

        public bool Collapsed { get; set; } = false;

        public List<ModEntry> Entries { get; set; } = new List<ModEntry>();
    }
}