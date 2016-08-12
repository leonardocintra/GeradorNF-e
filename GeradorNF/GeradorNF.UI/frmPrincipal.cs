﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNF.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void emitenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmitente frm = new frmEmitente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void destinatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDestinatario frm = new frmDestinatario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransporador frm = new frmTransporador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gerarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeradorArquivo frm = new frmGeradorArquivo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
