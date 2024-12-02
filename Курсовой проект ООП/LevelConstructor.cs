using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Курсовой_проект_ООП
{
    public partial class LevelConstructor : Form
    {
        DrawBlocks block = new DrawBlocks();

        string map;

        public int rows = 0;
        public int columns = 0;
        public int count = 0;

        public LevelConstructor()
        {
            InitializeComponent();
        }

        public void CreateBlueBlock()
        {
            block.blocksView = new PictureBox
            {
                Height = 32,
                Width = 100,
                Tag = "Blocks",
                BackgroundImage = Image.FromFile(@"Images\BlueBlock.png")
            };

            if (columns < 4)
            {
                if (rows < 5)
                {
                    block.blocksView.Left = block.DirX;
                    block.blocksView.Top = block.DirY;
                    DrawArea.Controls.Add(block.blocksView);

                    block.DirX += block.blocksView.Width;
                    rows++;
                }
                if (rows == 5)
                {
                    block.DirY += block.blocksView.Height;
                    block.DirX = 9;
                    columns++;
                    rows = 0;
                }
            }
        }

        public void CreatePurpleBlock()
        {
            block.blocksView = new PictureBox
            {
                Height = 32,
                Width = 100,
                Tag = "HardBlocks",
                BackgroundImage = Image.FromFile(@"Images\PurpleBlock.png")
            };
            if (columns < 4)
            {
                if (rows < 5)
                {
                    block.blocksView.Left = block.DirX;
                    block.blocksView.Top = block.DirY;
                    DrawArea.Controls.Add(block.blocksView);

                    block.DirX += block.blocksView.Width;
                    rows++;
                }
                if (rows == 5)
                {
                    block.DirY += block.blocksView.Height;
                    block.DirX = 9;
                    columns++;
                    rows = 0;
                }
            }
        }

        private void AddBlue_Click(object sender, EventArgs e)
        {
            if (count < 20)
            {
                CreateBlueBlock();
                map += "0 ";
            }
            count++;
        }

        private void AddPurple_Click(object sender, EventArgs e)
        {
            if (count < 20)
            {
                CreatePurpleBlock();
                map += "1 ";
            }
            count++;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(DrawArea.Controls.Count == 0)
            {
                MessageBox.Show("Уровень не может быть пустым!");
            }
            else
            {
                FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.ReadWrite);
                fs.SetLength(0);
                fs.Close();
                StreamWriter writer = new StreamWriter("level.txt", true, Encoding.Default);
                writer.Write(map.Trim());
                writer.Close();
            }                
        }

        private void ConstructorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DrawBlocks
    {
        public int DirX { get; set; } // Координата X первого блока
        public int DirY { get; set; } // Координата Y первого блока

        public PictureBox blocksView = new PictureBox();
        public PictureBox[] blocks = new PictureBox[20];

        public DrawBlocks()
        {
            DirX = 9;
            DirY = 1;
        }
    }
}
