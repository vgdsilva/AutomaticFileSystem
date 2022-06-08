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
    public partial class FormAddPath : Form
    {
        PathDados dados;
        public FormAddPath(PathDados pathDados)
        {
            InitializeComponent();
            dados = pathDados != null ? pathDados : new PathDados();
        }

        private void FormAddPath_Load(object sender, EventArgs e)
        {
            TXT_DestinationFolder.Text = dados.destination_dir;
        }
    }
}
