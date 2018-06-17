using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecryptMe {
public partial class Form1 : Form {

    public Form1() { 
    InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
    DMSEC.BitType bits = (DMSEC.BitType)Enum.Parse(typeof(DMSEC.BitType), comboBox1.Text);
    DMSEC enr = new DMSEC();
    textBox2.Text = enr.Encrypt(textBox1.Text, textBox3.Text, bits);
    textBox2.Focus();
    }

    private void button2_Click(object sender, EventArgs e) {
    DMSEC.BitType bits = (DMSEC.BitType)Enum.Parse(typeof(DMSEC.BitType), comboBox1.Text);
    DMSEC enr = new DMSEC();
    textBox2.Text = enr.Decrypt(textBox1.Text, textBox3.Text, bits);
    textBox2.Focus();
    }

    private void Form1_Load(object sender, EventArgs e) {
    comboBox1.SelectedItem = "S256";
    textBox3.Focus();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

}
}
