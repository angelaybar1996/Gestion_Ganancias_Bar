using System;
using System.Windows.Forms;
using Entidades.Establecimieto;

namespace WinFormsAppBar
{
    public partial class FrmBarInicio : Form
    {
        private Bar bar;
        public Bar BarDelForm { get { return this.bar; } }

        public FrmBarInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            string nombre = this.txtNombre.Text;
            string cantidad = this.txtCantidadMaxima.Text;

            if(String.IsNullOrWhiteSpace(nombre) && String.IsNullOrWhiteSpace(cantidad))
            {
                this.bar = new Bar();
            }
            else if( ! String.IsNullOrWhiteSpace(nombre) && ! String.IsNullOrWhiteSpace(cantidad))
            {
                this.bar = new Bar(Int32.Parse(cantidad), nombre);
            }
            else if ( ! String.IsNullOrWhiteSpace(cantidad))
            {
                this.bar = new Bar(Int32.Parse(cantidad));
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }
    }
}
