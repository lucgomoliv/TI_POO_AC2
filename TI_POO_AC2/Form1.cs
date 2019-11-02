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
            txtIEEE7541.Text = convIEEE754.Converter(double.Parse(txtNum1.Text));
            txtIEEE7542.Text = convIEEE754.Converter(double.Parse(txtNum2.Text));
            txtHexa1.Text = convHexadecimal.Converter(txtIEEE7541.Text);
            txtHexa2.Text = convHexadecimal.Converter(txtIEEE7542.Text);
        }
    }
}
