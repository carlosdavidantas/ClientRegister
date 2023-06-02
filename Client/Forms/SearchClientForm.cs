using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.BackEnd;

namespace Client.Forms
{
    public partial class SearchClientForm : Form
    {
        private DataBase _dataBase = new DataBase();
        ClientClass clientFinded = new ClientClass(default, default, default, default);

        public SearchClientForm()
        {
            InitializeComponent();
        }

        private void SearchClientButton_Click(object sender, EventArgs e)
        {
            clientFinded = _dataBase.SearchClient(InsertIdTextBox.Text);
            if (clientFinded.name == "")
            {
                string notFounded = "Not found";
                clientFinded.name = notFounded;
                clientFinded.age = notFounded;
                clientFinded.gender = notFounded;
                ModifyClientButton.Enabled = false;
                DeleteClientButton.Enabled = false;
                UpdateFrame();
                return;
            }
            ModifyClientButton.Enabled = true;
            DeleteClientButton.Enabled = true;
            UpdateFrame();
        }

        private void UpdateFrame()
        {
            NameToChangeLabel.Text = "";
            AgeToChangeLabel.Text = "";
            GenderToChangeLabel.Text = "";

            NameToChangeLabel.Text = clientFinded.name;
            AgeToChangeLabel.Text = clientFinded.age;
            GenderToChangeLabel.Text = clientFinded.gender;
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            _dataBase.DeleteClient(clientFinded.id);
            this.Close();
            MessageBox.Show("Client deleted successfully!");
        }

        private void ModifyClientButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientRegisterForm clientRegisterForm = new ClientRegisterForm(true, clientFinded);
            clientRegisterForm.ShowDialog();
        }
    }
}
