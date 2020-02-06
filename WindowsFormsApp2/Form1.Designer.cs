namespace WindowsFormsApp2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Apartamente");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Scara1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Scara2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Scara3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bloc1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bloc2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Asociatie", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEFINIREASOCIATIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeAsociatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteCheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPOARTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUTORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intrebariFrecventeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.edidareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Bloc2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Bloc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGRAMToolStripMenuItem,
            this.dEFINIREASOCIATIEToolStripMenuItem,
            this.cheltuieliToolStripMenuItem,
            this.rAPOARTEToolStripMenuItem,
            this.aJUTORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROGRAMToolStripMenuItem
            // 
            this.pROGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideFisierToolStripMenuItem,
            this.salveazaToolStripMenuItem,
            this.salveazaCaToolStripMenuItem});
            this.pROGRAMToolStripMenuItem.Name = "pROGRAMToolStripMenuItem";
            this.pROGRAMToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.pROGRAMToolStripMenuItem.Text = "PROGRAM";
            // 
            // deschideFisierToolStripMenuItem
            // 
            this.deschideFisierToolStripMenuItem.Name = "deschideFisierToolStripMenuItem";
            this.deschideFisierToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.deschideFisierToolStripMenuItem.Text = "Deschide fisier";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            // 
            // salveazaCaToolStripMenuItem
            // 
            this.salveazaCaToolStripMenuItem.Name = "salveazaCaToolStripMenuItem";
            this.salveazaCaToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.salveazaCaToolStripMenuItem.Text = "Salveaza ca";
            // 
            // dEFINIREASOCIATIEToolStripMenuItem
            // 
            this.dEFINIREASOCIATIEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeAsociatieToolStripMenuItem,
            this.componentaToolStripMenuItem,
            this.adresaToolStripMenuItem,
            this.proprietariToolStripMenuItem});
            this.dEFINIREASOCIATIEToolStripMenuItem.Name = "dEFINIREASOCIATIEToolStripMenuItem";
            this.dEFINIREASOCIATIEToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.dEFINIREASOCIATIEToolStripMenuItem.Text = "DEFINIRE ASOCIATIE";
            // 
            // numeAsociatieToolStripMenuItem
            // 
            this.numeAsociatieToolStripMenuItem.Name = "numeAsociatieToolStripMenuItem";
            this.numeAsociatieToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.numeAsociatieToolStripMenuItem.Text = "Nume Asociatie ";
            // 
            // componentaToolStripMenuItem
            // 
            this.componentaToolStripMenuItem.Name = "componentaToolStripMenuItem";
            this.componentaToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.componentaToolStripMenuItem.Text = "Componenta";
            // 
            // adresaToolStripMenuItem
            // 
            this.adresaToolStripMenuItem.Name = "adresaToolStripMenuItem";
            this.adresaToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.adresaToolStripMenuItem.Text = "Adresa";
            // 
            // proprietariToolStripMenuItem
            // 
            this.proprietariToolStripMenuItem.Name = "proprietariToolStripMenuItem";
            this.proprietariToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.proprietariToolStripMenuItem.Text = "Proprietari";
            // 
            // cheltuieliToolStripMenuItem
            // 
            this.cheltuieliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturiToolStripMenuItem,
            this.alteCheltuieliToolStripMenuItem});
            this.cheltuieliToolStripMenuItem.Name = "cheltuieliToolStripMenuItem";
            this.cheltuieliToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.cheltuieliToolStripMenuItem.Text = "CHELTUIELI";
            // 
            // facturiToolStripMenuItem
            // 
            this.facturiToolStripMenuItem.Name = "facturiToolStripMenuItem";
            this.facturiToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.facturiToolStripMenuItem.Text = "Facturi";
            // 
            // alteCheltuieliToolStripMenuItem
            // 
            this.alteCheltuieliToolStripMenuItem.Name = "alteCheltuieliToolStripMenuItem";
            this.alteCheltuieliToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.alteCheltuieliToolStripMenuItem.Text = "Alte cheltuieli";
            // 
            // rAPOARTEToolStripMenuItem
            // 
            this.rAPOARTEToolStripMenuItem.Name = "rAPOARTEToolStripMenuItem";
            this.rAPOARTEToolStripMenuItem.Size = new System.Drawing.Size(135, 34);
            this.rAPOARTEToolStripMenuItem.Text = "RAPOARTE";
            // 
            // aJUTORToolStripMenuItem
            // 
            this.aJUTORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intrebariFrecventeToolStripMenuItem});
            this.aJUTORToolStripMenuItem.Name = "aJUTORToolStripMenuItem";
            this.aJUTORToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.aJUTORToolStripMenuItem.Text = "AJUTOR";
            // 
            // intrebariFrecventeToolStripMenuItem
            // 
            this.intrebariFrecventeToolStripMenuItem.Name = "intrebariFrecventeToolStripMenuItem";
            this.intrebariFrecventeToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.intrebariFrecventeToolStripMenuItem.Text = "Intrebari frecvente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1312, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 30);
            this.toolStripLabel1.Text = "comanda 1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edidareToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 30);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // edidareToolStripMenuItem
            // 
            this.edidareToolStripMenuItem.Name = "edidareToolStripMenuItem";
            this.edidareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edidareToolStripMenuItem.Text = "Editare";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 30);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(75, 30);
            this.toolStripLabel2.Text = "Comanda 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 33);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 81);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Apartamente";
            treeNode2.Name = "Scara1";
            treeNode2.Text = "Scara1";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Scara2";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Scara3";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Bloc1";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Bloc2";
            treeNode7.Name = "Asociatie";
            treeNode7.Text = "Asociatie";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(121, 565);
            this.treeView1.TabIndex = 2;
            // 
            // Bloc2
            // 
            this.Bloc2.Controls.Add(this.tabPage1);
            this.Bloc2.Controls.Add(this.tabPage2);
            this.Bloc2.Controls.Add(this.tabPage3);
            this.Bloc2.Controls.Add(this.tabPage4);
            this.Bloc2.Location = new System.Drawing.Point(127, 81);
            this.Bloc2.Name = "Bloc2";
            this.Bloc2.SelectedIndex = 0;
            this.Bloc2.Size = new System.Drawing.Size(1050, 554);
            this.Bloc2.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bloc1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bloc2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1042, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 764);
            this.Controls.Add(this.Bloc2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Bloc2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEFINIREASOCIATIEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeAsociatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheltuieliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteCheltuieliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPOARTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUTORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrebariFrecventeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem edidareToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl Bloc2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

