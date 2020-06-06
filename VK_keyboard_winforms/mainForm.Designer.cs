namespace VK_keyboard_winforms
{
    partial class mainForm
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
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_doc = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBinline = new System.Windows.Forms.CheckBox();
            this.CBonetime = new System.Windows.Forms.CheckBox();
            this.Spanel = new System.Windows.Forms.Panel();
            this.Bdel = new System.Windows.Forms.Button();
            this.Ppayload = new System.Windows.Forms.GroupBox();
            this.TBpayload = new System.Windows.Forms.TextBox();
            this.Powner_id = new System.Windows.Forms.GroupBox();
            this.TBowner_id = new System.Windows.Forms.TextBox();
            this.Papp_id = new System.Windows.Forms.GroupBox();
            this.TBapp_id = new System.Windows.Forms.TextBox();
            this.Phash = new System.Windows.Forms.GroupBox();
            this.TBhash = new System.Windows.Forms.TextBox();
            this.Plink = new System.Windows.Forms.GroupBox();
            this.TBlink = new System.Windows.Forms.TextBox();
            this.Plabel = new System.Windows.Forms.GroupBox();
            this.TBlabel = new System.Windows.Forms.TextBox();
            this.Pcolor = new System.Windows.Forms.GroupBox();
            this.Ccolor = new System.Windows.Forms.TableLayoutPanel();
            this.CBnegative = new System.Windows.Forms.Button();
            this.CBpositive = new System.Windows.Forms.Button();
            this.CBprimary = new System.Windows.Forms.Button();
            this.CBsecondary = new System.Windows.Forms.Button();
            this.Pbtype = new System.Windows.Forms.GroupBox();
            this.CBbtype = new System.Windows.Forms.ComboBox();
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
            this.Spanel.SuspendLayout();
            this.Ppayload.SuspendLayout();
            this.Powner_id.SuspendLayout();
            this.Papp_id.SuspendLayout();
            this.Phash.SuspendLayout();
            this.Plink.SuspendLayout();
            this.Plabel.SuspendLayout();
            this.Pcolor.SuspendLayout();
            this.Ccolor.SuspendLayout();
            this.Pbtype.SuspendLayout();
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
            this.menu_save,
            this.menu_open,
            this.menu_new,
            this.menu_doc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(119, 29);
            this.menu_save.Text = "Сохранить";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(99, 29);
            this.menu_open.Text = "Открыть";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(95, 29);
            this.menu_new.Text = "Создать";
            // 
            // menu_doc
            // 
            this.menu_doc.Name = "menu_doc";
            this.menu_doc.ShortcutKeyDisplayString = "";
            this.menu_doc.Size = new System.Drawing.Size(141, 29);
            this.menu_doc.Text = "Документаця";
            this.menu_doc.Click += new System.EventHandler(this.документацяToolStripMenuItem_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 517);
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
            this.tableLayoutPanel1.Controls.Add(this.Spanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 517);
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
            // Spanel
            // 
            this.Spanel.Controls.Add(this.Bdel);
            this.Spanel.Controls.Add(this.Ppayload);
            this.Spanel.Controls.Add(this.Powner_id);
            this.Spanel.Controls.Add(this.Papp_id);
            this.Spanel.Controls.Add(this.Phash);
            this.Spanel.Controls.Add(this.Plink);
            this.Spanel.Controls.Add(this.Plabel);
            this.Spanel.Controls.Add(this.Pcolor);
            this.Spanel.Controls.Add(this.Pbtype);
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spanel.Location = new System.Drawing.Point(7, 70);
            this.Spanel.Name = "Spanel";
            this.Spanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Spanel.Size = new System.Drawing.Size(316, 440);
            this.Spanel.TabIndex = 3;
            this.Spanel.Visible = false;
            // 
            // Bdel
            // 
            this.Bdel.AutoSize = true;
            this.Bdel.BackColor = System.Drawing.Color.IndianRed;
            this.Bdel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bdel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Bdel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Bdel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Bdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bdel.ForeColor = System.Drawing.Color.White;
            this.Bdel.Location = new System.Drawing.Point(0, 403);
            this.Bdel.Name = "Bdel";
            this.Bdel.Size = new System.Drawing.Size(316, 37);
            this.Bdel.TabIndex = 10;
            this.Bdel.Text = "Удалить";
            this.Bdel.UseVisualStyleBackColor = false;
            this.Bdel.Click += new System.EventHandler(this.Bdel_Click);
            // 
            // Ppayload
            // 
            this.Ppayload.AutoSize = true;
            this.Ppayload.Controls.Add(this.TBpayload);
            this.Ppayload.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ppayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ppayload.Location = new System.Drawing.Point(0, 393);
            this.Ppayload.Name = "Ppayload";
            this.Ppayload.Size = new System.Drawing.Size(316, 51);
            this.Ppayload.TabIndex = 9;
            this.Ppayload.TabStop = false;
            this.Ppayload.Text = "payload";
            // 
            // TBpayload
            // 
            this.TBpayload.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBpayload.Location = new System.Drawing.Point(3, 22);
            this.TBpayload.Name = "TBpayload";
            this.TBpayload.Size = new System.Drawing.Size(310, 26);
            this.TBpayload.TabIndex = 0;
            this.TBpayload.TextChanged += new System.EventHandler(this.TBpayload_TextChanged);
            // 
            // Powner_id
            // 
            this.Powner_id.AutoSize = true;
            this.Powner_id.Controls.Add(this.TBowner_id);
            this.Powner_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.Powner_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Powner_id.Location = new System.Drawing.Point(0, 342);
            this.Powner_id.Name = "Powner_id";
            this.Powner_id.Size = new System.Drawing.Size(316, 51);
            this.Powner_id.TabIndex = 8;
            this.Powner_id.TabStop = false;
            this.Powner_id.Text = "owner_id (сообщество) - число";
            this.Powner_id.Visible = false;
            // 
            // TBowner_id
            // 
            this.TBowner_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBowner_id.Location = new System.Drawing.Point(3, 22);
            this.TBowner_id.Name = "TBowner_id";
            this.TBowner_id.Size = new System.Drawing.Size(310, 26);
            this.TBowner_id.TabIndex = 0;
            this.TBowner_id.TextChanged += new System.EventHandler(this.TBowner_id_TextChanged);
            // 
            // Papp_id
            // 
            this.Papp_id.AutoSize = true;
            this.Papp_id.Controls.Add(this.TBapp_id);
            this.Papp_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.Papp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Papp_id.Location = new System.Drawing.Point(0, 291);
            this.Papp_id.Name = "Papp_id";
            this.Papp_id.Size = new System.Drawing.Size(316, 51);
            this.Papp_id.TabIndex = 7;
            this.Papp_id.TabStop = false;
            this.Papp_id.Text = "app_id (Vk Apps) - число";
            this.Papp_id.Visible = false;
            // 
            // TBapp_id
            // 
            this.TBapp_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBapp_id.Location = new System.Drawing.Point(3, 22);
            this.TBapp_id.Name = "TBapp_id";
            this.TBapp_id.Size = new System.Drawing.Size(310, 26);
            this.TBapp_id.TabIndex = 0;
            this.TBapp_id.TextChanged += new System.EventHandler(this.TBapp_id_TextChanged);
            // 
            // Phash
            // 
            this.Phash.AutoSize = true;
            this.Phash.Controls.Add(this.TBhash);
            this.Phash.Dock = System.Windows.Forms.DockStyle.Top;
            this.Phash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phash.Location = new System.Drawing.Point(0, 240);
            this.Phash.Name = "Phash";
            this.Phash.Size = new System.Drawing.Size(316, 51);
            this.Phash.TabIndex = 6;
            this.Phash.TabStop = false;
            this.Phash.Text = "hash";
            this.Phash.Visible = false;
            // 
            // TBhash
            // 
            this.TBhash.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBhash.Location = new System.Drawing.Point(3, 22);
            this.TBhash.Name = "TBhash";
            this.TBhash.Size = new System.Drawing.Size(310, 26);
            this.TBhash.TabIndex = 0;
            this.TBhash.TextChanged += new System.EventHandler(this.TBhash_TextChanged);
            // 
            // Plink
            // 
            this.Plink.AutoSize = true;
            this.Plink.Controls.Add(this.TBlink);
            this.Plink.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plink.Location = new System.Drawing.Point(0, 189);
            this.Plink.Name = "Plink";
            this.Plink.Size = new System.Drawing.Size(316, 51);
            this.Plink.TabIndex = 5;
            this.Plink.TabStop = false;
            this.Plink.Text = "link / Ссылка / URL";
            this.Plink.Visible = false;
            // 
            // TBlink
            // 
            this.TBlink.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBlink.Location = new System.Drawing.Point(3, 22);
            this.TBlink.Name = "TBlink";
            this.TBlink.Size = new System.Drawing.Size(310, 26);
            this.TBlink.TabIndex = 0;
            this.TBlink.TextChanged += new System.EventHandler(this.TBlink_TextChanged);
            // 
            // Plabel
            // 
            this.Plabel.AutoSize = true;
            this.Plabel.Controls.Add(this.TBlabel);
            this.Plabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plabel.Location = new System.Drawing.Point(0, 138);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(316, 51);
            this.Plabel.TabIndex = 4;
            this.Plabel.TabStop = false;
            this.Plabel.Text = "label / Надпись";
            this.Plabel.Visible = false;
            // 
            // TBlabel
            // 
            this.TBlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBlabel.Location = new System.Drawing.Point(3, 22);
            this.TBlabel.Name = "TBlabel";
            this.TBlabel.Size = new System.Drawing.Size(310, 26);
            this.TBlabel.TabIndex = 0;
            this.TBlabel.TextChanged += new System.EventHandler(this.TBlabel_TextChanged);
            // 
            // Pcolor
            // 
            this.Pcolor.Controls.Add(this.Ccolor);
            this.Pcolor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pcolor.Location = new System.Drawing.Point(0, 63);
            this.Pcolor.Name = "Pcolor";
            this.Pcolor.Size = new System.Drawing.Size(316, 75);
            this.Pcolor.TabIndex = 5;
            this.Pcolor.TabStop = false;
            this.Pcolor.Text = "color / цвет кнопки";
            // 
            // Ccolor
            // 
            this.Ccolor.ColumnCount = 4;
            this.Ccolor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Ccolor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Ccolor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Ccolor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Ccolor.Controls.Add(this.CBnegative, 0, 0);
            this.Ccolor.Controls.Add(this.CBpositive, 0, 0);
            this.Ccolor.Controls.Add(this.CBprimary, 0, 0);
            this.Ccolor.Controls.Add(this.CBsecondary, 0, 0);
            this.Ccolor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ccolor.Location = new System.Drawing.Point(3, 22);
            this.Ccolor.Name = "Ccolor";
            this.Ccolor.RowCount = 1;
            this.Ccolor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Ccolor.Size = new System.Drawing.Size(310, 50);
            this.Ccolor.TabIndex = 3;
            // 
            // CBnegative
            // 
            this.CBnegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CBnegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBnegative.Location = new System.Drawing.Point(157, 3);
            this.CBnegative.Name = "CBnegative";
            this.CBnegative.Size = new System.Drawing.Size(71, 44);
            this.CBnegative.TabIndex = 3;
            this.CBnegative.UseVisualStyleBackColor = false;
            this.CBnegative.Click += new System.EventHandler(this.CB_Click);
            // 
            // CBpositive
            // 
            this.CBpositive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(75)))));
            this.CBpositive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBpositive.Location = new System.Drawing.Point(234, 3);
            this.CBpositive.Name = "CBpositive";
            this.CBpositive.Size = new System.Drawing.Size(73, 44);
            this.CBpositive.TabIndex = 2;
            this.CBpositive.UseVisualStyleBackColor = false;
            this.CBpositive.Click += new System.EventHandler(this.CB_Click);
            // 
            // CBprimary
            // 
            this.CBprimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.CBprimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBprimary.Location = new System.Drawing.Point(3, 3);
            this.CBprimary.Name = "CBprimary";
            this.CBprimary.Size = new System.Drawing.Size(71, 44);
            this.CBprimary.TabIndex = 1;
            this.CBprimary.UseVisualStyleBackColor = false;
            this.CBprimary.Click += new System.EventHandler(this.CB_Click);
            // 
            // CBsecondary
            // 
            this.CBsecondary.BackColor = System.Drawing.Color.White;
            this.CBsecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBsecondary.Location = new System.Drawing.Point(80, 3);
            this.CBsecondary.Name = "CBsecondary";
            this.CBsecondary.Size = new System.Drawing.Size(71, 44);
            this.CBsecondary.TabIndex = 0;
            this.CBsecondary.UseVisualStyleBackColor = false;
            this.CBsecondary.Click += new System.EventHandler(this.CB_Click);
            // 
            // Pbtype
            // 
            this.Pbtype.AutoSize = true;
            this.Pbtype.Controls.Add(this.CBbtype);
            this.Pbtype.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pbtype.Location = new System.Drawing.Point(0, 10);
            this.Pbtype.Name = "Pbtype";
            this.Pbtype.Size = new System.Drawing.Size(316, 53);
            this.Pbtype.TabIndex = 5;
            this.Pbtype.TabStop = false;
            this.Pbtype.Text = "type / Тип кнопки";
            // 
            // CBbtype
            // 
            this.CBbtype.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBbtype.FormattingEnabled = true;
            this.CBbtype.Items.AddRange(new object[] {
            "Text",
            "Open Link",
            "Location",
            "VK Pay",
            "VK Apps"});
            this.CBbtype.Location = new System.Drawing.Point(3, 22);
            this.CBbtype.Name = "CBbtype";
            this.CBbtype.Size = new System.Drawing.Size(310, 28);
            this.CBbtype.TabIndex = 2;
            this.CBbtype.SelectionChangeCommitted += new System.EventHandler(this.CBbtype_SelectionChangeCommitted);
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
            this.view.Size = new System.Drawing.Size(466, 517);
            this.view.TabIndex = 0;
            // 
            // previewTP
            // 
            this.previewTP.Controls.Add(this.preview);
            this.previewTP.Location = new System.Drawing.Point(4, 29);
            this.previewTP.Name = "previewTP";
            this.previewTP.Padding = new System.Windows.Forms.Padding(3);
            this.previewTP.Size = new System.Drawing.Size(458, 484);
            this.previewTP.TabIndex = 0;
            this.previewTP.Text = "preview";
            this.previewTP.UseVisualStyleBackColor = true;
            // 
            // preview
            // 
            this.preview.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.preview.ColumnCount = 1;
            this.preview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.preview.Controls.Add(this.PV_addv, 0, 0);
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(3, 3);
            this.preview.Name = "preview";
            this.preview.RowCount = 1;
            this.preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.preview.Size = new System.Drawing.Size(452, 478);
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
            this.jsonview.Size = new System.Drawing.Size(458, 484);
            this.jsonview.TabIndex = 1;
            this.jsonview.Text = "JSON";
            this.jsonview.UseVisualStyleBackColor = true;
            // 
            // JSONtb
            // 
            this.JSONtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JSONtb.Location = new System.Drawing.Point(3, 3);
            this.JSONtb.Name = "JSONtb";
            this.JSONtb.Size = new System.Drawing.Size(452, 478);
            this.JSONtb.TabIndex = 0;
            this.JSONtb.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Клавиатура";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Spanel.ResumeLayout(false);
            this.Spanel.PerformLayout();
            this.Ppayload.ResumeLayout(false);
            this.Ppayload.PerformLayout();
            this.Powner_id.ResumeLayout(false);
            this.Powner_id.PerformLayout();
            this.Papp_id.ResumeLayout(false);
            this.Papp_id.PerformLayout();
            this.Phash.ResumeLayout(false);
            this.Phash.PerformLayout();
            this.Plink.ResumeLayout(false);
            this.Plink.PerformLayout();
            this.Plabel.ResumeLayout(false);
            this.Plabel.PerformLayout();
            this.Pcolor.ResumeLayout(false);
            this.Ccolor.ResumeLayout(false);
            this.Pbtype.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl view;
        private System.Windows.Forms.TabPage previewTP;
        private System.Windows.Forms.TabPage jsonview;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.CheckBox CBonetime;
        private System.Windows.Forms.CheckBox CBinline;
        private System.Windows.Forms.TableLayoutPanel preview;
        private System.Windows.Forms.ComboBox CBbtype;
        private System.Windows.Forms.RichTextBox JSONtb;
        private System.Windows.Forms.Button PV_addv;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.TableLayoutPanel Ccolor;
        private System.Windows.Forms.Button CBsecondary;
        private System.Windows.Forms.Button CBnegative;
        private System.Windows.Forms.Button CBpositive;
        private System.Windows.Forms.Button CBprimary;
        private System.Windows.Forms.GroupBox Plabel;
        private System.Windows.Forms.TextBox TBlabel;
        private System.Windows.Forms.GroupBox Pcolor;
        private System.Windows.Forms.GroupBox Pbtype;
        private System.Windows.Forms.ToolStripMenuItem menu_doc;
        private System.Windows.Forms.GroupBox Plink;
        private System.Windows.Forms.TextBox TBlink;
        private System.Windows.Forms.GroupBox Phash;
        private System.Windows.Forms.TextBox TBhash;
        private System.Windows.Forms.GroupBox Papp_id;
        private System.Windows.Forms.TextBox TBapp_id;
        private System.Windows.Forms.GroupBox Powner_id;
        private System.Windows.Forms.TextBox TBowner_id;
        private System.Windows.Forms.GroupBox Ppayload;
        private System.Windows.Forms.TextBox TBpayload;
        private System.Windows.Forms.Button Bdel;
    }
}