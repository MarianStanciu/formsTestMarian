namespace Meniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSubAsociatie = new System.Windows.Forms.Panel();
            this.btnBloc = new System.Windows.Forms.Button();
            this.btnScara = new System.Windows.Forms.Button();
            this.btnApartamente = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubAsociatie.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSideMenu.Controls.Add(this.panelSubAsociatie);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 721);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Asociatie";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSubAsociatie
            // 
            this.panelSubAsociatie.Controls.Add(this.btnApartamente);
            this.panelSubAsociatie.Controls.Add(this.btnScara);
            this.panelSubAsociatie.Controls.Add(this.btnBloc);
            this.panelSubAsociatie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubAsociatie.Location = new System.Drawing.Point(0, 145);
            this.panelSubAsociatie.Name = "panelSubAsociatie";
            this.panelSubAsociatie.Size = new System.Drawing.Size(250, 124);
            this.panelSubAsociatie.TabIndex = 2;
            this.panelSubAsociatie.Visible = false;
            // 
            // btnBloc
            // 
            this.btnBloc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBloc.FlatAppearance.BorderSize = 0;
            this.btnBloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBloc.Location = new System.Drawing.Point(0, 0);
            this.btnBloc.Name = "btnBloc";
            this.btnBloc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBloc.Size = new System.Drawing.Size(250, 40);
            this.btnBloc.TabIndex = 0;
            this.btnBloc.Text = "Bloc(uri)";
            this.btnBloc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBloc.UseVisualStyleBackColor = true;
            this.btnBloc.Click += new System.EventHandler(this.btnBloc_Click);
            // 
            // btnScara
            // 
            this.btnScara.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScara.FlatAppearance.BorderSize = 0;
            this.btnScara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScara.Location = new System.Drawing.Point(0, 40);
            this.btnScara.Name = "btnScara";
            this.btnScara.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnScara.Size = new System.Drawing.Size(250, 40);
            this.btnScara.TabIndex = 1;
            this.btnScara.Text = "Scari";
            this.btnScara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScara.UseVisualStyleBackColor = true;
            this.btnScara.Click += new System.EventHandler(this.btnScara_Click);
            // 
            // btnApartamente
            // 
            this.btnApartamente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApartamente.FlatAppearance.BorderSize = 0;
            this.btnApartamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartamente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApartamente.Location = new System.Drawing.Point(0, 80);
            this.btnApartamente.Name = "btnApartamente";
            this.btnApartamente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnApartamente.Size = new System.Drawing.Size(250, 40);
            this.btnApartamente.TabIndex = 2;
            this.btnApartamente.Text = "Apartamente";
            this.btnApartamente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartamente.UseVisualStyleBackColor = true;
            this.btnApartamente.Click += new System.EventHandler(this.btnApartamente_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(756, 721);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubAsociatie.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubAsociatie;
        private System.Windows.Forms.Button btnApartamente;
        private System.Windows.Forms.Button btnScara;
        private System.Windows.Forms.Button btnBloc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

