using System;
using System.Windows.Forms;

namespace WinFormsAppBar
{
    public partial class FrmAgua : FrmBotella
    {
        private Entidades.Botella.Agua agua;

        public override Entidades.Botella.Botella BotellaDelForm => this.agua;

        public FrmAgua() : base()
        {
            InitializeComponent();
            
            this.cboTipoAgua.DataSource = Enum.GetValues(typeof(TipoAgua));
            this.cboTipoAgua.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTipoAgua.SelectedItem = TipoAgua.DeCanilla;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.agua = new Entidades.Botella.Agua(base.txtMarca.Text, Double.Parse(base.txtPrecio.Text), 
                                Int32.Parse(base.txtCapacidad.Text), (TipoAgua)this.cboTipoAgua.SelectedItem);

            base.btnAceptar_Click(sender, e);
        }
    }
}
