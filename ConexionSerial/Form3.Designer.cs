namespace ConexionSerial
{
    partial class Form3
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
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAlertaServicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(215, 273);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BtnSiguiente.TabIndex = 13;
            this.BtnSiguiente.Text = "Continuar";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // CmbModelo
            // 
            this.CmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Items.AddRange(new object[] {
            "881",
            "891"});
            this.CmbModelo.Location = new System.Drawing.Point(268, 197);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(121, 21);
            this.CmbModelo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nuevo Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modelo";
            // 
            // CmbServicio
            // 
            this.CmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServicio.FormattingEnabled = true;
            this.CmbServicio.Items.AddRange(new object[] {
            "IPF",
            "MUB"});
            this.CmbServicio.Location = new System.Drawing.Point(268, 124);
            this.CmbServicio.Name = "CmbServicio";
            this.CmbServicio.Size = new System.Drawing.Size(121, 21);
            this.CmbServicio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Servicio";
            // 
            // LblAlertaServicio
            // 
            this.LblAlertaServicio.AutoSize = true;
            this.LblAlertaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlertaServicio.ForeColor = System.Drawing.SystemColors.Info;
            this.LblAlertaServicio.Location = new System.Drawing.Point(121, 163);
            this.LblAlertaServicio.Name = "LblAlertaServicio";
            this.LblAlertaServicio.Size = new System.Drawing.Size(207, 20);
            this.LblAlertaServicio.TabIndex = 15;
            this.LblAlertaServicio.Text = "Por favor seleccione servicio";
            this.LblAlertaServicio.Click += new System.EventHandler(this.LblAlertaServicio_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 374);
            this.Controls.Add(this.LblAlertaServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbServicio);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección Servicio";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAlertaServicio;
    }
}