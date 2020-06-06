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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace VK_keyboard_winforms
{
    public partial class mainForm : Form
    {
        public void mb<T>(T m) => MessageBox.Show(m?.ToString());

        Keyboard keyboard;
        Now now;

        public bool saved = true;
        public string fileName = "";
        public mainForm()
        {
            InitializeComponent(); 
            //string s = @"{""inline"":false,""one_time"":false,""buttons"":[[{""type"":""text"",""payload"":null}]]}";
            //keyboard = JsonConvert.DeserializeObject<Keyboard>(s);

            keyboard = new Keyboard();
            kbUpd();

            now = new Now();
        }

        public class Now
        {
            private Button button;
            public Button btn
            {
                get { return button; }
                set
                {
                    button = value;

                    string[] btnn_ = button.Name.Substring("PV_".Length).Split('_');
                    row = int.Parse(btnn_[0]);
                    col = int.Parse(btnn_[1]);
                }
            }
            public int row = 0;
            public int col = 0;
        }

        public Color fromHEX(string s) => Color.FromArgb(Int32.Parse(s.TrimStart('#'), System.Globalization.NumberStyles.HexNumber));

        public static class colors
        {
            public static Color primary = Color.FromArgb(81, 129, 184);
            public static Color secondary = Color.White;
            public static Color negative = Color.FromArgb(230, 70, 70);
            public static Color positive = Color.FromArgb(75, 179, 75);
            public static Color fromStr(string c)
            {
                switch (c)
                {
                    case "secondary": return secondary;
                    case "negative": return negative;
                    case "positive": return positive;
                    case "primary": default: return primary;

                }
            }
        };

        public int buttonsCount = 0;
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
            string error = "";
            if (keyboard.inline) {
                if (buttonsCount > 10) error = "Максимальное ко-во клавиш (inline): 10";
                if (keyboard.buttons.Count > 6) error = "Максимальное ко-во строк (inline): 6";
            } else
            {
                if (buttonsCount > 40) error = "Максимальное ко-во клавиш: 40";
            }

            if (error == "")
                JSONtb.Text = kbJSON();
            else
                JSONtb.Text = error;
        }

        private void CBinline_CheckedChanged(object sender, EventArgs e)
        {
            saved = false;
            bool val = CBinline.Checked;
            keyboard.inline = val;
            if (val) CBonetime.Checked = false;
            kbUpd();
        }

        private void CBonetime_CheckedChanged(object sender, EventArgs e)
        {
            saved = false;
            bool val = CBonetime.Checked;
            keyboard.one_time = val;
            if (val) CBinline.Checked = false;
            kbUpd();
        }

        TableLayoutPanel PV_addRow()
        {
            int rc = preview.RowCount-1; //mb(preview.RowCount); mb(preview.RowStyles.Count);

            preview.RowCount++;
            preview.RowStyles.Insert(rc, new RowStyle(SizeType.Absolute, 38));
            preview.Controls.Add(PV_addv, 0, rc+1);
            if (rc >= 10 - 1)
            {
                //preview.RowStyles[rc + 1].Height = 0;
                PV_addv.Visible = false;
            }

            TableLayoutPanel row = new TableLayoutPanel();
            row.Dock = DockStyle.Fill;
            row.Name = "PV_row_" + (rc).ToString();
            row.ColumnCount = 2;
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
            row.RowCount = 1;
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            row.Margin = new Padding(0);

            Button PV_btn = new Button();
            PV_btn.Name = $"PV_{rc}_0";
            PV_btn.Text = PV_btn.Name;
            PV_btn.Dock = DockStyle.Fill;
            PV_btn.BackColor = colors.primary;
            PV_btn.Margin = new Padding(1);
            PV_btn.ForeColor = Color.White;
            PV_btn.Click += PV_btn_Click;

            row.Controls.Add(PV_btn, 0, 0);
            preview.Controls.Add(row, 0, rc);

            Button PV_addh = new Button();
            PV_addh.Name = "PV_addh_" + (rc).ToString();
            PV_addh.Text = "+";
            PV_addh.Dock = DockStyle.Fill;
            PV_addh.Margin = new Padding(2, 3, 8, 3);
            row.Controls.Add(PV_addh, 1, 0);
            PV_addh.Click += PV_addh_Click;

            return row;
        }
        Button PV_addCol(int row)
        {
            TableLayoutPanel rowel = preview.GetControlFromPosition(0, row) as TableLayoutPanel;
            int cc = rowel.ColumnCount - 1;
            rowel.ColumnCount++;
            rowel.ColumnStyles.Insert(cc, new ColumnStyle(SizeType.Percent, 100));

            Button addh = rowel.Controls.Find($"PV_addh_{row}",false).FirstOrDefault() as Button;// mb(addh);
            rowel.Controls.Add(addh, cc+1 , 0);

            if (cc >= 5-1)
            {
                rowel.ColumnStyles[cc+1].Width = 5;
                addh.Visible = false;
            }

            Button PV_btn = new Button();
            PV_btn.Name = $"PV_{row}_{cc}";
            PV_btn.Text = PV_btn.Name;
            PV_btn.Dock = DockStyle.Fill;
            PV_btn.BackColor = colors.primary;
            PV_btn.Margin = new Padding(1);
            PV_btn.ForeColor = Color.White;
            PV_btn.Click += PV_btn_Click;
            rowel.Controls.Add(PV_btn, cc, 0);

            return PV_btn;
        }

        private void PV_addv_Click(object sender, EventArgs e)
        {
            saved = false;
            buttonsCount++;
            int rc = keyboard.buttons.Count; //rowsCount
            List<object> l = new List<object>();
            Keyboard.text kbo = new Keyboard.text();
            l.Add(kbo);
            keyboard.buttons.Add(l);

            TableLayoutPanel row = PV_addRow();
            kbo.action.label = row.Controls[0].Text;

            kbUpd();
        }

        private void PV_addh_Click(object sender, EventArgs e)
        {
            saved = false;
            buttonsCount++;
            Button btn = (Button)sender;
            int row = int.Parse(btn.Name.Substring("PV_addh_".Length));
            Keyboard.text kbo = new Keyboard.text();
            keyboard.buttons[row].Add(kbo);

            //TableLayoutPanel rowel = btn.Parent as TableLayoutPanel;//preview.Controls.Find("PV_row_" + row.ToString(), false).FirstOrDefault() as TableLayoutPanel;

            Button PV_btn = PV_addCol(row);

            kbo.action.label = PV_btn.Text;

            kbUpd();
        }

        public void setPanels(int row, int col)
        {
            if (!Spanel.Visible) Spanel.Visible = true;

            Plabel.Visible = false;
            Pcolor.Visible = false;
            Plink.Visible = false;
            Phash.Visible = false;
            Papp_id.Visible = false;
            Powner_id.Visible = false;

            switch (keyboard.buttons[row][col])
            {
                case Keyboard.text t:
                    {
                        CBbtype.SelectedIndex = 0;
                        TBlabel.Text = t.action.label;
                        Pcolor.Visible = true;
                        TBpayload.Text = t.action.payload;

                        Plabel.Visible = true;
                    }
                    break;
                case Keyboard.open_link t:
                    {
                        CBbtype.SelectedIndex = 1;
                        TBlabel.Text = t.action.label;
                        TBlink.Text = t.action.link;
                        TBpayload.Text = t.action.payload;

                        Plabel.Visible = true;
                        Plink.Visible = true;
                    }
                    break;
                case Keyboard.location t:
                    {
                        CBbtype.SelectedIndex = 2;
                        TBpayload.Text = t.action.payload;
                        TBlabel.Text = "Отправить своё местоположение";
                       }
                    break;
                case Keyboard.vkpay t:
                    {
                        CBbtype.SelectedIndex = 3;
                        TBhash.Text = t.action.hash;
                        TBpayload.Text = t.action.payload;
                        TBlabel.Text = "Оплатить через VKpay";

                        Phash.Visible = true;
                    }
                    break;
                case Keyboard.open_app t:
                    {
                        CBbtype.SelectedIndex = 4;
                        TBapp_id.Text = t.action.app_id.ToString();
                        TBowner_id.Text = t.action.owner_id.ToString();
                        TBlabel.Text = t.action.label;
                        TBhash.Text = t.action.hash;
                        TBpayload.Text = t.action.payload;

                        Papp_id.Visible = true;
                        Powner_id.Visible = true;
                        Plabel.Visible = true;
                        Phash.Visible = true;
                    }
                    break;
            }
        }

        private void PV_btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            /*string[] btnn_ = btn.Name.Substring("PV_".Length).Split('_');
            int row = int.Parse(btnn_[0]);
            int col = int.Parse(btnn_[1]);*/
            now.btn = btn;
            int row = now.row;
            int col = now.col;
            // mb($"{row} - {col}");

            setPanels(row, col);
            
        }

        private void документацяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://vk.com/dev/bots_docs_3";
            System.Diagnostics.Process.Start(url);
        }

        private void CBbtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            saved = false;
            int row = now.row;
            int col = now.col;
            var kbn = keyboard.buttons[row][col];

            switch (CBbtype.SelectedItem as string)
            {
                case "Text":
                    {
                        if (kbn is Keyboard.text) return;
                        Keyboard.text kn = new Keyboard.text();
                        switch (kbn)
                        {
                            case Keyboard.open_link t:
                                kn.action.label = t.action.label;
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.location t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.vkpay t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_app t:
                                kn.action.label = t.action.label;
                                kn.action.payload = t.action.payload;
                                break;
                        }
                        keyboard.buttons[row][col] = kn;
                    }
                    break;
                case "Open Link":
                    {
                        if (kbn is Keyboard.open_link) return;
                        Keyboard.open_link kn = new Keyboard.open_link();
                        switch (kbn)
                        {
                            case Keyboard.text t:
                                kn.action.label = t.action.label;
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.location t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.vkpay t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_app t:
                                kn.action.label = t.action.label;
                                kn.action.payload = t.action.payload;
                                break;
                        }
                        keyboard.buttons[row][col] = kn;
                    }
                    break;
                case "Location":
                    {
                        if (kbn is Keyboard.location) return;
                        Keyboard.location kn = new Keyboard.location();
                        switch (kbn)
                        {
                            case Keyboard.text t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_link t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.vkpay t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_app t:
                                kn.action.payload = t.action.payload;
                                break;
                        }
                        keyboard.buttons[row][col] = kn;
                    }
                    break;
                case "VK Pay":
                    {
                        if (kbn is Keyboard.vkpay) return;
                        Keyboard.vkpay kn = new Keyboard.vkpay();
                        switch (kbn)
                        {
                            case Keyboard.text t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_link t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.location t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_app t:
                                kn.action.payload = t.action.payload;
                                break;
                        }
                        keyboard.buttons[row][col] = kn;
                    }
                    break;
                case "VK Apps":
                    {
                        if (kbn is Keyboard.open_app) return;
                        Keyboard.open_app kn = new Keyboard.open_app();
                        switch (kbn)
                        {
                            case Keyboard.text t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.open_link t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.location t:
                                kn.action.payload = t.action.payload;
                                break;
                            case Keyboard.vkpay t:
                                kn.action.payload = t.action.payload;
                                break;
                        }
                        keyboard.buttons[row][col] = kn;
                    }
                    break;
            }
            setPanels(row, col);
            kbUpd();
        }

        private void CB_Click(object sender, EventArgs e)
        {
            saved = false;
            string color_name = (sender as Button).Name.Substring(2); 
            Color color_ = colors.fromStr(color_name); //mb(color_name + "   " + color_.ToString());
            now.btn.BackColor = color_;
            if (color_ == Color.White) now.btn.ForeColor = fromHEX("#55677d"); else now.btn.ForeColor = Color.White;
            (keyboard.buttons[now.row][now.col] as Keyboard.button).color = color_name;
            kbUpd();
        }

        private void TBlabel_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string txt = (sender as TextBox).Text;
            now.btn.Text = txt;
            switch (keyboard.buttons[now.row][now.col])
            {
                case Keyboard.text t:
                    t.action.label = txt;
                    break;
                case Keyboard.open_link t:
                    t.action.label = txt;
                    break;
                case Keyboard.open_app t:
                    t.action.label = txt;
                    break;
            }
            kbUpd();
        }

        private void TBlink_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string link = (sender as TextBox).Text;
            (keyboard.buttons[now.row][now.col] as Keyboard.open_link).action.link = link;
            kbUpd();
        }

        private void TBhash_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string hash = (sender as TextBox).Text;
            switch (keyboard.buttons[now.row][now.col])
            {
                case Keyboard.vkpay t:
                    t.action.hash = hash;
                    break;
                case Keyboard.open_app t:
                    t.action.hash = hash;
                    break;
            }
            kbUpd();
        }

        private void TBapp_id_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string app_id = (sender as TextBox).Text;
            (keyboard.buttons[now.row][now.col] as Keyboard.open_app).action.app_id = int.Parse(app_id);
            kbUpd();
        }

        private void TBowner_id_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string owner_id = (sender as TextBox).Text;
            (keyboard.buttons[now.row][now.col] as Keyboard.open_app).action.owner_id = int.Parse(owner_id);
            kbUpd();
        }

        private void TBpayload_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string payload = (sender as TextBox).Text;
            switch (keyboard.buttons[now.row][now.col])
            {
                case Keyboard.text t:
                    t.action.payload = payload;
                    break;
                case Keyboard.open_link t:
                    t.action.payload = payload;
                    break;
                case Keyboard.location t:
                    t.action.payload = payload;
                    break;
                case Keyboard.vkpay t:
                    t.action.payload = payload;
                    break;
                case Keyboard.open_app t:
                    t.action.payload = payload;
                    break;
            }
            kbUpd();
        }

        public void remove_row(TableLayoutPanel panel, int row_index_to_remove)
        {
            if (row_index_to_remove >= panel.RowCount) return;

            // delete all controls of row that we want to delete
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                var control = panel.GetControlFromPosition(i, row_index_to_remove);
                panel.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = row_index_to_remove + 1; i < panel.RowCount; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    var control = panel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        panel.SetRow(control, i - 1);
                    }
                }
            }

            // remove last row
            panel.RowStyles.RemoveAt(panel.RowCount - 1);
            panel.RowCount--;
        }

        public String ReplaceAt<T>(String str, int index, T newSymb)
        {
            return str.Remove(index, 1).Insert(index, newSymb.ToString());
        }
        public Control GetControlAt(TableLayoutPanel panel, int column, int row)
        {
            foreach (Control control in panel.Controls)
            {
                var cellPosition = panel.GetCellPosition(control);// mb($"{control.Name} - {cellPosition.Column} _ {cellPosition.Row}");
                if (cellPosition.Column == column && cellPosition.Row == row)
                    return control;
            }
            return null;
        }
        private void Bdel_Click(object sender, EventArgs e)
        {
            saved = false;
            buttonsCount--;
            int row = now.row; //mb(preview.Controls.Count); return;
            int col = now.col;
            if (keyboard.buttons[row].Count == 1)
            {
                keyboard.buttons.RemoveAt(row);
                Spanel.Visible = false; //PV_row_
                remove_row(preview, row);

                for (int r = row; r < keyboard.buttons.Count; r++)
                {
                    TableLayoutPanel subPanel = (TableLayoutPanel)preview.GetControlFromPosition(0, r);
                    subPanel.GetControlFromPosition(keyboard.buttons[r].Count, 0).Name = $"PV_addh_{r}";
                    subPanel.Name = $"PV_row_{r}";
                    //mb(preview.GetControlFromPosition(0,r).Name);
                    for (int c = col; c < keyboard.buttons[r].Count; c++)
                    {
                        subPanel.GetControlFromPosition(c, 0).Name = $"PV_{r}_{c}";
                    }
                }

                if (keyboard.buttons.Count == 9)
                {
                    PV_addv.Visible = true;
                }
                //preview.Controls.RemoveAt(row);
                //preview.RowStyles.RemoveAt(row);
                //review.RowCount--;
            } else {
                keyboard.buttons[row].RemoveAt(col);
                Spanel.Visible = false; //PV_row_
                TableLayoutPanel subPanel = (TableLayoutPanel)preview.GetControlFromPosition(0, row);
                var control = subPanel.GetControlFromPosition(col, 0);
                subPanel.Controls.Remove(control);

                for (int j = col + 1; j < subPanel.ColumnCount-1; j++)
                {
                    control = subPanel.GetControlFromPosition(j, 0);
                    if (control != null)
                    {
                        subPanel.SetColumn(control, j - 1);
                        control.Name = ReplaceAt(control.Name, 5, j - 1);
                    }
                }
                control = GetControlAt(subPanel, subPanel.ColumnCount-1, 0);
                control.Name = $"PV_addh_{row}"; subPanel.SetColumn(control, subPanel.ColumnCount - 1);
                subPanel.ColumnStyles.RemoveAt(col);
                subPanel.ColumnCount--;

                if (keyboard.buttons[row].Count == 4)
                {
                    subPanel.ColumnStyles[subPanel.ColumnStyles.Count - 1].Width = 30;
                    //subPanel.Controls.Find($"PV_addh_{row}", false).FirstOrDefault().Visible = true;
                    control.Visible = true;
                }
            }
            

            kbUpd();
        }

        public bool Save()
        {
            string fn;
            if (fileName == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "json";
                sfd.AddExtension = true;
                sfd.Title = "Сохранение клавиатуры";
                sfd.Filter = "JSON files(*.JSON)|*.JSON|Text files(*.txt)|*.txt";

                if (sfd.ShowDialog() == DialogResult.Cancel) return false;
                fn = sfd.FileName;
            }
            else fn = fileName;
            //mb(sfd.FileName);
            System.IO.File.WriteAllText(fn, JSONtb.Text);
            saved = true;
            return true;
        }
        private void menu_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        public bool askSave() //false - отмена
        {
            if (saved) return true;
            DialogResult result = MessageBox.Show(
                "Сохранить текущую клавиатуру?",
                "Подтверждение",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Cancel: return false;
                case DialogResult.Yes: if (!Save()) return false; break;
                case DialogResult.No: break;
            }
            return true;
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            if (!askSave()) return;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "json";
            ofd.AddExtension = true;
            ofd.Title = "Загрузка клавиатуры";
            ofd.Filter = "JSON files(*.JSON)|*.JSON|Text files(*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            fileName = ofd.FileName;
            //mb(ofd.FileName);
            string text = System.IO.File.ReadAllText(ofd.FileName);
            try {
                var settings = new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Populate };
                Keyboard kb_ = new Keyboard();//JsonConvert.DeserializeObject<Keyboard>(text, settings); //mb(keyboard.buttons[0][0] as Keyboard.text);

                JObject kb = JObject.Parse(text);
                if (kb.ContainsKey("inline") && (bool)kb["inline"]) { kb_.inline = true; CBinline.Checked = true; };
                if (kb.ContainsKey("one_time") && (bool)kb["one_time"]) { kb_.one_time = true; CBonetime.Checked = true; };
                JArray rows = (JArray)kb["buttons"];
                for (int r = 0; r < rows.Count; r++)
                {
                    JArray cols = (JArray)rows[r];
                    kb_.buttons.Add(new List<object>());
                    for (int c = 0; c < cols.Count; c++)
                    {
                        //mb($"{r}_{c}\n{cols[c]}");
                        JObject btn = (JObject)cols[c];
                        object b_add = null;
                        switch ((string)btn["action"]["type"])
                        {
                            case "text":
                                {
                                    var b = new Keyboard.text();

                                    b.color = (btn.ContainsKey("color")) ? (string)btn["color"] : "primary";
                                    b.action.label = (string)btn["action"]["label"];
                                    b.action.payload = (string)btn["action"]["payload"];
                                    b_add = b;
                                } break;
                            case "open_link":
                                {
                                    var b = new Keyboard.open_link();

                                    b.color = (btn.ContainsKey("color")) ? (string)btn["color"] : "primary";
                                    b.action.label = (string)btn["action"]["label"];
                                    b.action.link = (string)btn["action"]["link"];
                                    b.action.payload = (string)btn["action"]["payload"];
                                    b_add = b;
                                } break;
                            case "location":
                                {
                                    var b = new Keyboard.location();

                                    b.color = (btn.ContainsKey("color")) ? (string)btn["color"] : "primary";
                                    b.action.payload = (string)btn["action"]["payload"];
                                    b_add = b;
                                } break;
                            case "vkpay":
                                {
                                    var b = new Keyboard.vkpay();

                                    b.color = (btn.ContainsKey("color")) ? (string)btn["color"] : "primary";
                                    b.action.hash = (string)btn["action"]["hash"];
                                    b.action.payload = (string)btn["action"]["payload"];
                                    b_add = b;
                                } break;
                            case "open_app":
                                {
                                    var b = new Keyboard.open_app();

                                    b.color = (btn.ContainsKey("color")) ? (string)btn["color"] : "primary";
                                    b.action.app_id = int.Parse((string)btn["action"]["app_id"]);
                                    b.action.owner_id = int.Parse((string)btn["action"]["owner_id"]);
                                    b.action.label = (string)btn["action"]["label"];
                                    b.action.hash = (string)btn["action"]["hash"];
                                    b.action.payload = (string)btn["action"]["payload"];
                                    b_add = b;
                                } break;
                        }

                        kb_.buttons[r].Add(b_add);
                    }
                };
                keyboard = kb_;
                
                kbUpd();

                preview.Controls.Clear();
                preview.RowStyles.Clear();
                preview.RowCount = 1;
                preview.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                preview.Controls.Add(this.PV_addv, 0, 0);

                for (int r = 0; r < keyboard.buttons.Count; r++)
                {
                    TableLayoutPanel row = PV_addRow();
                    PV_btn_set(row.Controls[0] as Button, keyboard.buttons[r][0]);

                    for (int c = 1; c < keyboard.buttons[r].Count; c++)
                    {
                        PV_btn_set(PV_addCol(r), keyboard.buttons[r][c]);
                    }
                }
                saved = true;
            } catch (Exception err)
            {
                mb($"Ошибка: {err}");
            }
        }

        void PV_btn_set(Button btn, object obj)
        {
            switch (obj)
            {
                case Keyboard.text t: btn.Text = t.action.label; break;
                case Keyboard.open_link t: btn.Text = t.action.label; break;
                case Keyboard.open_app t: btn.Text = t.action.label; break;
                case Keyboard.location t: btn.Text = "Отправить своё местоположение"; break;
                case Keyboard.vkpay t: btn.Text = "Оплатить через VKpay"; break;
            }

            string color_name = (obj as Keyboard.button)?.color;// mb(obj);
            Color color_ = colors.fromStr(color_name); //mb(color_name + "   " + color_.ToString());
            btn.BackColor = color_;
            if (color_ == Color.White) btn.ForeColor = fromHEX("#55677d"); else btn.ForeColor = Color.White;
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            if (!askSave()) return;

            preview.Controls.Clear();
            preview.RowStyles.Clear();
            preview.RowCount = 1;
            preview.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            preview.Controls.Add(this.PV_addv, 0, 0);

            CBinline.Checked = false;
            CBonetime.Checked = false;

            keyboard = new Keyboard();
            kbUpd();

            fileName = "";

            saved = true;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!askSave()) e.Cancel = true;
        }
    }
}
