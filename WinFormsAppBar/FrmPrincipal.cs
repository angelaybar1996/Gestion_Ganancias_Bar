using System;
using System.Windows.Forms;

namespace WinFormsAppBar
{
    public partial class FrmPrincipal : Form
    {
        protected Entidades.Establecimieto.Bar bar;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            /// INGRESE SU APELLIDO Y NOMBRE
            string alumno = "Angel Aybar";
            MessageBox.Show(alumno);
            this.Text = alumno;
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarInicio frm = new FrmBarInicio();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frm.BarDelForm.MostrarBar, "INFO BAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.bar = frm.BarDelForm;

                FrmBar frmB = new FrmBar(this.bar);
                frmB.StartPosition = FormStartPosition.CenterScreen;

                frmB.MdiParent = this;

                frmB.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Atención", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) ==  DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
