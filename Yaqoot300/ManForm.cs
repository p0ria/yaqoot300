using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Controls;
using Yaqoot300.Interfaces;
using Yaqoot300.Pages;
using Yaqoot300.State;
using Yaqoot300.State.App.Actions;

namespace Yaqoot300
{
    public partial class MainForm : Form
    {
        private readonly HomePage _homePage;
        private readonly ServicePage _servicePage;
        private Mode? _currentPage;
        public MainForm()
        {
            InitializeComponent();
            ServiceProvider.ImageList32 = this.imageList32;
            ServiceProvider.ImageList64 = this.imageList64;
            _homePage = new HomePage();
            _servicePage = new ServicePage();
            ServiceProvider.Store.StoreChanged += OnStoreChanged;
            ServiceProvider.Store.RaiseStoreChangedEvent();
        }

        private Store Store => ServiceProvider.Store;

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                case AppActionTypes.CHANGE_MODE:
                    changePage(Store.App.SelectedMode);
                    break;

            }
        }

        private void changePage(Mode newPage)
        {
            switch (newPage)
            {
                case Mode.Auto:
                case Mode.Manual:
                    if (_currentPage == null || _currentPage == Mode.Service)
                    {
                        this.Controls.Clear();
                        this.Controls.Add(_homePage);
                    }
                    break;

                case Mode.Service:
                    if (_currentPage != Mode.Service)
                    {
                        this.Controls.Clear();
                        this.Controls.Add(_servicePage);
                    }
                    break;
            }
            _currentPage = newPage;
        }

    }
}
