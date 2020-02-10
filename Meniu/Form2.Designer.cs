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
            this.utilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proba_transareDataSet = new Meniu.proba_transareDataSet();
            this.tabel_UtilizatoriTableAdapter = new Meniu.proba_transareDataSetTableAdapters.Tabel_UtilizatoriTableAdapter();
            this.btnInchide = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelUtilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 285);
            this.dataGridView1.TabIndex = 0;
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
            // tabelUtilizatoriBindingSource
            // 
            this.tabelUtilizatoriBindingSource.DataMember = "Tabel_Utilizatori";
            this.tabelUtilizatoriBindingSource.DataSource = this.proba_transareDataSet;
            // 
            // proba_transareDataSet
            // 
            this.proba_transareDataSet.DataSetName = "proba_transareDataSet";
            this.proba_transareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_UtilizatoriTableAdapter
            // 
            this.tabel_UtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInchide.Location = new System.Drawing.Point(611, 12);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(129, 38);
            this.btnInchide.TabIndex = 1;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tabelUtilizatoriBindingSource, "parola", true));
            this.tabControl1.Location = new System.Drawing.Point(0, 291);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 277);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(548, 150);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormBlocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 674);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBlocuri";
            this.Text = "Blocuri";
            this.Load += new System.EventHandler(this.FormBlocuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}