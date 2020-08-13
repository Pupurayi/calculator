using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 655;
            lbl.Width = 613;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 331;
            lbl.Width = 296;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 655;
            lbl.Width = 613;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((lbl.Text == "0") || (enter_value))
                lbl.Text = "";

            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!lbl.Text.Contains("."))
                    lbl.Text = lbl.Text + num.Text;
            }
            else
                lbl.Text = lbl.Text + num.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
            lblShowOp.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
            lblShowOp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        if (lbl.Text.Length >0)
        {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1, 1);
        }

            if (lbl.Text == "")
            {
                lbl.Text ="0";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            try {
                Button num = (Button)sender;
                operation = num.Text;
                results = Double.Parse(lbl.Text);
                lbl.Text = "";
                lblShowOp.Text = System.Convert.ToString(results) + "" + operation;
                 }
                
           catch {
           // statement showing how the exception is going to be handled
                 }
               

        }

        private void lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEqoz_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = ""; 
            switch (operation)
        {
                case "+":
                    lbl.Text = (results + Double.Parse(lbl.Text)).ToString();
                    break;
                case "-":
                    lbl.Text = (results - Double.Parse(lbl.Text)).ToString();
                    break;
                case "*":
                    lbl.Text = (results * Double.Parse(lbl.Text)).ToString();
                    break;
                case "/":
                    lbl.Text = (results / Double.Parse(lbl.Text)).ToString();
                    break;
                case "Mod":
                    lbl.Text = (results % Double.Parse(lbl.Text)).ToString();
                    break;
                case "Exp":
                double i = Double.Parse(lbl.Text);
                    double q;
                q = (results);
                    lbl.Text = Math.Exp(i*Math.Log(q*4)).ToString();
                    break;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lbl.Text = "3.141592653589";
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (lbl.Text) + ")");
            ilog = Math.Log10(ilog);
            lbl.Text = System.Convert.ToString(ilog);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("sqr" + "(" + (lbl.Text) + ")");
            sq = Math.Sqrt(sq);
            lbl.Text = System.Convert.ToString(sq);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Double a;
            a= Convert.ToDouble(lbl.Text) * Convert.ToDouble(lbl.Text);
            lbl.Text = System.Convert.ToString(a);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (lbl.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            lbl.Text = System.Convert.ToString(qSinh);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (lbl.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            lbl.Text = System.Convert.ToString(qCosh);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (lbl.Text) + ")");
            qSin = Math.Sin(qSin);
            lbl.Text = System.Convert.ToString(qSin);
        }

        private void buttoncos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (lbl.Text) + ")");
            qCos = Math.Cos(qCos);
            lbl.Text = System.Convert.ToString(qCos);
        }

        private void buttontanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (lbl.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            lbl.Text = System.Convert.ToString(qTanh);
        }

        private void buttontan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(lbl.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (lbl.Text) + ")");
            qTan = Math.Tan(qTan);
            lbl.Text = System.Convert.ToString(qTan);
        }

        private void buttonbin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl.Text);
            lbl.Text = System.Convert.ToString(a,2);
        }

        private void buttonhex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl.Text);
            lbl.Text = System.Convert.ToString(a,16);
        }

        private void buttonoct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl.Text);
            lbl.Text = System.Convert.ToString(a,8);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl.Text);
            lbl.Text = System.Convert.ToString(a);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(lbl.Text) * Convert.ToDouble(lbl.Text) * Convert.ToDouble(lbl.Text);
            lbl.Text = System.Convert.ToString(a);
        }

        private void button1x_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/Convert.ToDouble(lbl.Text));
            lbl.Text = System.Convert.ToString(a);
        }

        private void buttonlnx_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(lbl.Text);
            ilog = Math.Log(ilog);
            lbl.Text = System.Convert.ToString(ilog);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(lbl.Text) / Convert.ToDouble(100);
            lbl.Text = System.Convert.ToString(a);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
   