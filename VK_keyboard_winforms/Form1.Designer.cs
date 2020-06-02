namespace VK_keyboard_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.caption = new System.Windows.Forms.Label();
            this.Cbtn = new System.Windows.Forms.Button();
            this.MF_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Lbtn = new System.Windows.Forms.Button();
            this.MF_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // caption
            // 
            this.caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption.Location = new System.Drawing.Point(3, 0);
            this.caption.Margin = new System.Windows.Forms.Padding(3, 0, 3, 19);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(484, 31);
            this.caption.TabIndex = 0;
            this.caption.Text = "VK keyboard";
            this.caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cbtn
            // 
            this.Cbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cbtn.FlatAppearance.BorderSize = 2;
            this.Cbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cbtn.Location = new System.Drawing.Point(3, 53);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(484, 42);
            this.Cbtn.TabIndex = 1;
            this.Cbtn.TabStop = false;
            this.Cbtn.Text = "Создать";
            this.Cbtn.UseVisualStyleBackColor = false;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // MF_tableLayoutPanel
            // 
            this.MF_tableLayoutPanel.ColumnCount = 1;
            this.MF_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MF_tableLayoutPanel.Controls.Add(this.caption, 0, 0);
            this.MF_tableLayoutPanel.Controls.Add(this.Cbtn, 0, 1);
            this.MF_tableLayoutPanel.Controls.Add(this.Lbtn, 0, 2);
            this.MF_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MF_tableLayoutPanel.Location = new System.Drawing.Point(5, 10);
            this.MF_tableLayoutPanel.Name = "MF_tableLayoutPanel";
            this.MF_tableLayoutPanel.RowCount = 3;
            this.MF_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MF_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MF_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MF_tableLayoutPanel.Size = new System.Drawing.Size(490, 146);
            this.MF_tableLayoutPanel.TabIndex = 2;
            // 
            // Lbtn
            // 
            this.Lbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Lbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Lbtn.FlatAppearance.BorderSize = 2;
            this.Lbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Lbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Lbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbtn.Location = new System.Drawing.Point(3, 101);
            this.Lbtn.Name = "Lbtn";
            this.Lbtn.Size = new System.Drawing.Size(484, 42);
            this.Lbtn.TabIndex = 2;
            this.Lbtn.TabStop = false;
            this.Lbtn.Text = "Открыть";
            this.Lbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 160);
            this.Controls.Add(this.MF_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 4);
            this.Text = "VK keyboard";
            this.MF_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.TableLayoutPanel MF_tableLayoutPanel;
        private System.Windows.Forms.Button Lbtn;
    }
}

