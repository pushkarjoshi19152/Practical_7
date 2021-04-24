using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataSet d1 = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

                d1.ReadXml("C:/Users/win/source/repos/WinFormsApp1/WinFormsApp1/XMLFile1.xml");

                dataGridView1.DataSource = d1;
                dataGridView1.DataMember = "authors";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            d1.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
