using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoin.Base
{
    public abstract class BaseScreen : Form
    {
        protected BaseScreen(): base() { }
        protected void InitBase()
        {
            this.Controls.OfType<Button>().ToList().ForEach((control) =>
            {
                control.Click += new System.EventHandler(this.OnTouchEnded);
            });
        }

        public virtual void OnTouchEnded(object sender, EventArgs e) { }

        public abstract void ShowGui();

        public abstract void HideGui();
    }
}
