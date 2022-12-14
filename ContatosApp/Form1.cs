using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContatosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0. \nWritten by: Priscila Falcão", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contatosDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contatosDBDataSet.People);
            // TODO: This line of code loads data into the 'contatosDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contatosDBDataSet.People);
            // TODO: This line of code loads data into the 'contatosDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contatosDBDataSet.People);

        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosDBDataSet);

        }

        private void peopleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosDBDataSet);

        }
    }
}
