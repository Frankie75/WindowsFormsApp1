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
        public Form1()
        {
            InitializeComponent();
            var button = new Button()

            {
                Bounds = new Rectangle(0, 0, 100, 50),
                Text = "Hello",
                BackColor = Color.Yellow,


            };


            this.Controls.Add(button);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
