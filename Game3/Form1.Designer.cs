namespace Game3
{
    partial class Form1
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
            this.btnServidor = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.textPortaClient = new System.Windows.Forms.TextBox();
            this.txtPortaServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnServidor
            // 
            this.btnServidor.Location = new System.Drawing.Point(12, 42);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(260, 59);
            this.btnServidor.TabIndex = 0;
            this.btnServidor.Text = "Servidor";
            this.btnServidor.UseVisualStyleBackColor = true;
            this.btnServidor.Click += new System.EventHandler(this.btnServidor_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(12, 130);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(158, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "localhost";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 156);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(260, 58);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // textPortaClient
            // 
            this.textPortaClient.Location = new System.Drawing.Point(176, 130);
            this.textPortaClient.Name = "textPortaClient";
            this.textPortaClient.Size = new System.Drawing.Size(96, 20);
            this.textPortaClient.TabIndex = 3;
            this.textPortaClient.Text = "9000";
            // 
            // txtPortaServer
            // 
            this.txtPortaServer.Location = new System.Drawing.Point(12, 16);
            this.txtPortaServer.Name = "txtPortaServer";
            this.txtPortaServer.Size = new System.Drawing.Size(96, 20);
            this.txtPortaServer.TabIndex = 4;
            this.txtPortaServer.Text = "9000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPortaServer);
            this.Controls.Add(this.textPortaClient);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnServidor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServidor;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox textPortaClient;
        private System.Windows.Forms.TextBox txtPortaServer;
    }
}