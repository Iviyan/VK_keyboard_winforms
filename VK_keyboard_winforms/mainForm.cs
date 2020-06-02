using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VK_keyboard_winforms
{
    public partial class mainForm : Form
    {
        public void mb<T>(T m) => MessageBox.Show( m.ToString());

        Keyboard keyboard;
        public mainForm()
        {
            InitializeComponent(); 
            //string s = @"{""inline"":false,""one_time"":false,""buttons"":[[{""type"":""text"",""payload"":null}]]}";
            //keyboard = JsonConvert.DeserializeObject<Keyboard>(s);

            keyboard = new Keyboard();
            kbUpd();
        }

        public static class colors
        {
            public static Color primary = Color.FromArgb(81, 129, 184);
            public static Color secondary = Color.White;
            public static Color negative = Color.FromArgb(230, 70, 70);
            public static Color positive = Color.FromArgb(75, 179, 75);
        };
        class Keyboard
        {
            public bool inline { get; set; }
            public bool one_time { get; set; }
            public List<List<object>> buttons { get; set; } = new List<List<object>>();

            public class button
            {
                abstract public class Action
                {
                    public string type { get; set; }
                    public string payload { get; set; } = "";
                }
                public class text : Action
                {
                    public text() { type = "text"; }
                    public string label { get; set; } = "label";
                }
                public class open_link : Action
                {
                    public open_link() { type = "open_link"; }
                    public string link { get; set; } = "https://vk.com";
                    public string label { get; set; } = "label";
                }
                public class location : Action
                {
                    public location() { type = "location"; }

                }
                public class vkpay : Action
                {
                    public vkpay() { type = "vkpay"; }
                    public string hash { get; set; } = "";
                }
                public class open_app : Action
                {
                    public open_app() { type = "open_app"; }
                    public int app_id { get; set; } = 0;
                    public int owner_id { get; set; } = 0;
                    public string hash { get; set; } = "";
                    public string label { get; set; } = "label";
                }

                //public Action action;
                [DefaultValue("primary")]
                public string color { get; set; } = "primary";
            }
            public class text : button
            {
                public button.text action { get; set; } = new button.text();
            }
            public class open_link : button
            {
                public button.open_link action { get; set; } = new button.open_link();
            }
            public class location : button
            {
                public button.location action { get; set; } = new button.location();
            }
            public class vkpay : button
            {
                public button.vkpay action { get; set; } = new button.vkpay();
            }
            public class open_app : button
            {
                public button.open_app action { get; set; } = new button.open_app();
            }

        }

        public string kbJSON()
        {
            JsonSerializerSettings js = new JsonSerializerSettings();
            js.Formatting = Formatting.Indented;
            js.DefaultValueHandling = DefaultValueHandling.Ignore;
            js.NullValueHandling = NullValueHandling.Ignore;

            return JsonConvert.SerializeObject(keyboard,js);
        }

        public void kbUpd()
        {
            JSONtb.Text = kbJSON();
        }

        private void CBinline_CheckedChanged(object sender, EventArgs e)
        {
            bool val = CBinline.Checked;
            keyboard.inline = val;
            if (val) CBonetime.Checked = false;
            kbUpd();
        }

        private void CBonetime_CheckedChanged(object sender, EventArgs e)
        {
            bool val = CBonetime.Checked;
            keyboard.one_time = val;
            if (val) CBinline.Checked = false;
            kbUpd();
        }

        private void PV_addv_Click(object sender, EventArgs e)
        {
            var rc = keyboard.buttons.Count; //rowsCount
            List<object> l = new List<object>();
            l.Add(new Keyboard.text());
            keyboard.buttons.Add(l);
            kbUpd();

            preview.RowCount++;
            preview.RowStyles.Insert(rc, new RowStyle(SizeType.Absolute, 38));
            preview.Controls.Add(PV_addv, 0, rc + 1);
            if (rc >= 10 - 1)
            {
                //preview.RowStyles[rc + 1].Height = 0;
                PV_addv.Visible = false;
            }

            TableLayoutPanel row = new TableLayoutPanel();
            row.Dock = DockStyle.Fill;
            row.Name = "PV_row_" + (preview.RowCount - 2).ToString();
            row.ColumnCount = 2;
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
            row.RowCount = 1;
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            row.Margin = new Padding(0);

            Button PV_btn = new Button();
            PV_btn.Name = "PV_" + rc.ToString() + "_0";
            PV_btn.Text = PV_btn.Name;
            PV_btn.Dock = DockStyle.Fill;
            PV_btn.BackColor = colors.primary;
            PV_btn.Margin = new Padding(1);
            PV_btn.ForeColor = Color.White;
            PV_btn.Click += PV_btn_Click;

            row.Controls.Add(PV_btn, 0, 0);
            preview.Controls.Add(row, 0, rc);

            Button PV_addh = new Button();
            PV_addh.Name = "PV_addh_" + rc.ToString();
            PV_addh.Text = "+";
            PV_addh.Dock = DockStyle.Fill;
            PV_addh.Margin = new Padding(2, 3, 8, 3);
            row.Controls.Add(PV_addh, 1, 0);
            PV_addh.Click += PV_addh_Click;
        }

        private void PV_addh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int row = int.Parse(btn.Name.Substring("PV_addh_".Length));
            int rc = keyboard.buttons.Count; //rowsCount
            int cc = keyboard.buttons[row].Count;
            keyboard.buttons[row].Add(new Keyboard.text());
            kbUpd();

            TableLayoutPanel rowel = preview.Controls.Find("PV_row_" + row.ToString(), false).FirstOrDefault() as TableLayoutPanel;

            rowel.ColumnCount++;
            rowel.ColumnStyles.Insert(cc, new ColumnStyle(SizeType.Percent, 100 / cc));
            for (int i = 0; i <= rowel.ColumnStyles.Count - 2; i++)
            {
                rowel.ColumnStyles[i].SizeType = SizeType.Percent;
                rowel.ColumnStyles[i].Width = 100 / cc;
            }
            
            if (cc >= 5 - 1)
            {
                rowel.ColumnStyles[cc+1].Width = 0;
                (sender as Button).Visible = false;
            }

            Button PV_btn = new Button();
            PV_btn.Name = "PV_" + (rc-1).ToString() + "_" + cc.ToString();
            PV_btn.Text = PV_btn.Name;
            PV_btn.Dock = DockStyle.Fill;
            PV_btn.BackColor = colors.primary;
            PV_btn.Margin = new Padding(1);
            PV_btn.ForeColor = Color.White;
            PV_btn.Click += PV_btn_Click;
            rowel.Controls.Add(PV_btn, cc, 0);

            rowel.Controls.Add(sender as Button, cc + 1, 0);
        }

        private void PV_btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] btnn_ = btn.Name.Substring("PV_".Length).Split('_');
            int row = int.Parse(btnn_[0]);
            int col = int.Parse(btnn_[1]);
            //mb($"{row} - {col}");

        }

        private void документацяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://vk.com/dev/bots_docs_3";
            System.Diagnostics.Process.Start(url);
        }
    }
}
