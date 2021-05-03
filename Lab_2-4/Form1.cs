using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Storage;

namespace Lab_2_4
{
    public partial class Form1 : Form
    {
        Storage data = Storage.Instance;
        public Form1()
        {
            InitializeComponent();
            tabsContainer.Bind = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
