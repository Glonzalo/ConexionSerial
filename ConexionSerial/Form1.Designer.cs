﻿namespace ConexionSerial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.TxtDatosaEnviar = new System.Windows.Forms.TextBox();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(37, 29);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(157, 23);
            this.BtnBuscarPuertos.TabIndex = 0;
            this.BtnBuscarPuertos.Text = "Buscar Puertos";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(493, 27);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(157, 23);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(37, 135);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(157, 23);
            this.BtnEnviarDatos.TabIndex = 2;
            this.BtnEnviarDatos.Text = "Show Conf";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(245, 29);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 21);
            this.CboPuertos.TabIndex = 3;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.CboBaudRate.Location = new System.Drawing.Point(245, 77);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.CboBaudRate.TabIndex = 4;
            this.CboBaudRate.Text = "9600";
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Location = new System.Drawing.Point(34, 80);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.LblBaudRate.TabIndex = 5;
            this.LblBaudRate.Text = "Baud Rate";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.Location = new System.Drawing.Point(34, 191);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(85, 13);
            this.LblDatosIngreso.TabIndex = 6;
            this.LblDatosIngreso.Text = "Datos Recibidos";
            // 
            // TxtDatosaEnviar
            // 
            this.TxtDatosaEnviar.Location = new System.Drawing.Point(245, 137);
            this.TxtDatosaEnviar.Name = "TxtDatosaEnviar";
            this.TxtDatosaEnviar.Size = new System.Drawing.Size(405, 20);
            this.TxtDatosaEnviar.TabIndex = 7;
            this.TxtDatosaEnviar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDatosaEnviar_Enter);
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(37, 216);
            this.TxtDatosRecibidos.Multiline = true;
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(623, 161);
            this.TxtDatosRecibidos.TabIndex = 8;
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.TxtDatosaEnviar);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnBuscarPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.Windows.Forms.TextBox TxtDatosaEnviar;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.IO.Ports.SerialPort SpPuertos;
    }
}
