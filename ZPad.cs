using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPad
{
    public partial class ZPad : Form
    {
        public ZPad()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Filter = "Text Document|*.txt|All Files|*.*";
            saveDialog1.Title = "Save text file...";
            saveDialog1.ShowDialog();

            if (saveDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveDialog1.FileName, rteTextEditor.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog1 = new OpenFileDialog();
            openDialog1.Filter = "Text Document|*.txt|All Files|*.*";
            openDialog1.Title = "Open text file...";
            openDialog1.ShowDialog();

            if (openDialog1.FileName != "")
            {
                rteTextEditor.Text = System.IO.File.ReadAllText(openDialog1.FileName);
            }
        }
    }
}
