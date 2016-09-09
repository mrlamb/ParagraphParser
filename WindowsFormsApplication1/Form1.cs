using ParagraphParserIntoDictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string WallOfText = sr.ReadToEnd();

            var pp = new ParagraphParser(WallOfText);
            foreach (var item in pp)
            {
                List<TreeNode> ltn = new List<TreeNode>();
                foreach (var item2 in item.Value)
                {
                    ltn.Add(new TreeNode(item2));
                }
                TreeNode tn = new TreeNode(item.Key, ltn.ToArray());
                treeView1.Nodes.Add(tn);

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
