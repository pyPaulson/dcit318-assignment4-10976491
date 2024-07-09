dotusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Saved Information");
        }
    }
}
