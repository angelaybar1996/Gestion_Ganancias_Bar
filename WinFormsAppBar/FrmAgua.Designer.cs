
namespace WinFormsAppBar
{
    partial class FrmAgua
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
            this.cboTipoAgua = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTipoAgua
            // 
            this.cboTipoAgua.FormattingEnabled = true;
            this.cboTipoAgua.Location = new System.Drawing.Point(40, 172);
            this.cboTipoAgua.Name = "cboTipoAgua";
            this.cboTipoAgua.Size = new System.Drawing.Size(156, 23);
            this.cboTipoAgua.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo:";
            // 
            // FrmAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoAgua);
            this.Name = "FrmAgua";
            this.Text = "FrmAgua";
            this.Controls.SetChildIndex(this.cboTipoAgua, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoAgua;
        private System.Windows.Forms.Label label4;
    }
}