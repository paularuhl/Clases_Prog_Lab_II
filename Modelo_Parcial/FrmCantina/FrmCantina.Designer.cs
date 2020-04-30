namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.barra1 = new ControlCantina.Barra();
            this.radioCerveza = new System.Windows.Forms.RadioButton();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.numericCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numericContenido = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 0;
            // 
            // radioCerveza
            // 
            this.radioCerveza.AutoSize = true;
            this.radioCerveza.Location = new System.Drawing.Point(21, 395);
            this.radioCerveza.Name = "radioCerveza";
            this.radioCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioCerveza.TabIndex = 1;
            this.radioCerveza.Text = "Cerveza";
            this.radioCerveza.UseVisualStyleBackColor = true;
            this.radioCerveza.Checked = true;
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(21, 418);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 2;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(163, 395);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(353, 395);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 4;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(163, 440);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 5;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(259, 440);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 6;
            this.lblContenido.Text = "Contenido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 440);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 36);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(166, 411);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(148, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(356, 411);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(128, 21);
            this.cmbBotellaTipo.TabIndex = 9;
            // 
            // numericCapacidad
            // 
            this.numericCapacidad.Location = new System.Drawing.Point(166, 456);
            this.numericCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacidad.Name = "numericCapacidad";
            this.numericCapacidad.Size = new System.Drawing.Size(55, 20);
            this.numericCapacidad.TabIndex = 11;
            this.numericCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericContenido
            // 
            this.numericContenido.Location = new System.Drawing.Point(262, 456);
            this.numericContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericContenido.Name = "numericContenido";
            this.numericContenido.Size = new System.Drawing.Size(55, 20);
            this.numericContenido.TabIndex = 12;
            this.numericContenido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 499);
            this.Controls.Add(this.numericContenido);
            this.Controls.Add(this.numericCapacidad);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.radioAgua);
            this.Controls.Add(this.radioCerveza);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Ruhl Paula";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton radioCerveza;
        private System.Windows.Forms.RadioButton radioAgua;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.NumericUpDown numericCapacidad;
        private System.Windows.Forms.NumericUpDown numericContenido;
    }
}

