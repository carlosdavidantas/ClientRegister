using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.BackEnd;

namespace Client.Forms
{
    public partial class ClientRegisterForm : Form
    {
        private DataBase _dataBase = new DataBase();
        private ClientClass _client;
        private bool _edit;

        public ClientRegisterForm(bool edit = false, ClientClass client = null)
        {
            this._edit = edit;
            _client = client;

            InitializeComponent();
            if(_edit == true )
            {
                RegisterClientButton.Text = "Update";
                Update();
            }
            else
            {
                RegisterClientButton.Text = "Register";
            }
        }

        private void Update()
        {
            NameTextBox.Text = _client.name;
            AgeTextBox.Text = _client.age;
            GenderTextBox.Text = _client.gender;
            IdentificationTextBox.Text = _client.id;
        }

        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            if(_edit == false)
            {
                ClientClass newClient = new ClientClass(default, default, default, default);
                newClient.name = NameTextBox.Text;
                newClient.age = AgeTextBox.Text;
                newClient.gender = GenderTextBox.Text;
                newClient.id = IdentificationTextBox.Text;

                _dataBase.InsertClient(newClient);
                this.Close();
                MessageBox.Show("Client registered successfully!");
            }
            else
            {
                ClientClass newClient = new ClientClass(default, default, default, default);
                newClient.name = NameTextBox.Text;
                newClient.age = AgeTextBox.Text;
                newClient.gender = GenderTextBox.Text;
                newClient.id = IdentificationTextBox.Text;

                _dataBase.EditClientInfo(_client.id, newClient);
                this.Close();
                MessageBox.Show("Client modified successfully!");
            }
        }
    }
}
