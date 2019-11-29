namespace Generator
{
    partial class FormGenerator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerator));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxTabele = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBoxKolumny = new System.Windows.Forms.ListBox();
            this.listBoxWybrane = new System.Windows.Forms.ListBox();
            this.ExportBTN = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.connectionStringTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBoxJoin = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawKluczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 396);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(15, 20);
            this.statusLabel.Text = "-";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxTabele);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 396);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxTabele
            // 
            this.listBoxTabele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTabele.Enabled = false;
            this.listBoxTabele.FormattingEnabled = true;
            this.listBoxTabele.Location = new System.Drawing.Point(0, 0);
            this.listBoxTabele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTabele.Name = "listBoxTabele";
            this.listBoxTabele.Size = new System.Drawing.Size(260, 396);
            this.listBoxTabele.TabIndex = 0;
            this.listBoxTabele.SelectedIndexChanged += new System.EventHandler(this.listBoxTabele_SelectedIndexChanged);
            this.listBoxTabele.DoubleClick += new System.EventHandler(this.listBoxTabele_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBoxKolumny);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.ExportBTN);
            this.splitContainer2.Size = new System.Drawing.Size(536, 396);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBoxKolumny
            // 
            this.listBoxKolumny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKolumny.Enabled = false;
            this.listBoxKolumny.FormattingEnabled = true;
            this.listBoxKolumny.Location = new System.Drawing.Point(0, 0);
            this.listBoxKolumny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxKolumny.Name = "listBoxKolumny";
            this.listBoxKolumny.Size = new System.Drawing.Size(194, 396);
            this.listBoxKolumny.TabIndex = 0;
            this.listBoxKolumny.SelectedIndexChanged += new System.EventHandler(this.listBoxKolumny_SelectedIndexChanged);
            this.listBoxKolumny.DoubleClick += new System.EventHandler(this.listBoxKolumny_DoubleClick);
            // 
            // listBoxWybrane
            // 
            this.listBoxWybrane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxWybrane.Enabled = false;
            this.listBoxWybrane.FormattingEnabled = true;
            this.listBoxWybrane.Location = new System.Drawing.Point(0, 0);
            this.listBoxWybrane.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxWybrane.Name = "listBoxWybrane";
            this.listBoxWybrane.Size = new System.Drawing.Size(338, 280);
            this.listBoxWybrane.TabIndex = 1;
            this.listBoxWybrane.Click += new System.EventHandler(this.listBoxWybrane_MouseClick);
            this.listBoxWybrane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWybrane_MouseClick);
            this.listBoxWybrane.SelectedIndexChanged += new System.EventHandler(this.listBoxWybrane_SelectedIndexChanged);
            this.listBoxWybrane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWybrane_MouseDoubleClick);
            // 
            // ExportBTN
            // 
            this.ExportBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportBTN.Enabled = false;
            this.ExportBTN.Location = new System.Drawing.Point(0, 350);
            this.ExportBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ExportBTN.Name = "ExportBTN";
            this.ExportBTN.Size = new System.Drawing.Size(338, 46);
            this.ExportBTN.TabIndex = 0;
            this.ExportBTN.Text = "Eksportuj EXE";
            this.ExportBTN.UseVisualStyleBackColor = true;
            this.ExportBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.connectionStringTextBox,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 28);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(130, 25);
            this.toolStripLabel1.Text = "Connection String:";
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.DropDownHeight = 200;
            this.connectionStringTextBox.DropDownWidth = 300;
            this.connectionStringTextBox.IntegralHeight = false;
            this.connectionStringTextBox.Items.AddRange(new object[] {
            "Server=localhost;Database=master;Trusted_Connection=True",
            "Server=localhost;Database=MojaBaza;Trusted_Connection=True",
            "Server=NT-27\\WWSI2014; Database=PaniKsiegowa; User ID=pszczepanski;Password=<****" +
                "*****>",
            "Server=nt-27.wwsi.edu.pl,1601; Database=PaniKsiegowa; User ID=pszczepanski;Passwo" +
                "rd=<*********>"});
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(500, 28);
            this.connectionStringTextBox.Text = "Server=nt-27.wwsi.edu.pl,1601; Database=PaniKsiegowa; User ID=pszczepanski;Passwo" +
    "rd=<*********>";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 25);
            this.toolStripButton1.Text = "Połącz";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBoxWybrane);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listBoxJoin);
            this.splitContainer3.Size = new System.Drawing.Size(338, 350);
            this.splitContainer3.SplitterDistance = 280;
            this.splitContainer3.TabIndex = 2;
            // 
            // listBoxJoin
            // 
            this.listBoxJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxJoin.FormattingEnabled = true;
            this.listBoxJoin.Location = new System.Drawing.Point(0, 0);
            this.listBoxJoin.Name = "listBoxJoin";
            this.listBoxJoin.Size = new System.Drawing.Size(338, 66);
            this.listBoxJoin.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregujToolStripMenuItem,
            this.ustawKluczToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // agregujToolStripMenuItem
            // 
            this.agregujToolStripMenuItem.Name = "agregujToolStripMenuItem";
            this.agregujToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.agregujToolStripMenuItem.Text = "Agreguj";
            this.agregujToolStripMenuItem.Click += new System.EventHandler(this.agregujToolStripMenuItem_Click);
            // 
            // ustawKluczToolStripMenuItem
            // 
            this.ustawKluczToolStripMenuItem.Name = "ustawKluczToolStripMenuItem";
            this.ustawKluczToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ustawKluczToolStripMenuItem.Text = "Ustaw Klucz";
            this.ustawKluczToolStripMenuItem.Click += new System.EventHandler(this.ustawKluczToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormGenerator";
            this.Text = "Generator";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxTabele;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBoxKolumny;
        private System.Windows.Forms.Button ExportBTN;
        private System.Windows.Forms.ListBox listBoxWybrane;
        private System.Windows.Forms.ToolStripComboBox connectionStringTextBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBoxJoin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawKluczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}

