using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public decimal first_op;
        public decimal second_op;
        public decimal res;
        enum op
        {
            plus,
            minus,
            mul,
            div
        }
        op curr_op = op.plus;
        public Form1()
        {
            InitializeComponent();
            //not need Icon = (Properties.Resources.ico1);
        }

        private void bt_bs_Click(object sender, EventArgs e)
        {
            if(tb_calc.Text.Length > 0)
            {
                tb_calc.Text=tb_calc.Text.Substring(0,tb_calc.Text.Length - 1);
            }
        }
        private void tb_calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                if (!(e.KeyChar == '-' && (sender as TextBox).Text.Length == 0))
                    e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.Length == 0 || ((sender as TextBox).Text[0] =='-' && (sender as TextBox).Text.Length == 1 ) || ((sender as TextBox).Text.IndexOf('.') > -1))
                    e.Handled = true;
            }
        }
        private void set_op(op this_op)
        {
            if (tb_calc.Text.Length > 0)
            {
                first_op = Convert.ToDecimal(tb_calc.Text);
                curr_op = this_op;
            }
        }
        private void bt_plus_Click(object sender, EventArgs e)
        {
            set_op(op.plus);
            tb_calc.Text = String.Empty;
        }
        private void bt_min_Click(object sender, EventArgs e)
        {
            set_op(op.minus);
            tb_calc.Text = String.Empty;
        }
        private void bt_mul_Click(object sender, EventArgs e)
        {
            set_op(op.mul);
            tb_calc.Text = String.Empty;
        }
        private void bt_div_Click(object sender, EventArgs e)
        {
            set_op(op.div);
            tb_calc.Text = String.Empty;
        }
        private void do_op()
        {
            switch (curr_op)
            {
                case op.plus:
                    res = first_op + second_op;
                    break;
                case op.minus:
                    res = first_op - second_op;
                    break;
                case op.mul:
                    res = first_op * second_op;
                    break;
                case op.div:
                    res = first_op / second_op;
                    break;
                 default:
                    break;
            }
        }
        private void bt_res_Click(object sender, EventArgs e)
        {
            if (tb_calc.Text.Length > 0)
            {
                second_op=Convert.ToDecimal(tb_calc.Text);
                do_op();
                tb_calc.Text = res.ToString();
            }
        }

        private void bt_plusminus_Click(object sender, EventArgs e)
        {
            tb_calc.Text = (-Convert.ToDecimal(tb_calc.Text)).ToString();
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send(",");
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("0");
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tb_calc.Focus();
            SendKeys.Send("9");
        }

        private void bt_per_Click(object sender, EventArgs e)
        {
            second_op = first_op * Convert.ToDecimal(tb_calc.Text) / (Decimal)100;
            tb_calc.Text = second_op.ToString();
        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            first_op = 0;
            res = 0;
            tb_calc.Text = res.ToString();
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            first_op = 0;
            second_op = 0;
            res = 0;
            tb_calc.Text = res.ToString();
        }

        private void bt_1divx_Click(object sender, EventArgs e)
        {
            tb_calc.Text = (1 / Convert.ToDecimal(tb_calc.Text)).ToString();
        }

        private void bt_x2_Click(object sender, EventArgs e)
        {
            tb_calc.Text = (Convert.ToDecimal(tb_calc.Text)*Convert.ToDecimal(tb_calc.Text)).ToString();
        }

        private void bt_sqrt_Click(object sender, EventArgs e)
        {
            tb_calc.Text = (Math.Sqrt(Convert.ToDouble(tb_calc.Text))).ToString();
        }
    }
}
