using MyCoin.Base;
using MyCoin.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoin
{
    public partial class MainGui : BaseScreen
    {
        public CreateWalletGui createWalletGui;
        public StartPageGui startPageGui;
        public MainGui()
        {
            InitializeComponent();

            InitBase();
        }

        public override void HideGui()
        {
            
        }

        public override void OnTouchEnded(object sender, EventArgs e)
        {
           

        }

        public override void ShowGui()
        {
            
        }

        private void ShowCreateWalletGui()
        {
            if (this.createWalletGui == null)
            {
                this.createWalletGui = new CreateWalletGui();
            }
            this.createWalletGui.ShowDialog(this);
        }
    }
}
