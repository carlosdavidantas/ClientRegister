using Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class InicialForm : Form
    {
        public InicialForm()
        {
            InitializeComponent();
        }

        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            ClientRegisterForm clientRegisterForm = new ClientRegisterForm();
            clientRegisterForm.Show();
        }

        private void SearchClientButton_Click(object sender, EventArgs e)
        {
            SearchClientForm searchClientForm = new SearchClientForm();
            searchClientForm.Show();
        }
    }
}
