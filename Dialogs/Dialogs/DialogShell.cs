using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class DialogShell : Control
    {
        public DialogShell()
        {
            this.DefaultStyleKeyProperty.OverrideMetadata(typeof(DialogShell), new FrameworkPropertyMetadata(typeof(DialogShell)));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
