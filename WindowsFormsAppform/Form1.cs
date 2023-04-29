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
using Models;
using System.ComponentModel.DataAnnotations;

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
                employee_model empdatamodel = new employee_model();
                empdatamodel.Name = txtName.Text;
                empdatamodel.Email = txtEmail.Text;
                ValidationContext vali = new ValidationContext(empdatamodel);
                List<ValidationResult> errorlist = new List<ValidationResult>();    
                var error = string.Empty;
                if(!Validator.TryValidateObject(empdatamodel,vali,errorlist,true))
                {
                    foreach(ValidationResult result1 in errorlist)
                    {
                        error = error + result1.ErrorMessage + "\r\n";

                    }
                    MessageBox.Show(error);
                    return;
                }

                var data = new employeedata();
                
                 bool result = data.saveemp(empdatamodel);
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
