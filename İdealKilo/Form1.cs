using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İdealKilo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char cinsiyet;
            double boy, yas, ideal;

            cinsiyet = Convert.ToChar(comboBox1.Text);
            boy = Convert.ToDouble(textBox1.Text);
            yas = Convert.ToDouble(textBox2.Text);

            if (cinsiyet == 'K')
            {
                ideal= (boy-100+(yas/10))*0.8;
                label5.Text = ideal.ToString();
            }

            if(cinsiyet=='E')
            {
                ideal = (boy - 100 + (yas / 10)) * 0.9;
                label5.Text = ideal.ToString();
            }

        }
    }
}
