namespace ConexionSerial
{
    partial class Form6
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnConfigurar = new System.Windows.Forms.Button();
            this.BtnMostrarConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(61, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Configuración de Servicio";
            // 
            // BtnConfigurar
            // 
            this.BtnConfigurar.Location = new System.Drawing.Point(385, 95);
            this.BtnConfigurar.Name = "BtnConfigurar";
            this.BtnConfigurar.Size = new System.Drawing.Size(132, 23);
            this.BtnConfigurar.TabIndex = 5;
            this.BtnConfigurar.Text = "Configurar";
            this.BtnConfigurar.UseVisualStyleBackColor = true;
            this.BtnConfigurar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMostrarConfig
            // 
            this.BtnMostrarConfig.Location = new System.Drawing.Point(178, 95);
            this.BtnMostrarConfig.Name = "BtnMostrarConfig";
            this.BtnMostrarConfig.Size = new System.Drawing.Size(93, 23);
            this.BtnMostrarConfig.TabIndex = 6;
            this.BtnMostrarConfig.Text = "Show Conf";
            this.BtnMostrarConfig.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datos Recibidos";
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(281, 339);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(93, 23);
            this.BtnAtras.TabIndex = 8;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            // 
            // LblInfo
            // 
            this.LblInfo.Location = new System.Drawing.Point(65, 169);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(532, 144);
            this.LblInfo.TabIndex = 9;
            this.LblInfo.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMostrarConfig);
            this.Controls.Add(this.BtnConfigurar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnConfigurar;
        private System.Windows.Forms.Button BtnMostrarConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.ListView LblInfo;
        private System.Windows.Forms.Label label2;
    }
}