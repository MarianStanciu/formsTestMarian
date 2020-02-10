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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubAsociatie = new System.Windows.Forms.Panel();
            this.btnApartamente = new System.Windows.Forms.Button();
            this.btnScara = new System.Windows.Forms.Button();
            this.btnBloc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.proba_transareDataSet2 = new Meniu.proba_transareDataSet2();
            this.tIPURIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPURITableAdapter = new Meniu.proba_transareDataSet2TableAdapters.TIPURITableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proba_transareDataSet3 = new Meniu.proba_transareDataSet3();
            this.tIPURIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tIPURITableAdapter1 = new Meniu.proba_transareDataSet3TableAdapters.TIPURITableAdapter();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSubAsociatie.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.panelSideMenu.Controls.Add(this.panelSubAsociatie);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 721);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubAsociatie
            // 
            this.panelSubAsociatie.Controls.Add(this.btnApartamente);
            this.panelSubAsociatie.Controls.Add(this.btnScara);
            this.panelSubAsociatie.Controls.Add(this.btnBloc);
            this.panelSubAsociatie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubAsociatie.Location = new System.Drawing.Point(0, 235);
            this.panelSubAsociatie.Name = "panelSubAsociatie";
            this.panelSubAsociatie.Size = new System.Drawing.Size(250, 124);
            this.panelSubAsociatie.TabIndex = 2;
            this.panelSubAsociatie.Visible = false;
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(0, 190);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Asociatie";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 190);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.dataGridView1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(756, 721);
            this.panelChildForm.TabIndex = 1;
            // 
            // proba_transareDataSet2
            // 
            this.proba_transareDataSet2.DataSetName = "proba_transareDataSet2";
            this.proba_transareDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPURIBindingSource
            // 
            this.tIPURIBindingSource.DataMember = "TIPURI";
            this.tIPURIBindingSource.DataSource = this.proba_transareDataSet2;
            // 
            // tIPURITableAdapter
            // 
            this.tIPURITableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tIPURIBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(55, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(180, 608);
            this.dataGridView1.TabIndex = 0;
            // 
            // proba_transareDataSet3
            // 
            this.proba_transareDataSet3.DataSetName = "proba_transareDataSet3";
            this.proba_transareDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPURIBindingSource1
            // 
            this.tIPURIBindingSource1.DataMember = "TIPURI";
            this.tIPURIBindingSource1.DataSource = this.proba_transareDataSet3;
            // 
            // tIPURITableAdapter1
            // 
            this.tIPURITableAdapter1.ClearBeforeFill = true;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipuri disponibile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubAsociatie.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource1)).EndInit();
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
        private proba_transareDataSet2 proba_transareDataSet2;
        private System.Windows.Forms.BindingSource tIPURIBindingSource;
        private proba_transareDataSet2TableAdapters.TIPURITableAdapter tIPURITableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private proba_transareDataSet3 proba_transareDataSet3;
        private System.Windows.Forms.BindingSource tIPURIBindingSource1;
        private proba_transareDataSet3TableAdapters.TIPURITableAdapter tIPURITableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

