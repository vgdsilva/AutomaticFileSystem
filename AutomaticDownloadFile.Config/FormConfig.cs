using AutomaticDownloadFile.Config.Configuracoes;
using AutomaticDownloadFile.Config.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticDownloadFile.Config
{
    public partial class FormConfig : Form
    {
        ConfiguracoesEntitie ConfiguracoesEntitie { get; set; }

        public FormConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Utilities.FolderDialog();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            ConfiguracoesEntitie = new ConfiguracoesBO().GetDadosConfiguracao();
            SetCamposForm();
        }


        private void SetCamposForm()
        {
            textBox1.Text = ConfiguracoesEntitie.Source;
        }
    }

    


}
