using MvcExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcExample.View
{
    public partial class MainForm : Form
    {
        public event EventHandler AddPerson;
        private PersonController controller;
        public string Names => textBox1.Text;
        public int Age => int.TryParse(textBox2.Text, out int age) ? age : 0;

        public MainForm()
        {
            InitializeComponent(GetName());
            controller = new PersonController(this);
        }

        public void DisplayResult(string result)
        {
            label1.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson?.Invoke(this, EventArgs.Empty);
        }
    }
}
