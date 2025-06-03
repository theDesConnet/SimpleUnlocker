using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleUnlocker.Forms
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            try
            {
                Process.Start(textBox1.Text);
            }
            catch
            {
                MessageBox.Show($"Не удалось найти \"{textBox1.Text}\". Проверьте правильность введенного имени и попробуйте еще раз.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Show();
                return;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            
        }

        private void Run_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "") button1.Enabled = false;
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                Hide();
                try
                {
                    Process.Start(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show($"Не удалось найти \"{textBox1.Text}\". Проверьте правильность введенного имени и попробуйте еще раз.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Show();
                    return;
                }
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}
