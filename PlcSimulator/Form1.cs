using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlcSimulator.Common;
using Shared.Common;
using SimpleTcp;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace PlcSimulator
{
    public partial class MainForm : Form
    {
        private readonly ClientConnection _client;
        public MainForm()
        {
            InitializeComponent();
            cbSignalIds.ValueMember = "Name";
            _client = new ClientConnection();
            _client.ConnectChanged += ClientOnConnectChanged;
            FillSignalIds();
            Logs.LogsListBox = lbLogs;
            SignalLogs.SignalsListBox = lbSignals;
            this.Closed += OnClosed;
            this.tabControl1.SelectedIndex = 1;
            var config = Config.FromFile ?? Config.Default;
            tbIp.Text = config.Server.Ip;
            tbPort.Text = config.Server.Port.ToString();
        }

        private void ClientOnConnectChanged(object sender, bool isConnected)
        {
            btnConnect.Text = isConnected ? "Disconnect From Server" : "Connect To Server";
            tbIp.Enabled = !isConnected;
            tbPort.Enabled = !isConnected;
            btnSend.Enabled = isConnected;
        }

        private void OnClosed(object sender, EventArgs eventArgs)
        {
            _client.Dispose();
        }

        private void FillSignalIds()
        {
            this.cbSignalIds.Items.AddRange(SignalUtils.PlcSignals.ToArray());
            this.cbSignalIds.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            btnConnect.Enabled = false;
            if (_client.IsConnected)
            {
                _client.Disconnect();
            }
            else
            {
                _client.Connect(tbIp.Text, int.Parse(tbPort.Text));
            } 
            btnConnect.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var selectedSignal = cbSignalIds.SelectedItem as Signal;
            var data = selectedSignal.value.Length <= 1 ? Shared.Common.Utils.HexStringToByteArray(tbSignalData.Text) : new byte[]{};
            _client.Send(selectedSignal.value, data);
        }

        private void cbSignalIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSignal = cbSignalIds.SelectedItem as Signal;
            tbSignalData.Enabled = selectedSignal.value.Length <= 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbSignals.Items.Clear();
        }
    }
}
