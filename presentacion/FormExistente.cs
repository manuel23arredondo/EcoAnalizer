﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmExistente : Form
    {
        public frmExistente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Enviados", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
