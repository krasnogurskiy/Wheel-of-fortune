using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace app
{
    public partial class LogForm : Form
    {
        private List<Log> log;
        private Log current_log;
        private ListBox current_list_box;
        public LogForm(List<Player> rating, Log _raund_1, Log _raund_2, Log _raund_3, Log _general_log)
        {
            InitializeComponent();
            player1.Text = $"{rating[0].Name} з рахунком {rating[0].Score} балів";
            player2.Text = $"{rating[1].Name} з рахунком {rating[1].Score} балів";
            player3.Text = $"{rating[2].Name} з рахунком {rating[2].Score} балів";
            log = new List<Log>() { _raund_1, _raund_2, _raund_3, _general_log };
        }
        private void show_log_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            toolStrip1.Visible = true;
            menuStrip1.Visible = true;
            logs.Visible = true;
            close_bt.Visible = true;
            save_all_bt.Visible = true;
            save_as_bt.Visible = true;
            raund1.DataSource = this.log[0].log;
            raund2.DataSource = this.log[1].log;
            raund3.DataSource = this.log[2].log;
            general.DataSource = this.log[3].log;
            this.Text = "Журнал гри";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string logDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Log");

            // Перевіряємо, чи папка "Log" існує
            if (!Directory.Exists(logDirectoryPath))
            {
                // Якщо папки "Log" не існує, створюємо її
                Directory.CreateDirectory(logDirectoryPath);
            }

            // Створюємо папку з назвою, що відповідає поточній даті
            string currentDateFolderName = DateTime.Now.ToString("yyyyMMddHHmmss");
            string currentDateFolderPath = Path.Combine(logDirectoryPath, currentDateFolderName);
            Directory.CreateDirectory(currentDateFolderPath);
            // Створюємо чотири файли у папці поточної дати
            for (int i = 0; i < 3; i++)
            {
                string name = Path.Combine(currentDateFolderPath, $"Raund{i + 1}.txt");
                Log.StoreToTextFile(name, log[i].log);
            }
            string gen_name = Path.Combine(currentDateFolderPath, "General.txt");
            Log.StoreToTextFile(gen_name, log[3].log);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1: Log.StoreToTextFile(saveFileDialog1.FileName, current_log.log); break;
                    case 2: Log.StoreToBinaryFile(saveFileDialog1.FileName, current_log.log); break;
                    case 3: Log.StoreToSoapFile(saveFileDialog1.FileName, current_log.log); break;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in current_list_box.Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            Clipboard.SetText(stringBuilder.ToString());
        }

        private void logs_TabIndexChanged(object sender, EventArgs e)
        {
            int index = logs.SelectedIndex;
            switch (index)
            {
                case 0:
                    current_log = log[0];
                    current_list_box = raund1;
                    break;
                case 1:
                    current_log = log[1];
                    current_list_box = raund2;
                    break;
                case 2:
                    current_log = log[2];
                    current_list_box = raund3;
                    break;
                case 3:
                    current_log = log[3];
                    current_list_box = general;
                    break;
            }
        }
    }
}
