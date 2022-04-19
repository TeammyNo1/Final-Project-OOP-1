using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_OOP.Parking
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }
        Codepay coupon = new Codepay();
        Buy saleManagement = new Buy();
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string totalcoupon = this.textBox1.Text;
            double Coupon = Convert.ToDouble(totalcoupon);
            coupon.create(Coupon);

            double totalCoupon = coupon.getCoupon();
            textBox2.Text = totalCoupon.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pay = this.textBox2.Text;
            string getmoney = this.textBox3.Text;

            double Pay = Convert.ToDouble(pay);
            double GetMoney = Convert.ToDouble(getmoney);
            saleManagement.Bill(Pay, GetMoney);
            double Tpay = saleManagement.payBill();
            textBox4.Text = Tpay.ToString();
        }
    }
}
