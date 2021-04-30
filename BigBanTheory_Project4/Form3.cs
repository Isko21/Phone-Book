using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BigBanTheory_Project4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        int line = 1;
        List<string> vs = File.ReadAllLines(@"Contact.txt").ToList();
        int maxPage;
        int currentPage = 1;
        StreamReader streamReader = new StreamReader(@"Contact.txt");
        private void Form3_Load(object sender, EventArgs e)
        {
            if (vs.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Plaese add contact!", "No contact!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Form1 form2 = new Form1();
                    this.Close();
                    form2.Show();
                }
            }
            else
            {
                Reader();
            }
        }
        private void Reader()
        {
            name.Text = FirstRemover(vs[line]);
            last.Text = FirstRemover(vs[line + 1]);
            email.Text = FirstRemover(vs[line + 2]);
            number.Text = FirstRemover(vs[line + 3]);
            address.Text = FirstRemover(vs[line + 4]);
            gender.Text = FirstRemover(vs[line + 5]);
            pictureBox1.ImageLocation = (@"Images\" + FirstRemover(vs[line + 6]));
            maxPage = vs.Count / 8;
            navigation.Text = $"{currentPage}/{maxPage}";
        }
        static string FirstRemover(string result)
        {
            int i = result.IndexOf(" ") + 1;
            result = result.Substring(i);
            return result;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage == maxPage)
            {
                next.Enabled = true;
            }
            else
            {
                line += 8;
                currentPage += 1;
                Reader();
            }
        }
        private void previous_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                previous.Enabled = true;
            }
            else
            {
                line -= 8;
                currentPage -= 1;
                Reader();
            }
        }
    }
}
