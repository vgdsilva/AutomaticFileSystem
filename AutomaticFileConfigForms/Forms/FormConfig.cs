using AutomaticFileConfigForms.Utils;
using FileDados.Entidades;
using FileDados.Regras;
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
    public partial class FormConfig : Form
    {
        
        List<PathDados> listPahts;
        DadosBO DadosBO;

        public FormConfig()
        {
            InitializeComponent();
            listPahts = new List<PathDados>();
            DadosBO = new DadosBO();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            DadosBO.VerificaSeExisteArquivoDeConfiguracao();
            LoadConfuration();
            LoadDestinationItens();
        }

        private void LoadConfuration()
        {
            Dados configuration = new DadosBO().GetDadosFromConfiguration();
            if (!string.IsNullOrEmpty(configuration.source_dir))
                TXT_SourceFolder.Text = configuration.source_dir;

            if (configuration.PathDados.Count > 0)
                listPahts = configuration.PathDados;
        }

        private void LoadDestinationItens()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (PathDados path in listPahts)
            {
                ListPahtsItem item = new ListPahtsItem(path);
                item.Tag = path;
                item.DoubleClick += Item_DoubleClick;
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void Item_DoubleClick(object? sender, EventArgs e)
        {
            PathDados dados = (sender as ListPahtsItem).Tag as PathDados;
            FormAddPath FormAddPath = new FormAddPath(dados);
            FormAddPath.ShowDialog();
        }

        private void BTN_ChangeSourceFolder_Click(object sender, EventArgs e)
        {
            TXT_SourceFolder.Text = DropUtils.FolderDialog(TXT_SourceFolder.Text);
        }

        private void BTN_AddPaths_Click(object sender, EventArgs e)
        {
            FormAddPath FormAddPath = new FormAddPath(null);
            FormAddPath.ShowDialog();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e) { Dispose(); }

        private void BTN_Ok_Click(object sender, EventArgs e) { Dispose(); }

        private void BTN_Apply_Click(object sender, EventArgs e) { Dispose(); }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
