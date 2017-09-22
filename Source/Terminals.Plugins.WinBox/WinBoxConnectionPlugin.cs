using System;
using System.Drawing;
using System.Windows.Forms;
using Terminals.Common.Connections;
using Terminals.Data;
using Terminals.Forms.EditFavorite;
using Terminals.Integration.Export;

namespace Terminals.Connections.WinBox
{
    internal class WinBoxConnectionPlugin : IConnectionPlugin, IOptionsConverterFactory
    {
        internal const int WinBox_Port = 8291;

        internal const string WinBox = "WinBox";

        public int Port { get { return WinBox_Port; } }

        public string PortName { get { return WinBox; } }

        public Connection CreateConnection()
        {
            return new WinBoxConnection();
        }

        public Control[] CreateOptionsControls()
        {
            return new Control[0];
        }

        public Type GetOptionsType()
        {
            return typeof(WinBoxOptions);
        }

        public ProtocolOptions CreateOptions()
        {
            return new WinBoxOptions();
        }

        public Image GetIcon()
        {
            return Connection.Terminalsicon;
        }

        public IOptionsConverter CreatOptionsConverter()
        {
            return new WinBoxOptionsConverter();
        }
    }
}
