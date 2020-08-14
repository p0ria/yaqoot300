using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Modals;

namespace Yaqoot300.Commons
{
    public class CheckingsService
    {
        private bool _isBusy;

        public Task<bool?> CanStart()
        {
            if (_isBusy) return Task.FromResult<bool?>(null);
            return Task.Run<bool?>(() =>
            {
                var dlg = new CheckingsDialog();
                var result = dlg.ShowDialog();
                _isBusy = false;
                return result == DialogResult.OK;
            });
        }
    }
}