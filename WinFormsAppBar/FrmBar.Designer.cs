
namespace WinFormsAppBar
{
    partial class FrmBar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBotellas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.btnAgregarBotellaAgua = new System.Windows.Forms.Button();
            this.btnQuitarBotella = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.pgbContenido = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMarcaBotella = new System.Windows.Forms.Label();
            this.btnAgregarBotellaCerveza = new System.Windows.Forms.Button();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBotellas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colocar el nombre del bar aquí";
            // 
            // lstBotellas
            // 
            this.lstBotellas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBotellas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBotellas.FormattingEnabled = true;
            this.lstBotellas.ItemHeight = 17;
            this.lstBotellas.Location = new System.Drawing.Point(3, 19);
            this.lstBotellas.Name = "lstBotellas";
            this.lstBotellas.Size = new System.Drawing.Size(781, 251);
            this.lstBotellas.TabIndex = 0;
            this.lstBotellas.SelectedIndexChanged += new System.EventHandler(this.lstBotellas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenamiento:";
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Location = new System.Drawing.Point(805, 49);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(171, 23);
            this.cboOrdenamiento.TabIndex = 2;
            this.cboOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cboOrdenamiento_SelectedIndexChanged);
            // 
            // btnAgregarBotellaAgua
            // 
            this.btnAgregarBotellaAgua.Location = new System.Drawing.Point(805, 127);
            this.btnAgregarBotellaAgua.Name = "btnAgregarBotellaAgua";
            this.btnAgregarBotellaAgua.Size = new System.Drawing.Size(171, 42);
            this.btnAgregarBotellaAgua.TabIndex = 3;
            this.btnAgregarBotellaAgua.Text = "Agregar Botella de Agua";
            this.btnAgregarBotellaAgua.UseVisualStyleBackColor = true;
            this.btnAgregarBotellaAgua.Click += new System.EventHandler(this.btnAgregarBotellaCerveza_Click);
            // 
            // btnQuitarBotella
            // 
            this.btnQuitarBotella.Location = new System.Drawing.Point(805, 240);
            this.btnQuitarBotella.Name = "btnQuitarBotella";
            this.btnQuitarBotella.Size = new System.Drawing.Size(171, 42);
            this.btnQuitarBotella.TabIndex = 4;
            this.btnQuitarBotella.Text = "Quitar Medida de Botella";
            this.btnQuitarBotella.UseVisualStyleBackColor = true;
            this.btnQuitarBotella.Click += new System.EventHandler(this.btnQuitarBotella_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contenido (%):";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContenido.Location = new System.Drawing.Point(6, 46);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ReadOnly = true;
            this.txtContenido.Size = new System.Drawing.Size(49, 34);
            this.txtContenido.TabIndex = 14;
            this.txtContenido.Text = "100";
            this.txtContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pgbContenido
            // 
            this.pgbContenido.Location = new System.Drawing.Point(6, 86);
            this.pgbContenido.Name = "pgbContenido";
            this.pgbContenido.Size = new System.Drawing.Size(769, 23);
            this.pgbContenido.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMarcaBotella);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContenido);
            this.groupBox2.Controls.Add(this.pgbContenido);
            this.groupBox2.Location = new System.Drawing.Point(15, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Botella:";
            // 
            // lblMarcaBotella
            // 
            this.lblMarcaBotella.AutoSize = true;
            this.lblMarcaBotella.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMarcaBotella.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaBotella.Location = new System.Drawing.Point(112, 33);
            this.lblMarcaBotella.Name = "lblMarcaBotella";
            this.lblMarcaBotella.Size = new System.Drawing.Size(0, 54);
            this.lblMarcaBotella.TabIndex = 20;
            // 
            // btnAgregarBotellaCerveza
            // 
            this.btnAgregarBotellaCerveza.Location = new System.Drawing.Point(805, 175);
            this.btnAgregarBotellaCerveza.Name = "btnAgregarBotellaCerveza";
            this.btnAgregarBotellaCerveza.Size = new System.Drawing.Size(171, 42);
            this.btnAgregarBotellaCerveza.TabIndex = 17;
            this.btnAgregarBotellaCerveza.Text = "Agregar Botella de Cerveza";
            this.btnAgregarBotellaCerveza.UseVisualStyleBackColor = true;
            this.btnAgregarBotellaCerveza.Click += new System.EventHandler(this.btnAgregarBotellaCerveza_Click);
            // 
            // txtGanancia
            // 
            this.txtGanancia.Font = new System.Drawing.Font("OpenSymbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGanancia.Location = new System.Drawing.Point(805, 354);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.ReadOnly = true;
            this.txtGanancia.Size = new System.Drawing.Size(171, 40);
            this.txtGanancia.TabIndex = 18;
            this.txtGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(805, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ganancia:";
            // 
            // FrmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.btnAgregarBotellaCerveza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuitarBotella);
            this.Controls.Add(this.btnAgregarBotellaAgua);
            this.Controls.Add(this.cboOrdenamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBar";
            this.Text = "FrmBar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBotellas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Button btnAgregarBotellaAgua;
        private System.Windows.Forms.Button btnQuitarBotella;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.ProgressBar pgbContenido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarBotellaCerveza;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMarcaBotella;
    }
}