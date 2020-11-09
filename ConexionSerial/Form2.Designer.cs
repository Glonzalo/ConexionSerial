namespace ConexionSerial
{
    partial class Form2
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.CmbPuertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CmbBaud = new System.Windows.Forms.ComboBox();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(125, 260);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 23);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbPuertos
            // 
            this.CmbPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPuertos.FormattingEnabled = true;
            this.CmbPuertos.Items.AddRange(new object[] {
            "Seleccionar Puerto"});
            this.CmbPuertos.Location = new System.Drawing.Point(269, 129);
            this.CmbPuertos.Name = "CmbPuertos";
            this.CmbPuertos.Size = new System.Drawing.Size(121, 21);
            this.CmbPuertos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conectar a dispositivo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(114, 129);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(96, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar Puertos";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CmbBaud
            // 
            this.CmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBaud.FormattingEnabled = true;
            this.CmbBaud.Items.AddRange(new object[] {
            "Seleccione una opción",
            "4800",
            "9600",
            "19200"});
            this.CmbBaud.Location = new System.Drawing.Point(269, 186);
            this.CmbBaud.Name = "CmbBaud";
            this.CmbBaud.Size = new System.Drawing.Size(121, 21);
            this.CmbBaud.TabIndex = 5;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.AutoSize = true;
            this.BtnSiguiente.Location = new System.Drawing.Point(292, 260);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(61, 23);
            this.BtnSiguiente.TabIndex = 6;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(10, 346);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(237, 13);
            this.LblInfo.TabIndex = 7;
            this.LblInfo.Text = "Por favor, establezca conexión con el dispositivo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 374);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.CmbBaud);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbPuertos);
            this.Controls.Add(this.BtnConectar);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.ComboBox CmbBaud;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPuertos;
        private System.Windows.Forms.Button BtnConectar;
    }
}