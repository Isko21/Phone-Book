using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BigBanTheory_Project4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string imagepath3;
        OpenFileDialog openFile = new OpenFileDialog();
        private void changeBtn_Click_1(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
                path.Text = openFile.FileName;
            }
            string imagePath = openFile.FileName.ToString();
            string imagepath1 = imagePath.ToString();
            string imagepath2 = imagepath1.Substring(imagepath1.LastIndexOf("\\"));
            imagepath3 = imagepath2.Remove(0, 1);
        }
        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            string name, middle, last, number, gender, address;
            if (nameBox.Text.Length != 0 && middleBox.Text.Length != 0 && lastBox.Text.Length != 0 && numBox.Text.Length != 0 && addressBox.Text.Length != 0)
            {
                if (validate_emailaddress.IsMatch(middleBox.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    middleBox.Focus();
                    return;
                }
                else
                {
                    FileStream fileStream = new FileStream("Contact.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    name = nameBox.Text;
                    middle = middleBox.Text;
                    last = lastBox.Text;
                    number = numBox.Text;
                    address = addressBox.Text;
                    if (male.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    File.Copy(path.Text, Path.Combine(@"Images\", Path.GetFileName(path.Text)), true);
                    streamWriter.WriteLine("____________________________________"); streamWriter.WriteLine("Name: " + name); streamWriter.WriteLine("Surname: " + last); streamWriter.WriteLine("Email: " + middle); streamWriter.WriteLine("Number: " + number); streamWriter.WriteLine("Address: " + address); streamWriter.WriteLine("Gender: " + gender); streamWriter.WriteLine("Photo: " + imagepath3); streamWriter.Close(); fileStream.Close();
                    DialogResult result = MessageBox.Show("Contact Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        nameBox.Text = ""; lastBox.Text = ""; middleBox.Text = ""; numBox.Text = "";
                        addressBox.Text = ""; male.Checked = false; female.Checked = false;
                        pictureBox1.Image = Properties.Resources.icons8_person_100__1_;
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all required fields", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); this.Hide(); form.Show();
        }
    }
}
