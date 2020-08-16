using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.Modals;

namespace Yaqoot300.Commons
{
    public class MessagesService
    {
        public enum Severity
        {
            Error, Warning, Info
        }
        public class Item
        {
            public DateTime Time { get; set; }
            public Severity Severity { get; set; }
            public string Message { get; set; }
            public MessageCategory Category { get; set; }
        }

        private MessagesDialog _dlg;
        private bool _isOpen;
        private readonly List<Item> _messages = new List<Item>();

        public void ShowDialog()
        {
            _dlg = new MessagesDialog {Messages = _messages};
            _dlg.Cleared += DlgOnCleared;
            _isOpen = true;
            _dlg.ShowDialog();
            _isOpen = false;
        }

        private void DlgOnCleared(object sender, EventArgs eventArgs)
        {
            this._messages.Clear();
            InvalidateDlg();
        }

        public void Error(string message, MessageCategory category)
        {
            AddMessage(Severity.Error, message, category);
        }

        public void Warning(string message, MessageCategory category)
        {
            AddMessage(Severity.Warning, message, category);
        }

        public void Info(string message, MessageCategory category)
        {
            AddMessage(Severity.Info, message, category);
        }

        private void AddMessage(Severity severity, string message, MessageCategory category)
        {
            if (_messages.Count >= Constants.MESSAGES_MAX) _messages.RemoveAt(0);
            this._messages.Add(new Item
            {
                Time = DateTime.Now,
                Severity = severity,
                Message = message,
                Category = category
            });
            InvalidateDlg();
        }

        private void InvalidateDlg()
        {
            if (_isOpen)
            {
                _dlg.Messages = _messages;
                _dlg.InvalidateUI();
            }

        }


    }
}
