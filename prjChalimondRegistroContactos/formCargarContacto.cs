using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChalimondRegistroContactos
{
    public partial class formCargarContacto : Form
    {
        public formCargarContacto()
        {
            InitializeComponent();
        }

        string contactName;
        string contactPhone;
        int contactNumber = 0;



  

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtContactName.Text == "" || maskPhoneNumber.Text == "")
            {
                MessageBox.Show("Rellene los campos");
            }
            else
            {
                createContact();
            }
           
        }

        private void createContact()
        {
            contactName = txtContactName.Text;
            contactPhone = maskPhoneNumber.Text;
            contactNumber++;

            txtContactName.Clear();
            maskPhoneNumber.Clear();

            lstContacts.Items.Add($"{contactNumber}) {contactName} - {contactPhone}");

            txtContactName.Focus();

        }

        private void formCargarContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
