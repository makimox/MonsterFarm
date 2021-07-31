using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;


            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                var directory = System.IO.Directory.GetCurrentDirectory();
                var value = 5;

                var hashCode = filePath.GetHashCode();
                var hashCode1桁 = hashCode % 100;

                switch(hashCode1桁)
                {
                    case int i when i < 25 :
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa1.jpg");
                        break;
                    case int i when i < 40:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa2.jpg");
                        break;
                    case int i when i < 60:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa3.jpg");
                        break;
                    case int i when i < 75:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa4.jpeg");
                        break;
                    case int i when i < 90:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa6.jpg");
                        break;
                    default:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa5.gif");
                        break;

                }
            }

        }

    }
}
