namespace prototipo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.areaExe1 = new prototipo2.AreaExe();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAreaExe = new System.Windows.Forms.Button();
            this.pnlDefaultColor = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaExe1
            // 
            this.areaExe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.areaExe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaExe1.Location = new System.Drawing.Point(0, 0);
            this.areaExe1.MaximumSize = new System.Drawing.Size(1200, 720);
            this.areaExe1.MinimumSize = new System.Drawing.Size(1184, 681);
            this.areaExe1.Name = "areaExe1";
            this.areaExe1.Size = new System.Drawing.Size(1184, 681);
            this.areaExe1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(1184, 681);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1184, 681);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(964, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 681);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.Silver;
            this.btnSair.Location = new System.Drawing.Point(12, 600);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(189, 69);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDefaultColor);
            this.panel1.Controls.Add(this.btnAreaExe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnAreaExe
            // 
            this.btnAreaExe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAreaExe.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAreaExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaExe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAreaExe.ForeColor = System.Drawing.Color.Silver;
            this.btnAreaExe.Location = new System.Drawing.Point(16, 12);
            this.btnAreaExe.Name = "btnAreaExe";
            this.btnAreaExe.Size = new System.Drawing.Size(189, 69);
            this.btnAreaExe.TabIndex = 2;
            this.btnAreaExe.Text = "Área de Execução";
            this.btnAreaExe.UseVisualStyleBackColor = false;
            this.btnAreaExe.Click += new System.EventHandler(this.btnAreaExe_Click);
            // 
            // pnlDefaultColor
            // 
            this.pnlDefaultColor.Location = new System.Drawing.Point(43, 426);
            this.pnlDefaultColor.Name = "pnlDefaultColor";
            this.pnlDefaultColor.Size = new System.Drawing.Size(38, 34);
            this.pnlDefaultColor.TabIndex = 2;
            this.pnlDefaultColor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.areaExe1);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AreaExe areaExe1;
        private Panel panel4;
        private Panel panel1;
        private Panel pnlDefaultColor;
        private Button btnAreaExe;
        private Panel panel2;
        private Button btnSair;
    }
}