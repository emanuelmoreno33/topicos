namespace Proyecto
{
    partial class Froma
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
            this.components = new System.ComponentModel.Container();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.PicMIn = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PanelMV = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PanelP = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.PanelMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.PanelBar.Controls.Add(this.PicMIn);
            this.PanelBar.Controls.Add(this.PicClose);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(1007, 30);
            this.PanelBar.TabIndex = 1;
            this.PanelBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.PanelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // PicMIn
            // 
            this.PicMIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMIn.Image = global::Proyecto.Properties.Resources.minus___1515_;
            this.PicMIn.Location = new System.Drawing.Point(948, 2);
            this.PicMIn.Name = "PicMIn";
            this.PicMIn.Size = new System.Drawing.Size(25, 25);
            this.PicMIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMIn.TabIndex = 2;
            this.PicMIn.TabStop = false;
            this.PicMIn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PicClose
            // 
            this.PicClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = global::Proyecto.Properties.Resources.close___1511_;
            this.PicClose.Location = new System.Drawing.Point(979, 2);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 25);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 0;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelMV
            // 
            this.PanelMV.Controls.Add(this.panel6);
            this.PanelMV.Controls.Add(this.button1);
            this.PanelMV.Controls.Add(this.panel5);
            this.PanelMV.Controls.Add(this.btnAgregar);
            this.PanelMV.Controls.Add(this.panel4);
            this.PanelMV.Controls.Add(this.bntBuscar);
            this.PanelMV.Controls.Add(this.panel3);
            this.PanelMV.Controls.Add(this.btnEditar);
            this.PanelMV.Controls.Add(this.panel2);
            this.PanelMV.Controls.Add(this.btnGenerar);
            this.PanelMV.Controls.Add(this.panel1);
            this.PanelMV.Controls.Add(this.btnIniciar);
            this.PanelMV.Controls.Add(this.PicLogo);
            this.PanelMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMV.Location = new System.Drawing.Point(0, 30);
            this.PanelMV.Name = "PanelMV";
            this.PanelMV.Size = new System.Drawing.Size(111, 543);
            this.PanelMV.TabIndex = 2;
            this.PanelMV.Visible = false;
            this.PanelMV.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMV_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(0, 437);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 56);
            this.panel6.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Proyecto.Properties.Resources.information___1535_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Info";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(0, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 56);
            this.panel5.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = global::Proyecto.Properties.Resources.edit___1479_;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(9, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 56);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(0, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 56);
            this.panel4.TabIndex = 5;
            // 
            // bntBuscar
            // 
            this.bntBuscar.BackColor = System.Drawing.Color.Transparent;
            this.bntBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.bntBuscar.FlatAppearance.BorderSize = 0;
            this.bntBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.bntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.bntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntBuscar.Image = global::Proyecto.Properties.Resources.router_middle___1114_;
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(9, 313);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(102, 56);
            this.bntBuscar.TabIndex = 6;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = false;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(0, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 56);
            this.panel3.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Image = global::Proyecto.Properties.Resources.edit___1479_;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(9, 251);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 56);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 56);
            this.panel2.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Image = global::Proyecto.Properties.Resources.fileboard___1801_;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(9, 189);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(102, 56);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Image = global::Proyecto.Properties.Resources.home___1391_;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(9, 127);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 56);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Inicio";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Proyecto.Properties.Resources.logo;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(111, 121);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PanelP
            // 
            this.PanelP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.PanelP.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelP.Location = new System.Drawing.Point(111, 30);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(896, 543);
            this.PanelP.TabIndex = 3;
            this.PanelP.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelP_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Froma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1007, 573);
            this.Controls.Add(this.PanelP);
            this.Controls.Add(this.PanelMV);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Froma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicMIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.PanelMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Panel PanelMV;
        private System.Windows.Forms.Panel PanelP;
        private System.Windows.Forms.PictureBox PicMIn;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}

