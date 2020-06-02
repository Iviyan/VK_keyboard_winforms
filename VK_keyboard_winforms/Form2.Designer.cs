namespace VK_keyboard_winforms
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBinline = new System.Windows.Forms.CheckBox();
            this.CBonetime = new System.Windows.Forms.CheckBox();
            this.buttonType = new System.Windows.Forms.ComboBox();
            this.view = new System.Windows.Forms.TabControl();
            this.previewTP = new System.Windows.Forms.TabPage();
            this.preview = new System.Windows.Forms.TableLayoutPanel();
            this.PV_addv = new System.Windows.Forms.Button();
            this.jsonview = new System.Windows.Forms.TabPage();
            this.JSONtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.view.SuspendLayout();
            this.previewTP.SuspendLayout();
            this.preview.SuspendLayout();
            this.jsonview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.проектToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.view);
            this.splitContainer1.Size = new System.Drawing.Size(800, 417);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CBinline, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBonetime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonType, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CBinline
            // 
            this.CBinline.AutoSize = true;
            this.CBinline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBinline.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBinline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBinline.Location = new System.Drawing.Point(7, 7);
            this.CBinline.Name = "CBinline";
            this.CBinline.Size = new System.Drawing.Size(316, 24);
            this.CBinline.TabIndex = 0;
            this.CBinline.Text = "inline";
            this.CBinline.UseVisualStyleBackColor = true;
            this.CBinline.CheckedChanged += new System.EventHandler(this.CBinline_CheckedChanged);
            // 
            // CBonetime
            // 
            this.CBonetime.AutoSize = true;
            this.CBonetime.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBonetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBonetime.Location = new System.Drawing.Point(7, 38);
            this.CBonetime.Name = "CBonetime";
            this.CBonetime.Size = new System.Drawing.Size(316, 24);
            this.CBonetime.TabIndex = 1;
            this.CBonetime.Text = "Скрывать клавиатуру сразу";
            this.CBonetime.UseVisualStyleBackColor = true;
            this.CBonetime.CheckedChanged += new System.EventHandler(this.CBonetime_CheckedChanged);
            // 
            // buttonType
            // 
            this.buttonType.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonType.FormattingEnabled = true;
            this.buttonType.Items.AddRange(new object[] {
            "Text",
            "Open Link",
            "Location",
            "VK Pay",
            "VK Apps"});
            this.buttonType.Location = new System.Drawing.Point(7, 69);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(316, 28);
            this.buttonType.TabIndex = 2;
            // 
            // view
            // 
            this.view.Controls.Add(this.previewTP);
            this.view.Controls.Add(this.jsonview);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Multiline = true;
            this.view.Name = "view";
            this.view.SelectedIndex = 0;
            this.view.Size = new System.Drawing.Size(466, 417);
            this.view.TabIndex = 0;
            // 
            // previewTP
            // 
            this.previewTP.Controls.Add(this.preview);
            this.previewTP.Location = new System.Drawing.Point(4, 29);
            this.previewTP.Name = "previewTP";
            this.previewTP.Padding = new System.Windows.Forms.Padding(3);
            this.previewTP.Size = new System.Drawing.Size(458, 384);
            this.previewTP.TabIndex = 0;
            this.previewTP.Text = "preview";
            this.previewTP.UseVisualStyleBackColor = true;
            // 
            // preview
            // 
            this.preview.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.preview.ColumnCount = 1;
            this.preview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.preview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.preview.Controls.Add(this.PV_addv, 0, 0);
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(3, 3);
            this.preview.Name = "preview";
            this.preview.RowCount = 1;
            this.preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 377F));
            this.preview.Size = new System.Drawing.Size(452, 378);
            this.preview.TabIndex = 2;
            // 
            // PV_addv
            // 
            this.PV_addv.AutoSize = true;
            this.PV_addv.BackColor = System.Drawing.Color.LightGray;
            this.PV_addv.Dock = System.Windows.Forms.DockStyle.Top;
            this.PV_addv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PV_addv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PV_addv.Location = new System.Drawing.Point(4, 4);
            this.PV_addv.Name = "PV_addv";
            this.PV_addv.Size = new System.Drawing.Size(450, 30);
            this.PV_addv.TabIndex = 0;
            this.PV_addv.Text = "+";
            this.PV_addv.UseVisualStyleBackColor = false;
            this.PV_addv.Click += new System.EventHandler(this.PV_addv_Click);
            // 
            // jsonview
            // 
            this.jsonview.Controls.Add(this.JSONtb);
            this.jsonview.Location = new System.Drawing.Point(4, 29);
            this.jsonview.Name = "jsonview";
            this.jsonview.Padding = new System.Windows.Forms.Padding(3);
            this.jsonview.Size = new System.Drawing.Size(458, 384);
            this.jsonview.TabIndex = 1;
            this.jsonview.Text = "JSON";
            this.jsonview.UseVisualStyleBackColor = true;
            // 
            // JSONtb
            // 
            this.JSONtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JSONtb.Location = new System.Drawing.Point(3, 3);
            this.JSONtb.Name = "JSONtb";
            this.JSONtb.Size = new System.Drawing.Size(452, 378);
            this.JSONtb.TabIndex = 0;
            this.JSONtb.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Клавиатура";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.view.ResumeLayout(false);
            this.previewTP.ResumeLayout(false);
            this.preview.ResumeLayout(false);
            this.preview.PerformLayout();
            this.jsonview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl view;
        private System.Windows.Forms.TabPage previewTP;
        private System.Windows.Forms.TabPage jsonview;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.CheckBox CBonetime;
        private System.Windows.Forms.CheckBox CBinline;
        private System.Windows.Forms.TableLayoutPanel preview;
        private System.Windows.Forms.ComboBox buttonType;
        private System.Windows.Forms.RichTextBox JSONtb;
        private System.Windows.Forms.Button PV_addv;
    }
}