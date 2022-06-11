using AutomaticFileConfigForms.Forms.UsersControl;
using FileDados.Entidades;
using FileDados.Enuns;
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


            if (dados.TipeFileSource == TipeCheckBox.Extensoes)
            {
                PathExtension pathExtension = new PathExtension();
                panel1.Controls.Clear();
                panel1.Controls.Add(pathExtension);
            }
            else
            {
                PathContainsName pathContainsName = new PathContainsName();
                panel1.Controls.Clear();
                panel1.Controls.Add(pathContainsName);
            }
        }

        private void BTN_ChangeDestFolder_Click(object sender, EventArgs e)
        {
            TXT_DestinationFolder.Text = Utils.DropUtils.FolderDialog(TXT_DestinationFolder.Text);
        }

        private void CBOX_Extension_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_ContainName.Checked)
            {
                CBOX_ContainName.Checked = false;
                CBOX_Extension.Checked = true;
            }

            dados.TipeFileSource = TipeCheckBox.Extensoes;
            ChangeCheckedTipeInput(dados.TipeFileSource);
        }

        private void CBOX_ContainName_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_Extension.Checked)
            {
                CBOX_Extension.Checked = false;
                CBOX_ContainName.Checked = true;
            }

            dados.TipeFileSource = TipeCheckBox.ContainName;
            ChangeCheckedTipeInput(dados.TipeFileSource);
        }

        private void ChangeCheckedTipeInput(TipeCheckBox tipeCheck)
        {
            if (tipeCheck == TipeCheckBox.Extensoes)
            {
                PathExtension pathExtension = new PathExtension();
                panel1.Controls.Clear();
                panel1.Controls.Add(pathExtension);
            }
            else
            {
                PathContainsName pathContainsName = new PathContainsName();
                panel1.Controls.Clear();
                panel1.Controls.Add(pathContainsName);
            }
        }

        

        
    }
}
