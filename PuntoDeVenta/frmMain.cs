using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void abrirFormHijo(object formHijo) {

            if (this.fluentDesignFormContainer1.Controls.Count > 0) {

                this.fluentDesignFormContainer1.Controls.RemoveAt(0);

            }

            Form fh = formHijo as Form;

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            this.fluentDesignFormContainer1.Controls.Add(fh);

            this.fluentDesignFormContainer1.Tag = fh;

            fh.Show();

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Clientes());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Productos());
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
