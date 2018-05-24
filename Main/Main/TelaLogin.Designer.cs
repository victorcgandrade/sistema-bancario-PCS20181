﻿namespace Main
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.cmbBoxTipoUser = new System.Windows.Forms.ComboBox();
            this.tlpDadosAdm = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.picBoxIcone = new System.Windows.Forms.PictureBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDadosUser = new System.Windows.Forms.Panel();
            this.tlpDadosCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxAgencia = new System.Windows.Forms.TextBox();
            this.txtBoxConta = new System.Windows.Forms.TextBox();
            this.tlpMenu.SuspendLayout();
            this.tlpDadosAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).BeginInit();
            this.pnlDadosUser.SuspendLayout();
            this.tlpDadosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMenu.Controls.Add(this.lblIdentificacao, 0, 1);
            this.tlpMenu.Controls.Add(this.cmbBoxTipoUser, 0, 2);
            this.tlpMenu.Controls.Add(this.btnAcessar, 0, 4);
            this.tlpMenu.Controls.Add(this.picBoxIcone, 0, 0);
            this.tlpMenu.Controls.Add(this.pnlDadosUser, 0, 3);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpMenu.Location = new System.Drawing.Point(632, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 6;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(200, 450);
            this.tlpMenu.TabIndex = 0;
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacao.ForeColor = System.Drawing.Color.White;
            this.lblIdentificacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblIdentificacao.Location = new System.Drawing.Point(3, 155);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(194, 19);
            this.lblIdentificacao.TabIndex = 1;
            this.lblIdentificacao.Text = "Identificação";
            this.lblIdentificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxTipoUser
            // 
            this.cmbBoxTipoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoUser.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTipoUser.FormattingEnabled = true;
            this.cmbBoxTipoUser.Location = new System.Drawing.Point(3, 188);
            this.cmbBoxTipoUser.Name = "cmbBoxTipoUser";
            this.cmbBoxTipoUser.Size = new System.Drawing.Size(194, 23);
            this.cmbBoxTipoUser.TabIndex = 2;
            this.cmbBoxTipoUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipoUser_SelectedIndexChanged);
            // 
            // tlpDadosAdm
            // 
            this.tlpDadosAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.tlpDadosAdm.ColumnCount = 2;
            this.tlpDadosAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosAdm.Controls.Add(this.txtBoxCodigo, 0, 0);
            this.tlpDadosAdm.Controls.Add(this.txtBoxSenha, 1, 0);
            this.tlpDadosAdm.Location = new System.Drawing.Point(632, 230);
            this.tlpDadosAdm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDadosAdm.Name = "tlpDadosAdm";
            this.tlpDadosAdm.RowCount = 1;
            this.tlpDadosAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDadosAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDadosAdm.Size = new System.Drawing.Size(200, 30);
            this.tlpDadosAdm.TabIndex = 3;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(94, 23);
            this.txtBoxCodigo.TabIndex = 0;
            this.txtBoxCodigo.Text = "Código";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSenha.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(103, 3);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(94, 23);
            this.txtBoxSenha.TabIndex = 1;
            this.txtBoxSenha.Text = "Senha";
            // 
            // btnAcessar
            // 
            this.btnAcessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcessar.Location = new System.Drawing.Point(62, 268);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            // 
            // picBoxIcone
            // 
            this.picBoxIcone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcone.Image")));
            this.picBoxIcone.Location = new System.Drawing.Point(30, 5);
            this.picBoxIcone.Name = "picBoxIcone";
            this.picBoxIcone.Size = new System.Drawing.Size(140, 140);
            this.picBoxIcone.TabIndex = 0;
            this.picBoxIcone.TabStop = false;
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 422);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFooter.Size = new System.Drawing.Size(632, 28);
            this.tlpFooter.TabIndex = 1;
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(632, 30);
            this.tlpHeader.TabIndex = 2;
            // 
            // pnlDadosUser
            // 
            this.pnlDadosUser.Controls.Add(this.tlpDadosCliente);
            this.pnlDadosUser.Location = new System.Drawing.Point(0, 220);
            this.pnlDadosUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDadosUser.Name = "pnlDadosUser";
            this.pnlDadosUser.Size = new System.Drawing.Size(200, 40);
            this.pnlDadosUser.TabIndex = 5;
            // 
            // tlpDadosCliente
            // 
            this.tlpDadosCliente.ColumnCount = 2;
            this.tlpDadosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosCliente.Controls.Add(this.txtBoxConta, 1, 0);
            this.tlpDadosCliente.Controls.Add(this.txtBoxAgencia, 0, 0);
            this.tlpDadosCliente.Location = new System.Drawing.Point(0, 11);
            this.tlpDadosCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDadosCliente.Name = "tlpDadosCliente";
            this.tlpDadosCliente.RowCount = 1;
            this.tlpDadosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDadosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDadosCliente.Size = new System.Drawing.Size(200, 29);
            this.tlpDadosCliente.TabIndex = 4;
            // 
            // txtBoxAgencia
            // 
            this.txtBoxAgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAgencia.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgencia.Location = new System.Drawing.Point(3, 3);
            this.txtBoxAgencia.Name = "txtBoxAgencia";
            this.txtBoxAgencia.Size = new System.Drawing.Size(94, 23);
            this.txtBoxAgencia.TabIndex = 0;
            this.txtBoxAgencia.Text = "Agência";
            // 
            // txtBoxConta
            // 
            this.txtBoxConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConta.Location = new System.Drawing.Point(103, 3);
            this.txtBoxConta.Name = "txtBoxConta";
            this.txtBoxConta.Size = new System.Drawing.Size(94, 23);
            this.txtBoxConta.TabIndex = 1;
            this.txtBoxConta.Text = "Conta";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.tlpDadosAdm);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpMenu);
            this.Name = "TelaLogin";
            this.ShowIcon = false;
            this.Text = "A&A Desktop";
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.tlpDadosAdm.ResumeLayout(false);
            this.tlpDadosAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).EndInit();
            this.pnlDadosUser.ResumeLayout(false);
            this.tlpDadosCliente.ResumeLayout(false);
            this.tlpDadosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox picBoxIcone;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.ComboBox cmbBoxTipoUser;
        private System.Windows.Forms.TableLayoutPanel tlpDadosAdm;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Panel pnlDadosUser;
        private System.Windows.Forms.TableLayoutPanel tlpDadosCliente;
        private System.Windows.Forms.TextBox txtBoxConta;
        private System.Windows.Forms.TextBox txtBoxAgencia;
    }
}