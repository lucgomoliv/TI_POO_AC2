using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_POO_AC2
{
    public partial class Form1 : Form
    {
        ConvIEEE754 convIEEE754 = new ConvIEEE754();
        ConvHexadecimal convHexadecimal = new ConvHexadecimal();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            txtIEE754.Text = convIEEE754.Converter(double.Parse(txtNum1.Text));
            txtHexa.Text = convHexadecimal.Converter(txtIEE754.Text);
        }
    }
}
