using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //create domain objects
        City city = new City();
        Fruits fruits = new Fruits();
        Gender gender = new Gender();
        Person person = new Person();
        bool IsValidName = false;
        bool IsValidAge = false;
        //ComboBox mybox = new ComboBox();
        public Form1()
        {
            InitializeComponent();
            combCity.Items.Add("pretoria");
            combCity.Items.Add("joburg");
            combCity.Items.Add("cape town");
            combCity.Items.Add(" mafikeng");

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bSubmit_Click(object sender, EventArgs e)
        {

            person.PersonName = txtFirstName.Text;
            MessageBox.Show($"The name of the person is: { person.PersonName}");
            //MessageBox.Show("submitted", "Information", MessageBoxButtons.OKCancel,
            //MessageBoxIcon.Information);
                
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string OldText = "";
            if (txtFirstName.Text.All(chr => char.IsLetter(chr)))

            {
                OldText = txtFirstName.Text;
                txtFirstName.Text = OldText;


                txtFirstName.BackColor = System.Drawing.Color.White;
                txtFirstName.ForeColor = System.Drawing.Color.Black;
                IsValidName = true;
                bSubmit.Enabled = true;
            }


            else
            {
               
                txtFirstName.BackColor = System.Drawing.Color.Red;
                txtFirstName.ForeColor = System.Drawing.Color.White;
                IsValidName = false;
                bSubmit.Enabled = false;

            }






        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //creating combobox using combobox class
            //ComboBox mybox = new ComboBox();

            // adding elements in the combobox
            

            //add this combobo to form
            //this.Controls.Add(mybox);

        }
    }
}


    
    

