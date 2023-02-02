namespace DepreciacionEnLinea
{
    partial class frmTipoDepreciacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtValorBien = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepreBien = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbxTipo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEqOf = new System.Windows.Forms.CheckBox();
            this.cbxEdi = new System.Windows.Forms.CheckBox();
            this.cbxVeh = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de depreciacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de bien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor del bien";
            // 
            // mtxtValorBien
            // 
            this.mtxtValorBien.Location = new System.Drawing.Point(201, 209);
            this.mtxtValorBien.Mask = "00000000";
            this.mtxtValorBien.Name = "mtxtValorBien";
            this.mtxtValorBien.Size = new System.Drawing.Size(51, 23);
            this.mtxtValorBien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Depreciacion";
            // 
            // txtDepreBien
            // 
            this.txtDepreBien.Location = new System.Drawing.Point(201, 279);
            this.txtDepreBien.Name = "txtDepreBien";
            this.txtDepreBien.Size = new System.Drawing.Size(100, 23);
            this.txtDepreBien.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(56, 365);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(137, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(218, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbxTipo
            // 
            this.lbxTipo.FormattingEnabled = true;
            this.lbxTipo.ItemHeight = 15;
            this.lbxTipo.Items.AddRange(new object[] {
            "Linea recta",
            "Suma de Digitos"});
            this.lbxTipo.Location = new System.Drawing.Point(205, 36);
            this.lbxTipo.Name = "lbxTipo";
            this.lbxTipo.Size = new System.Drawing.Size(96, 34);
            this.lbxTipo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cbxEqOf);
            this.panel1.Controls.Add(this.cbxEdi);
            this.panel1.Controls.Add(this.cbxVeh);
            this.panel1.Location = new System.Drawing.Point(201, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 82);
            this.panel1.TabIndex = 11;
            // 
            // cbxEqOf
            // 
            this.cbxEqOf.AutoSize = true;
            this.cbxEqOf.Location = new System.Drawing.Point(13, 56);
            this.cbxEqOf.Name = "cbxEqOf";
            this.cbxEqOf.Size = new System.Drawing.Size(120, 19);
            this.cbxEqOf.TabIndex = 2;
            this.cbxEqOf.Text = "Equipo de Oficina";
            this.cbxEqOf.UseVisualStyleBackColor = true;
            // 
            // cbxEdi
            // 
            this.cbxEdi.AutoSize = true;
            this.cbxEdi.Location = new System.Drawing.Point(13, 31);
            this.cbxEdi.Name = "cbxEdi";
            this.cbxEdi.Size = new System.Drawing.Size(70, 19);
            this.cbxEdi.TabIndex = 1;
            this.cbxEdi.Text = "Edificios";
            this.cbxEdi.UseVisualStyleBackColor = true;
            // 
            // cbxVeh
            // 
            this.cbxVeh.AutoSize = true;
            this.cbxVeh.Location = new System.Drawing.Point(13, 6);
            this.cbxVeh.Name = "cbxVeh";
            this.cbxVeh.Size = new System.Drawing.Size(76, 19);
            this.cbxVeh.TabIndex = 0;
            this.cbxVeh.Text = "Vehiculos";
            this.cbxVeh.UseVisualStyleBackColor = true;
            // 
            // frmTipoDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxTipo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDepreBien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtValorBien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoDepreciacion";
            this.Text = "frmTipoDepreciacion";
            this.Load += new System.EventHandler(this.frmTipoDepreciacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtxtValorBien;
        private Label label4;
        private TextBox txtDepreBien;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ListBox lbxTipo;
        private Panel panel1;
        private CheckBox cbxEqOf;
        private CheckBox cbxEdi;
        private CheckBox cbxVeh;
    }
}