namespace FormTest_Marian
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
            this.PanelMeniu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnasociatie = new System.Windows.Forms.Button();
            this.PanelMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMeniu
            // 
            this.PanelMeniu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMeniu.Controls.Add(this.btnasociatie);
            this.PanelMeniu.Controls.Add(this.panelLogo);
            this.PanelMeniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMeniu.Location = new System.Drawing.Point(0, 0);
            this.PanelMeniu.Name = "PanelMeniu";
            this.PanelMeniu.Size = new System.Drawing.Size(220, 721);
            this.PanelMeniu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnasociatie
            // 
            this.btnasociatie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnasociatie.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnasociatie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnasociatie.FlatAppearance.BorderSize = 0;
            this.btnasociatie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasociatie.ForeColor = System.Drawing.Color.MintCream;
            this.btnasociatie.Image = ((System.Drawing.Image)(resources.GetObject("btnasociatie.Image")));
            this.btnasociatie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasociatie.Location = new System.Drawing.Point(0, 80);
            this.btnasociatie.Name = "btnasociatie";
            this.btnasociatie.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.btnasociatie.Size = new System.Drawing.Size(220, 60);
            this.btnasociatie.TabIndex = 1;
            this.btnasociatie.Text = "ASOCIATIE";
            this.btnasociatie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.PanelMeniu);
            this.Name = "Form1";
            this.Text = "MeniuPrincipal";
            this.PanelMeniu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMeniu;
        private System.Windows.Forms.Button btnasociatie;
        private System.Windows.Forms.Panel panelLogo;
    }
}

