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
        ULA32BITS ula = new ULA32BITS();
        ConvBitToBool conv = new ConvBitToBool();
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
            bool[] num1 = conv.Operar(txtIEEE7541.Text);
            bool[] num2 = conv.Operar(txtIEEE7542.Text);
            bool[] op = new bool[4];
            if (radioSoma.Checked) op = new bool[] { true, false, false };
            else if (radioSub.Checked) op = new bool[] { true, false, true };
            else if (radioMult.Checked) op = new bool[] { true, true, false };
            else if (radioDiv.Checked) op = new bool[] { true, true, true };
            txtIEEE754Reusltado.Text = conv.Operar(ula.Operar(num1, num2, op, out _));
            txtResultado.Text = convIEEE754.Converter(txtIEEE754Reusltado.Text).ToString();
        }
    }
}
