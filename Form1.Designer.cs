
namespace WindowsFormsApp1
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
            this.arquivoText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelecionarArquivo = new Guna.UI2.WinForms.Guna2Button();
            this.diretorioText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelecinarDestino = new Guna.UI2.WinForms.Guna2Button();
            this.ExtraiBt = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // arquivoText
            // 
            this.arquivoText.BorderColor = System.Drawing.Color.DarkGray;
            this.arquivoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arquivoText.DefaultText = "";
            this.arquivoText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.arquivoText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.arquivoText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.arquivoText.DisabledState.Parent = this.arquivoText;
            this.arquivoText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.arquivoText.FillColor = System.Drawing.Color.Gray;
            this.arquivoText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.arquivoText.FocusedState.Parent = this.arquivoText;
            this.arquivoText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.arquivoText.ForeColor = System.Drawing.Color.White;
            this.arquivoText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.arquivoText.HoverState.Parent = this.arquivoText;
            this.arquivoText.Location = new System.Drawing.Point(12, 34);
            this.arquivoText.Name = "arquivoText";
            this.arquivoText.PasswordChar = '\0';
            this.arquivoText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.arquivoText.PlaceholderText = "";
            this.arquivoText.SelectedText = "";
            this.arquivoText.ShadowDecoration.Parent = this.arquivoText;
            this.arquivoText.Size = new System.Drawing.Size(419, 28);
            this.arquivoText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho Arquivo para Extração";
            // 
            // SelecionarArquivo
            // 
            this.SelecionarArquivo.BorderColor = System.Drawing.Color.LightCoral;
            this.SelecionarArquivo.BorderRadius = 2;
            this.SelecionarArquivo.BorderThickness = 1;
            this.SelecionarArquivo.CheckedState.Parent = this.SelecionarArquivo;
            this.SelecionarArquivo.CustomImages.Parent = this.SelecionarArquivo;
            this.SelecionarArquivo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelecionarArquivo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelecionarArquivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelecionarArquivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelecionarArquivo.DisabledState.Parent = this.SelecionarArquivo;
            this.SelecionarArquivo.FillColor = System.Drawing.Color.Firebrick;
            this.SelecionarArquivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecionarArquivo.ForeColor = System.Drawing.Color.White;
            this.SelecionarArquivo.HoverState.Parent = this.SelecionarArquivo;
            this.SelecionarArquivo.Location = new System.Drawing.Point(131, 68);
            this.SelecionarArquivo.Name = "SelecionarArquivo";
            this.SelecionarArquivo.PressedColor = System.Drawing.Color.LightCoral;
            this.SelecionarArquivo.ShadowDecoration.Parent = this.SelecionarArquivo;
            this.SelecionarArquivo.Size = new System.Drawing.Size(180, 45);
            this.SelecionarArquivo.TabIndex = 2;
            this.SelecionarArquivo.Text = "Selecionar";
            this.SelecionarArquivo.Click += new System.EventHandler(this.SelecionarArquivo_Click);
            // 
            // diretorioText
            // 
            this.diretorioText.BorderColor = System.Drawing.Color.DarkGray;
            this.diretorioText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diretorioText.DefaultText = "";
            this.diretorioText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.diretorioText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.diretorioText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diretorioText.DisabledState.Parent = this.diretorioText;
            this.diretorioText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diretorioText.FillColor = System.Drawing.Color.Gray;
            this.diretorioText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diretorioText.FocusedState.Parent = this.diretorioText;
            this.diretorioText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.diretorioText.ForeColor = System.Drawing.Color.White;
            this.diretorioText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diretorioText.HoverState.Parent = this.diretorioText;
            this.diretorioText.Location = new System.Drawing.Point(12, 190);
            this.diretorioText.Name = "diretorioText";
            this.diretorioText.PasswordChar = '\0';
            this.diretorioText.PlaceholderText = "";
            this.diretorioText.SelectedText = "";
            this.diretorioText.ShadowDecoration.Parent = this.diretorioText;
            this.diretorioText.Size = new System.Drawing.Size(419, 28);
            this.diretorioText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caminho de Destino";
            // 
            // SelecinarDestino
            // 
            this.SelecinarDestino.BorderColor = System.Drawing.Color.LightCoral;
            this.SelecinarDestino.BorderRadius = 2;
            this.SelecinarDestino.BorderThickness = 1;
            this.SelecinarDestino.CheckedState.Parent = this.SelecinarDestino;
            this.SelecinarDestino.CustomImages.Parent = this.SelecinarDestino;
            this.SelecinarDestino.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelecinarDestino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelecinarDestino.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelecinarDestino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelecinarDestino.DisabledState.Parent = this.SelecinarDestino;
            this.SelecinarDestino.FillColor = System.Drawing.Color.Firebrick;
            this.SelecinarDestino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecinarDestino.ForeColor = System.Drawing.Color.White;
            this.SelecinarDestino.HoverState.Parent = this.SelecinarDestino;
            this.SelecinarDestino.Location = new System.Drawing.Point(131, 224);
            this.SelecinarDestino.Name = "SelecinarDestino";
            this.SelecinarDestino.PressedColor = System.Drawing.Color.LightCoral;
            this.SelecinarDestino.ShadowDecoration.Parent = this.SelecinarDestino;
            this.SelecinarDestino.Size = new System.Drawing.Size(180, 45);
            this.SelecinarDestino.TabIndex = 6;
            this.SelecinarDestino.Text = "Selecionar";
            this.SelecinarDestino.Click += new System.EventHandler(this.SelecinarDestino_Click);
            // 
            // ExtraiBt
            // 
            this.ExtraiBt.BorderColor = System.Drawing.Color.LightCoral;
            this.ExtraiBt.BorderRadius = 2;
            this.ExtraiBt.BorderThickness = 1;
            this.ExtraiBt.CheckedState.Parent = this.ExtraiBt;
            this.ExtraiBt.CustomImages.Parent = this.ExtraiBt;
            this.ExtraiBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExtraiBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExtraiBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExtraiBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExtraiBt.DisabledState.Parent = this.ExtraiBt;
            this.ExtraiBt.FillColor = System.Drawing.Color.Firebrick;
            this.ExtraiBt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraiBt.ForeColor = System.Drawing.Color.White;
            this.ExtraiBt.HoverState.Parent = this.ExtraiBt;
            this.ExtraiBt.Location = new System.Drawing.Point(131, 393);
            this.ExtraiBt.Name = "ExtraiBt";
            this.ExtraiBt.PressedColor = System.Drawing.Color.LightCoral;
            this.ExtraiBt.ShadowDecoration.Parent = this.ExtraiBt;
            this.ExtraiBt.Size = new System.Drawing.Size(180, 45);
            this.ExtraiBt.TabIndex = 7;
            this.ExtraiBt.Text = "Extrair";
            this.ExtraiBt.Click += new System.EventHandler(this.ExtraiBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.ExtraiBt);
            this.Controls.Add(this.SelecinarDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diretorioText);
            this.Controls.Add(this.SelecionarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arquivoText);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 489);
            this.MinimumSize = new System.Drawing.Size(459, 489);
            this.Name = "Form1";
            this.Text = "Extrator de Aquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox arquivoText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button SelecionarArquivo;
        private Guna.UI2.WinForms.Guna2TextBox diretorioText;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button SelecinarDestino;
        private Guna.UI2.WinForms.Guna2Button ExtraiBt;
    }
}