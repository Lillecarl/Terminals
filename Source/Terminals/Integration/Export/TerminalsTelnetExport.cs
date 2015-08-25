﻿using System.Xml;
using Terminals.Connections;

namespace Terminals.Integration.Export
{
    internal class TerminalsTelnetExport
    {
        public static void ExportTelnetOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.Protocol == ConnectionManager.TELNET)
            {
                TerminalsConsoleExport.ExportConsoleOptions(w, favorite);

                w.WriteElementString("telnet", favorite.Telnet.ToString());
                w.WriteElementString("telnetRows", favorite.TelnetRows.ToString());
                w.WriteElementString("telnetCols", favorite.TelnetCols.ToString());
                w.WriteElementString("telnetFont", favorite.TelnetFont);
                w.WriteElementString("telnetBackColor", favorite.TelnetBackColor);
                w.WriteElementString("telnetTextColor", favorite.TelnetTextColor);
                w.WriteElementString("telnetCursorColor", favorite.TelnetCursorColor);
            }
        }
    }
}