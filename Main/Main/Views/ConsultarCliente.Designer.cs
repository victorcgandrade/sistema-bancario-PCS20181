namespace Main.Views
{
    partial class ConsultarCliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_TituloConsultarCliente = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dgv_ResultadoConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(519, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "O que você está procurando?";
            // 
            // lb_TituloConsultarCliente
            // 
            this.lb_TituloConsultarCliente.AutoSize = true;
            this.lb_TituloConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloConsultarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloConsultarCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloConsultarCliente.Location = new System.Drawing.Point(247, 74);
            this.lb_TituloConsultarCliente.Name = "lb_TituloConsultarCliente";
            this.lb_TituloConsultarCliente.Size = new System.Drawing.Size(169, 21);
            this.lb_TituloConsultarCliente.TabIndex = 35;
            this.lb_TituloConsultarCliente.Text = "CONSULTAR CLIENTE";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Consultar.Location = new System.Drawing.Point(896, 152);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(99, 26);
            this.btn_Consultar.TabIndex = 36;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            // 
            // dgv_ResultadoConsulta
            // 
            this.dgv_ResultadoConsulta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoConsulta.Location = new System.Drawing.Point(454, 209);
            this.dgv_ResultadoConsulta.Name = "dgv_ResultadoConsulta";
            this.dgv_ResultadoConsulta.Size = new System.Drawing.Size(589, 326);
            this.dgv_ResultadoConsulta.TabIndex = 37;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Controls.Add(this.dgv_ResultadoConsulta);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.lb_TituloConsultarCliente);
            this.Controls.Add(this.textBox1);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lb_TituloConsultarCliente, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.dgv_ResultadoConsulta, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_TituloConsultarCliente;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridView dgv_ResultadoConsulta;
    }
}