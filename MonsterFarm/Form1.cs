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

                var hashCode = filePath.GetHashCode();
                var hashCode1桁 = hashCode % 10;

                switch(hashCode1桁)
                {
                    case int i when i < 3 :
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa1.jpg");
                        break;
                    case int i when i < 6:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa2.jpg");
                        break;
                    case int i when i < 9:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa3.jpg");
                        break;
                    default:
                        pictureBox1.Image = Bitmap.FromFile(directory + "\\g\\aaa4.jpeg");
                        break;

                }
            }

        }

    }
}
