namespace Meniu
{
    partial class FormBlocuri
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
            this.tabelUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_UtilizatoriTableAdapter = new Meniu.proba_transareDataSetTableAdapters.Tabel_UtilizatoriTableAdapter();
            this.utilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInchide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelUtilizatoriBindingSource;
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
            // tabelUtilizatoriBindingSource
            // 
            this.tabelUtilizatoriBindingSource.DataMember = "Tabel_Utilizatori";
            this.tabelUtilizatoriBindingSource.DataSource = this.proba_transareDataSet;
            // 
            // tabel_UtilizatoriTableAdapter
            // 
            this.tabel_UtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatorDataGridViewTextBoxColumn
            // 
            this.utilizatorDataGridViewTextBoxColumn.DataPropertyName = "utilizator";
            this.utilizatorDataGridViewTextBoxColumn.HeaderText = "utilizator";
            this.utilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilizatorDataGridViewTextBoxColumn.Name = "utilizatorDataGridViewTextBoxColumn";
            this.utilizatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Width = 125;
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
            // FormBlocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 674);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBlocuri";
            this.Text = "Blocuri";
            this.Load += new System.EventHandler(this.FormBlocuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private proba_transareDataSet proba_transareDataSet;
        private System.Windows.Forms.BindingSource tabelUtilizatoriBindingSource;
        private proba_transareDataSetTableAdapters.Tabel_UtilizatoriTableAdapter tabel_UtilizatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInchide;
    }
}