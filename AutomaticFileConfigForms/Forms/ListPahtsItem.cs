using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticFileConfigForms.Forms
{
    public partial class ListPahtsItem : UserControl
    {
        public ListPahtsItem()
        {
            InitializeComponent();
        }


        private string _text;
        public string  Text
        {
            get { return _text; }
            set { _text = value; label1.Text = value; }
        }

    }
}
