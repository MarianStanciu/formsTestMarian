namespace Meniu
{
    partial class scari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proba_transareDataSet = new Meniu.proba_transareDataSet();
            this.probatransareDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proba_transareDataSet1 = new Meniu.proba_transareDataSet1();
            this.articolenewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articole_newTableAdapter = new Meniu.proba_transareDataSet1TableAdapters.articole_newTableAdapter();
            this.codintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInchide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probatransareDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articolenewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codintDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.idtipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articolenewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 674);
            this.dataGridView1.TabIndex = 0;
            // 
            // proba_transareDataSet
            // 
            this.proba_transareDataSet.DataSetName = "proba_transareDataSet";
            this.proba_transareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // probatransareDataSetBindingSource
            // 
            this.probatransareDataSetBindingSource.DataSource = this.proba_transareDataSet;
            this.probatransareDataSetBindingSource.Position = 0;
            // 
            // proba_transareDataSet1
            // 
            this.proba_transareDataSet1.DataSetName = "proba_transareDataSet1";
            this.proba_transareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articolenewBindingSource
            // 
            this.articolenewBindingSource.DataMember = "articole_new";
            this.articolenewBindingSource.DataSource = this.proba_transareDataSet1;
            // 
            // articole_newTableAdapter
            // 
            this.articole_newTableAdapter.ClearBeforeFill = true;
            // 
            // codintDataGridViewTextBoxColumn
            // 
            this.codintDataGridViewTextBoxColumn.DataPropertyName = "cod_int";
            this.codintDataGridViewTextBoxColumn.HeaderText = "cod_int";
            this.codintDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codintDataGridViewTextBoxColumn.Name = "codintDataGridViewTextBoxColumn";
            this.codintDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtipDataGridViewTextBoxColumn
            // 
            this.idtipDataGridViewTextBoxColumn.DataPropertyName = "id_tip";
            this.idtipDataGridViewTextBoxColumn.HeaderText = "id_tip";
            this.idtipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtipDataGridViewTextBoxColumn.Name = "idtipDataGridViewTextBoxColumn";
            this.idtipDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInchide.Location = new System.Drawing.Point(597, 624);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(129, 38);
            this.btnInchide.TabIndex = 1;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // scari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 674);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.dataGridView1);
            this.Name = "scari";
            this.Text = "scari";
            this.Load += new System.EventHandler(this.scari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probatransareDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articolenewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource probatransareDataSetBindingSource;
        private proba_transareDataSet proba_transareDataSet;
        private proba_transareDataSet1 proba_transareDataSet1;
        private System.Windows.Forms.BindingSource articolenewBindingSource;
        private proba_transareDataSet1TableAdapters.articole_newTableAdapter articole_newTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInchide;
    }
}