using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Properties;
using Yaqoot300.State;
using Yaqoot300.State.App.Actions;

namespace Yaqoot300.Controls
{
    public partial class ConnectionsControl : UserControl
    {
        public ConnectionsControl()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                case AppActionTypes.CONENCTIONS_CHANGED:
                    SetConnections();
                    break;
            }
        }

        private void SetConnections()
        {
            SetImage(pbConnectionServer, Store.App.Connections.ServerConnection);
            SetImage(pbConnectionDb, Store.App.Connections.DbConnection);
            SetImage(pbConnectionPLC, Store.App.Connections.PLCConnection);
            SetImage(pbConnectionClient1, Store.App.Connections.ThinClient1Connection);
            SetImage(pbConnectionClient2, Store.App.Connections.ThinClient2Connection);
            SetImage(pbConnectionClient3, Store.App.Connections.ThinClient3Connection);
        }

        private void SetImage(PictureBox pb, ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Connected:
                    this.SafeInvoke(() => pb.Image = Resources.circle_tick_32x32);
                    break;
                case ConnectionStatus.Disconnected:
                    this.SafeInvoke(() => pb.Image = Resources.circle_cross_32x32);
                    break;
                case ConnectionStatus.Connecting:
                    this.SafeInvoke(() => pb.Image = Resources.loading_32x32);
                    break;
            }
        }

        private Store Store => Services.Store;
    }
}
