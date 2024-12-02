using System;
using System.Windows.Forms;

namespace Курсовой_проект_ООП
{
    public partial class ArcanoidMenu : Form
    {
        public ArcanoidMenu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MainForm gameForm = new MainForm();
            gameForm.Show();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameRules_Click(object sender, EventArgs e)
        {
            Rules.Visible = true;
            Ok.Visible = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Rules.Visible = false;
            pictureBox1.Visible = false;
            Ok.Visible = false;
        }

        private void Constructor_Click(object sender, EventArgs e)
        {
            LevelConstructor constructor = new LevelConstructor();
            constructor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= true;
            Ok.Visible = true;
        }
    }
}
