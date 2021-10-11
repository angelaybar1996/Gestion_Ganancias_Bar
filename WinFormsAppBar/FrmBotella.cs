using System;
using System.Windows.Forms;

namespace WinFormsAppBar
{
    public abstract partial class FrmBotella : Form
    {
        public abstract Entidades.Botella.Botella BotellaDelForm
        { get; }

        public FrmBotella()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
