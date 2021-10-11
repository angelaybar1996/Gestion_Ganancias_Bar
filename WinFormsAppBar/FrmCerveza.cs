using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppBar
{
    public partial class FrmCerveza : FrmBotella
    {
        private Entidades.Botella.Cerveza cerveza;

        public override Entidades.Botella.Botella BotellaDelForm => this.cerveza;

        public FrmCerveza()
        {
            InitializeComponent();

            this.cboTipoCerveza.DataSource = Enum.GetValues(typeof(TipoCerveza));
            this.cboTipoCerveza.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTipoCerveza.SelectedItem = TipoCerveza.Lager;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cerveza = new Entidades.Botella.Cerveza(base.txtMarca.Text, Double.Parse(base.txtPrecio.Text),
                Int32.Parse(base.txtCapacidad.Text), (TipoCerveza)this.cboTipoCerveza.SelectedItem);

            base.btnAceptar_Click(sender, e);
        }
    }
}
