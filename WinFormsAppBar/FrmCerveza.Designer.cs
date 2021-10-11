
namespace WinFormsAppBar
{
    partial class FrmCerveza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoCerveza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // cboTipoCerveza
            // 
            this.cboTipoCerveza.FormattingEnabled = true;
            this.cboTipoCerveza.Location = new System.Drawing.Point(40, 172);
            this.cboTipoCerveza.Name = "cboTipoCerveza";
            this.cboTipoCerveza.Size = new System.Drawing.Size(156, 23);
            this.cboTipoCerveza.TabIndex = 1;
            // 
            // FrmCerveza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 287);
            this.Controls.Add(this.cboTipoCerveza);
            this.Controls.Add(this.label1);
            this.Name = "FrmCerveza";
            this.Text = "FrmCerveza";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboTipoCerveza, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtCapacidad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoCerveza;
    }
}