using FileDados.Entidades;
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

        public ListPahtsItem(PathDados path)
        {
            InitializeComponent();
            LoadFields(path);
        }

        private void LoadFields(PathDados dados)
        {
            TXT_DestinationPath.Text = dados.destination_dir;
        }
    }
}
