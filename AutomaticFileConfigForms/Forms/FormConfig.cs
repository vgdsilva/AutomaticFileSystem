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
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            popularItens();
        }

        private void popularItens()
        {
            ListPahtsItem[] itens = new ListPahtsItem[20];

            for (int i = 0; i < itens.Length; i++)
            {
                itens[i] = new ListPahtsItem();
                itens[i].Text = "Teste";

                listView1.Controls.Add(itens[i]);
            }
        }
    }
}
