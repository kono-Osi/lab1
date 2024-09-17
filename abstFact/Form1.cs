using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstFactLibrary;

namespace abstFact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AFact Factory;
        AShelf Shelf;
        ATable Table;
        AChair Chair;

        private void button1_Click(object sender, EventArgs e)
        {
            Shelf =  Factory.createShelf();
            Table = Factory.createTable();
            Chair = Factory.createChair();
            MessageBox.Show(Shelf.Name);
            MessageBox.Show(Table.Name);
            MessageBox.Show(Chair.Name);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           Factory = new FactClassic();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Factory = new Factminimal();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Factory = new FactModern();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
