using System;
using System.Windows.Forms;

namespace WinFormsAppBar
{
    public partial class FrmBar : Form
    {
        Entidades.Establecimieto.Bar bar;

        public FrmBar()
        {
            InitializeComponent();
        }

        public FrmBar(Entidades.Establecimieto.Bar bar)
            :this()
        {
            this.bar = bar;

            this.cboOrdenamiento.DataSource = Enum.GetValues(typeof(Ordenamiento));
            this.cboOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboOrdenamiento.SelectedItem = Ordenamiento.Marca;

            this.txtGanancia.Text = string.Format("{0:C}", ((Double)this.bar));
        }

        private void btnAgregarBotellaAgua_Click(object sender, EventArgs e)
        {
            this.AgregarBotella(sender, e);
        }

        private void btnAgregarBotellaCerveza_Click(object sender, EventArgs e)
        {
            this.AgregarBotella(sender, e);
        }

        private void btnQuitarBotella_Click(object sender, EventArgs e)
        {
            if (this.lstBotellas.SelectedItem != null)
            {
                Entidades.Botella.Botella botella = (Entidades.Botella.Botella)this.lstBotellas.SelectedItem;

                this.bar -= botella;

                this.txtGanancia.Text = string.Format("{0:C}", ((Double)this.bar));

                this.ActualizarListado();
            }
        }

        private void AgregarBotella(object sender, EventArgs e)
        {
            FrmBotella frm = null;

            if( ((Button)sender).Name == "btnAgregarBotellaAgua" )
            {
                frm = new FrmAgua();
            }

            if (((Button)sender).Name == "btnAgregarBotellaCerveza")
            {
                frm = new FrmCerveza();
            }

            frm.StartPosition = FormStartPosition.CenterScreen;

            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.bar += frm.BotellaDelForm;
                this.ActualizarListado();
            }
        }

        private void ActualizarListado()
        {
            this.lstBotellas.Items.Clear();

            foreach (Entidades.Botella.Botella item in this.bar.Botellas)
            {
                this.lstBotellas.Items.Add(item);
            }

            this.LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            this.txtContenido.Clear();
            this.pgbContenido.Value = 0;
            this.lblMarcaBotella.Text = "";
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Ordenamiento)this.cboOrdenamiento.SelectedItem)
            {
                case Ordenamiento.Marca:
                    this.bar.OrdenarBotellas(Ordenamiento.Marca);
                    break;
                case Ordenamiento.Ganancia:
                    this.bar.OrdenarBotellas(Ordenamiento.Ganancia);
                    break;
                case Ordenamiento.PorcentajeContenido:
                    this.bar.OrdenarBotellas(Ordenamiento.PorcentajeContenido);
                    break;
                default:
                    break;
            }

            this.ActualizarListado();
        }

        private void lstBotellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidades.Botella.Botella botella = (Entidades.Botella.Botella)this.lstBotellas.SelectedItem;

            this.pgbContenido.Value = (int)botella.PorcentajeContenido;
            this.txtContenido.Text = botella.PorcentajeContenido.ToString();
            this.lblMarcaBotella.Text = (String)botella;
        }

    }
}
