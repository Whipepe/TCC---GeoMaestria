namespace prototipo4
{
    partial class Triângulo
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExplicacaoTexto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlOcultar = new System.Windows.Forms.Panel();
            this.btnOcultarAngulos = new System.Windows.Forms.Button();
            this.btnOcultarDiagonal = new System.Windows.Forms.Button();
            this.pnlExibir = new System.Windows.Forms.Panel();
            this.btnExibirAngulos = new System.Windows.Forms.Button();
            this.btnExibirDiagonal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnLado1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBaseMenor = new System.Windows.Forms.Button();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.btnBasetri1 = new System.Windows.Forms.Button();
            this.btnBasetri2 = new System.Windows.Forms.Button();
            this.btnAngulo1 = new System.Windows.Forms.Button();
            this.btnAngulo3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBasetri1 = new System.Windows.Forms.Label();
            this.lblBasetri2 = new System.Windows.Forms.Label();
            this.lblAngulo1 = new System.Windows.Forms.Label();
            this.lblAngulo3 = new System.Windows.Forms.Label();
            this.lblAngulo2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOcultar.SuspendLayout();
            this.pnlExibir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblExplicacaoTexto);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblExplicacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(734, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 523);
            this.panel1.TabIndex = 4;
            // 
            // lblExplicacaoTexto
            // 
            this.lblExplicacaoTexto.AutoSize = true;
            this.lblExplicacaoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacaoTexto.ForeColor = System.Drawing.Color.Silver;
            this.lblExplicacaoTexto.Location = new System.Drawing.Point(5, 145);
            this.lblExplicacaoTexto.Name = "lblExplicacaoTexto";
            this.lblExplicacaoTexto.Size = new System.Drawing.Size(50, 24);
            this.lblExplicacaoTexto.TabIndex = 2;
            this.lblExplicacaoTexto.Text = "label";
            this.lblExplicacaoTexto.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTipo);
            this.panel3.Controls.Add(this.lblPerimetro);
            this.panel3.Controls.Add(this.lblArea);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 102);
            this.panel3.TabIndex = 1;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.Color.Silver;
            this.lblPerimetro.Location = new System.Drawing.Point(3, 62);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(110, 25);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Silver;
            this.lblArea.Location = new System.Drawing.Point(3, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 25);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área:";
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblExplicacao.Location = new System.Drawing.Point(27, 114);
            this.lblExplicacao.Margin = new System.Windows.Forms.Padding(0);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(145, 31);
            this.lblExplicacao.TabIndex = 0;
            this.lblExplicacao.Text = "Explicação";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPerimetro);
            this.panel2.Controls.Add(this.btnArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 80);
            this.panel2.TabIndex = 5;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnPerimetro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPerimetro.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimetro.ForeColor = System.Drawing.Color.Silver;
            this.btnPerimetro.Location = new System.Drawing.Point(367, 0);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(367, 80);
            this.btnPerimetro.TabIndex = 1;
            this.btnPerimetro.Text = "Perímetro";
            this.btnPerimetro.UseVisualStyleBackColor = false;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArea.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.ForeColor = System.Drawing.Color.Silver;
            this.btnArea.Location = new System.Drawing.Point(0, 0);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(367, 80);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::prototipo4.Properties.Resources.triângulo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pnlOcultar
            // 
            this.pnlOcultar.Controls.Add(this.btnOcultarAngulos);
            this.pnlOcultar.Controls.Add(this.btnOcultarDiagonal);
            this.pnlOcultar.Location = new System.Drawing.Point(581, 37);
            this.pnlOcultar.Name = "pnlOcultar";
            this.pnlOcultar.Size = new System.Drawing.Size(77, 68);
            this.pnlOcultar.TabIndex = 39;
            this.pnlOcultar.Visible = false;
            // 
            // btnOcultarAngulos
            // 
            this.btnOcultarAngulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultarAngulos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultarAngulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarAngulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOcultarAngulos.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultarAngulos.Location = new System.Drawing.Point(0, 32);
            this.btnOcultarAngulos.Name = "btnOcultarAngulos";
            this.btnOcultarAngulos.Size = new System.Drawing.Size(77, 34);
            this.btnOcultarAngulos.TabIndex = 20;
            this.btnOcultarAngulos.Text = "Ângulos";
            this.btnOcultarAngulos.UseVisualStyleBackColor = false;
            // 
            // btnOcultarDiagonal
            // 
            this.btnOcultarDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultarDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultarDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOcultarDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultarDiagonal.Location = new System.Drawing.Point(0, -1);
            this.btnOcultarDiagonal.Name = "btnOcultarDiagonal";
            this.btnOcultarDiagonal.Size = new System.Drawing.Size(77, 34);
            this.btnOcultarDiagonal.TabIndex = 19;
            this.btnOcultarDiagonal.Text = "Diagonal";
            this.btnOcultarDiagonal.UseVisualStyleBackColor = false;
            // 
            // pnlExibir
            // 
            this.pnlExibir.Controls.Add(this.btnExibirAngulos);
            this.pnlExibir.Controls.Add(this.btnExibirDiagonal);
            this.pnlExibir.Location = new System.Drawing.Point(657, 37);
            this.pnlExibir.Name = "pnlExibir";
            this.pnlExibir.Size = new System.Drawing.Size(77, 68);
            this.pnlExibir.TabIndex = 38;
            this.pnlExibir.Visible = false;
            // 
            // btnExibirAngulos
            // 
            this.btnExibirAngulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibirAngulos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibirAngulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirAngulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExibirAngulos.ForeColor = System.Drawing.Color.Silver;
            this.btnExibirAngulos.Location = new System.Drawing.Point(0, 32);
            this.btnExibirAngulos.Name = "btnExibirAngulos";
            this.btnExibirAngulos.Size = new System.Drawing.Size(77, 34);
            this.btnExibirAngulos.TabIndex = 20;
            this.btnExibirAngulos.Text = "Ângulos";
            this.btnExibirAngulos.UseVisualStyleBackColor = false;
            // 
            // btnExibirDiagonal
            // 
            this.btnExibirDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibirDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibirDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExibirDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnExibirDiagonal.Location = new System.Drawing.Point(0, -1);
            this.btnExibirDiagonal.Name = "btnExibirDiagonal";
            this.btnExibirDiagonal.Size = new System.Drawing.Size(77, 34);
            this.btnExibirDiagonal.TabIndex = 19;
            this.btnExibirDiagonal.Text = "Diagonal";
            this.btnExibirDiagonal.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpar.Location = new System.Drawing.Point(0, 1);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 36);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultar.Location = new System.Drawing.Point(581, 1);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(77, 36);
            this.btnOcultar.TabIndex = 36;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = false;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnExibir.ForeColor = System.Drawing.Color.Silver;
            this.btnExibir.Location = new System.Drawing.Point(657, 1);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(77, 36);
            this.btnExibir.TabIndex = 35;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTipo.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTipo.Location = new System.Drawing.Point(48, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(102, 25);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Isósceles";
            // 
            // btnLado1
            // 
            this.btnLado1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnLado1.FlatAppearance.BorderSize = 10;
            this.btnLado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLado1.Location = new System.Drawing.Point(243, 231);
            this.btnLado1.Name = "btnLado1";
            this.btnLado1.Size = new System.Drawing.Size(36, 10);
            this.btnLado1.TabIndex = 40;
            this.btnLado1.UseVisualStyleBackColor = true;
            this.btnLado1.Click += new System.EventHandler(this.btnLado1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(436, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 10);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBaseMenor
            // 
            this.btnBaseMenor.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnBaseMenor.FlatAppearance.BorderSize = 10;
            this.btnBaseMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseMenor.Location = new System.Drawing.Point(354, 375);
            this.btnBaseMenor.Name = "btnBaseMenor";
            this.btnBaseMenor.Size = new System.Drawing.Size(10, 36);
            this.btnBaseMenor.TabIndex = 42;
            this.btnBaseMenor.UseVisualStyleBackColor = true;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.BackColor = System.Drawing.Color.Transparent;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.ForeColor = System.Drawing.Color.Silver;
            this.lblLado3.Location = new System.Drawing.Point(337, 411);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(44, 31);
            this.lblLado3.TabIndex = 58;
            this.lblLado3.Text = "20";
            this.lblLado3.Visible = false;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.BackColor = System.Drawing.Color.Transparent;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.ForeColor = System.Drawing.Color.Silver;
            this.lblLado1.Location = new System.Drawing.Point(184, 215);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(44, 31);
            this.lblLado1.TabIndex = 59;
            this.lblLado1.Text = "20";
            this.lblLado1.Visible = false;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.BackColor = System.Drawing.Color.Transparent;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.ForeColor = System.Drawing.Color.Silver;
            this.lblLado2.Location = new System.Drawing.Point(488, 215);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(44, 31);
            this.lblLado2.TabIndex = 60;
            this.lblLado2.Text = "20";
            this.lblLado2.Visible = false;
            // 
            // btnBasetri1
            // 
            this.btnBasetri1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnBasetri1.FlatAppearance.BorderSize = 10;
            this.btnBasetri1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasetri1.Location = new System.Drawing.Point(269, 375);
            this.btnBasetri1.Name = "btnBasetri1";
            this.btnBasetri1.Size = new System.Drawing.Size(10, 36);
            this.btnBasetri1.TabIndex = 61;
            this.btnBasetri1.UseVisualStyleBackColor = true;
            this.btnBasetri1.Visible = false;
            // 
            // btnBasetri2
            // 
            this.btnBasetri2.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnBasetri2.FlatAppearance.BorderSize = 10;
            this.btnBasetri2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasetri2.Location = new System.Drawing.Point(436, 375);
            this.btnBasetri2.Name = "btnBasetri2";
            this.btnBasetri2.Size = new System.Drawing.Size(10, 36);
            this.btnBasetri2.TabIndex = 62;
            this.btnBasetri2.UseVisualStyleBackColor = true;
            this.btnBasetri2.Visible = false;
            // 
            // btnAngulo1
            // 
            this.btnAngulo1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnAngulo1.FlatAppearance.BorderSize = 10;
            this.btnAngulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngulo1.Location = new System.Drawing.Point(219, 363);
            this.btnAngulo1.Name = "btnAngulo1";
            this.btnAngulo1.Size = new System.Drawing.Size(29, 10);
            this.btnAngulo1.TabIndex = 70;
            this.btnAngulo1.UseVisualStyleBackColor = true;
            this.btnAngulo1.Visible = false;
            // 
            // btnAngulo3
            // 
            this.btnAngulo3.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnAngulo3.FlatAppearance.BorderSize = 10;
            this.btnAngulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngulo3.Location = new System.Drawing.Point(470, 363);
            this.btnAngulo3.Name = "btnAngulo3";
            this.btnAngulo3.Size = new System.Drawing.Size(29, 10);
            this.btnAngulo3.TabIndex = 71;
            this.btnAngulo3.UseVisualStyleBackColor = true;
            this.btnAngulo3.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(354, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 29);
            this.button2.TabIndex = 72;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblBasetri1
            // 
            this.lblBasetri1.AutoSize = true;
            this.lblBasetri1.BackColor = System.Drawing.Color.Transparent;
            this.lblBasetri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblBasetri1.ForeColor = System.Drawing.Color.Silver;
            this.lblBasetri1.Location = new System.Drawing.Point(257, 411);
            this.lblBasetri1.Name = "lblBasetri1";
            this.lblBasetri1.Size = new System.Drawing.Size(36, 26);
            this.lblBasetri1.TabIndex = 73;
            this.lblBasetri1.Text = "20";
            this.lblBasetri1.Visible = false;
            // 
            // lblBasetri2
            // 
            this.lblBasetri2.AutoSize = true;
            this.lblBasetri2.BackColor = System.Drawing.Color.Transparent;
            this.lblBasetri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblBasetri2.ForeColor = System.Drawing.Color.Silver;
            this.lblBasetri2.Location = new System.Drawing.Point(423, 411);
            this.lblBasetri2.Name = "lblBasetri2";
            this.lblBasetri2.Size = new System.Drawing.Size(36, 26);
            this.lblBasetri2.TabIndex = 74;
            this.lblBasetri2.Text = "20";
            this.lblBasetri2.Visible = false;
            // 
            // lblAngulo1
            // 
            this.lblAngulo1.AutoSize = true;
            this.lblAngulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblAngulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAngulo1.ForeColor = System.Drawing.Color.Silver;
            this.lblAngulo1.Location = new System.Drawing.Point(264, 323);
            this.lblAngulo1.Name = "lblAngulo1";
            this.lblAngulo1.Size = new System.Drawing.Size(36, 26);
            this.lblAngulo1.TabIndex = 75;
            this.lblAngulo1.Text = "20";
            this.lblAngulo1.Visible = false;
            // 
            // lblAngulo3
            // 
            this.lblAngulo3.AutoSize = true;
            this.lblAngulo3.BackColor = System.Drawing.Color.Transparent;
            this.lblAngulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAngulo3.ForeColor = System.Drawing.Color.Silver;
            this.lblAngulo3.Location = new System.Drawing.Point(423, 323);
            this.lblAngulo3.Name = "lblAngulo3";
            this.lblAngulo3.Size = new System.Drawing.Size(36, 26);
            this.lblAngulo3.TabIndex = 76;
            this.lblAngulo3.Text = "20";
            this.lblAngulo3.Visible = false;
            // 
            // lblAngulo2
            // 
            this.lblAngulo2.AutoSize = true;
            this.lblAngulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblAngulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAngulo2.ForeColor = System.Drawing.Color.Silver;
            this.lblAngulo2.Location = new System.Drawing.Point(340, 120);
            this.lblAngulo2.Name = "lblAngulo2";
            this.lblAngulo2.Size = new System.Drawing.Size(36, 26);
            this.lblAngulo2.TabIndex = 77;
            this.lblAngulo2.Text = "20";
            this.lblAngulo2.Visible = false;
            // 
            // Triângulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lblAngulo2);
            this.Controls.Add(this.lblAngulo3);
            this.Controls.Add(this.lblAngulo1);
            this.Controls.Add(this.lblBasetri2);
            this.Controls.Add(this.lblBasetri1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAngulo3);
            this.Controls.Add(this.btnAngulo1);
            this.Controls.Add(this.btnBasetri2);
            this.Controls.Add(this.btnBasetri1);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.btnBaseMenor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLado1);
            this.Controls.Add(this.pnlOcultar);
            this.Controls.Add(this.pnlExibir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Triângulo";
            this.Size = new System.Drawing.Size(934, 523);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOcultar.ResumeLayout(false);
            this.pnlExibir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExplicacaoTexto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlOcultar;
        private System.Windows.Forms.Button btnOcultarAngulos;
        private System.Windows.Forms.Button btnOcultarDiagonal;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.Button btnExibirAngulos;
        private System.Windows.Forms.Button btnExibirDiagonal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnLado1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBaseMenor;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Button btnBasetri1;
        private System.Windows.Forms.Button btnBasetri2;
        private System.Windows.Forms.Button btnAngulo1;
        private System.Windows.Forms.Button btnAngulo3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBasetri1;
        private System.Windows.Forms.Label lblBasetri2;
        private System.Windows.Forms.Label lblAngulo1;
        private System.Windows.Forms.Label lblAngulo3;
        private System.Windows.Forms.Label lblAngulo2;
    }
}
