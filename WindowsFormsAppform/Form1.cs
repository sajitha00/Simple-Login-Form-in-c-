using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace WindowsFormsAppform
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();

        }
        private void save()
        {
            try
            {
                var data = new employeedata();
                bool result = data.saveemp(txtName.Text,txtEmail.Text);
                if(result)
                {
                    MessageBox.Show("Save done");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
