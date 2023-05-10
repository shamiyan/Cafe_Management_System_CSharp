using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtafricancoffee.Text = "0";
            txtamericancoffee.Text = "0";
            txtblackforest.Text = "0";
            txtbostoncream.Text = "0";
            txtcappuccino.Text = "0";
            txtcarltonhill.Text = "0";
            txtcoffeecake.Text = "0";
            txtespresso.Text = "0";
            txticedcappuccino.Text = "0";
            txticedlatte.Text = "0";
            txtkilburnchocolate.Text = "0";
            txtlagoschocolate.Text = "0";
            txtlatte.Text = "0";
            txtqueenpark.Text = "0";
            textBox10txtredvelvet.Text = "0";
            txtvalecoffee.Text = "0";
            lblcoc.Text = "0";
            lblcod.Text = "0";
            lblsc.Text = "1.75";
            lblsubtotal.Text = "0";
            lblTax.Text = "0";
            lbltotal.Text = "0";

            chkafricancoffee.Checked = false;
            chkamericancoffee.Checked = false;
            chkblackforest.Checked = false;
            chkbostoncream.Checked = false;
            chkcappuccino.Checked = false;
            chkcarltonhillchocolate.Checked = false;
            chkcoffee.Checked = false;
            chkespresso.Checked = false;
            chkicedcappuccino.Checked = false;
            chkicedlatte.Checked = false;
            chkkilburnchocolate.Checked = false;
            chklagoschocolate.Checked = false;
            chklatte.Checked = false;
            chkqueenparkchocolate.Checked = false;
            chkredvalvet.Checked = false;
            chkvalecoffe.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();


            txtafricancoffee.Text = "0";
            txtamericancoffee.Text = "0";
            txtblackforest.Text = "0";
            txtbostoncream.Text = "0";
            txtcappuccino.Text = "0";
            txtcarltonhill.Text = "0";
            txtcoffeecake.Text = "0";
            txtespresso.Text = "0";
            txticedcappuccino.Text = "0";
            txticedlatte.Text = "0";
            txtkilburnchocolate.Text = "0";
            txtlagoschocolate.Text = "0";
            txtlatte.Text = "0";
            txtqueenpark.Text = "0";
            textBox10txtredvelvet.Text = "0";
            txtvalecoffee.Text = "0";
            lblcoc.Text = "0";
            lblcod.Text = "0";
            lblsc.Text = "1.75";

            txtlatte.Enabled = false;
            txtespresso.Enabled = false;
            txticedlatte.Enabled = false;
            txtvalecoffee.Enabled = false;
            txtcappuccino.Enabled = false;
            txtafricancoffee.Enabled = false;
            txtamericancoffee.Enabled = false;
            txticedcappuccino.Enabled = false;
            txtcoffeecake.Enabled = false;
            textBox10txtredvelvet.Enabled = false;
            txtblackforest.Enabled = false;
            txtbostoncream.Enabled = false;
            txtlagoschocolate.Enabled = false;
            txtkilburnchocolate.Enabled = false;
            txtcarltonhill.Enabled = false;
            txtqueenpark.Enabled = false;

            chkafricancoffee.Checked = false;
            chkamericancoffee.Checked = false;
            chkblackforest.Checked = false;
            chkbostoncream.Checked = false;
            chkcappuccino.Checked = false;
            chkcarltonhillchocolate.Checked = false;
            chkcoffee.Checked = false;
            chkespresso.Checked = false;
            chkicedcappuccino.Checked = false;
            chkicedlatte.Checked = false;
            chkkilburnchocolate.Checked = false;
            chklagoschocolate.Checked = false;
            chklatte.Checked = false;
            chkqueenparkchocolate.Checked = false;
            chkredvalvet.Checked = false;
            chkvalecoffe.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chklatte_CheckedChanged(object sender, EventArgs e)
        {
            if(chklatte.Checked == true)
            {
                txtlatte.Enabled = true;
            }
            if(chklatte.Checked == false)
            {
                txtlatte.Enabled = false;
                txtlatte.Text = "0";
            }
        }

        private void txtlatt_click(object sender, EventArgs e)
        {
            txtlatte.Text = "";
            txtlatte.Focus();
        }

        private void chkespresso_CheckedChanged(object sender, EventArgs e)
        {
            if(chkespresso.Checked == true)
            {
                txtespresso.Enabled = true;
            }
            if(chkespresso.Checked == false)
            {
                txtespresso.Enabled = false;
                txtespresso.Text = "0";
            }
        }

        private void txtespresso_Click(object sender, EventArgs e)
        {
            txtespresso.Text = "";
            txtespresso.Focus();
        }

        private void chkicedlatte_CheckedChanged(object sender, EventArgs e)
        {
            if(chkicedlatte.Checked == true)
            {
                txticedlatte.Enabled = true;
            }
            if(chkicedlatte.Checked == false)
            {
                txticedlatte.Enabled = false;
                txticedlatte.Text = "0";
            }
        }

        private void txticedlatte_Click(object sender, EventArgs e)
        {
            txticedlatte.Text = "";
            txticedlatte.Focus();
        }

        private void chkvalecoffe_CheckedChanged(object sender, EventArgs e)
        {
            if(chkvalecoffe.Checked == true)
            {
                txtvalecoffee.Enabled = true;
            }
            if(chkvalecoffe.Checked == false)
            {
                txtvalecoffee.Enabled = false;
                txtvalecoffee.Text = "0";
            }
        }

        private void txtvalecoffee_Click(object sender, EventArgs e)
        {
            txtvalecoffee.Text = "";
            txtvalecoffee.Focus();
        }

        private void chkcappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if(chkcappuccino.Checked == true)
            {
                txtvalecoffee.Enabled = true;
            }
            if(chkcappuccino.Checked == false)
            {
                txtcappuccino.Enabled = false;
                txtcappuccino.Text = "0";
            }
        }

        private void txtcappuccino_Click(object sender, EventArgs e)
        {
            txtcappuccino.Text = "";
            txtcappuccino.Focus();
        }

        private void chkafricancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(chkafricancoffee.Checked == true)
            {
                txtafricancoffee.Enabled = true;
            }
            if(chkafricancoffee.Checked == false)
            {
                txtafricancoffee.Enabled = false;
                txtafricancoffee.Text = "0";
            }
        }

        private void txtafricancoffee_Click(object sender, EventArgs e)
        {
            txtafricancoffee.Text = "";
            txtafricancoffee.Focus();
        }

        private void chkamericancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(chkamericancoffee.Checked == true)
            {
                txtamericancoffee.Enabled = true;
            }
            if(chkamericancoffee.Checked == false)
            {
                txtamericancoffee.Enabled = false;
                txtamericancoffee.Text = "0";
            }
        }

        private void txtamericancoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtamericancoffee_Click(object sender, EventArgs e)
        {
            txtamericancoffee.Text = "";
            txtamericancoffee.Focus();
        }

        private void chkicedcappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if(chkicedcappuccino.Checked == true)
            {
                txticedcappuccino.Enabled = true;
            }
            if(chkicedcappuccino.Checked == false)
            {
                txticedcappuccino.Enabled = false;
                txticedcappuccino.Text = "0";
            }
        }

        private void txticedcappuccino_Click(object sender, EventArgs e)
        {
            txticedcappuccino.Text = "";
            txticedcappuccino.Focus();
        }

        private void chkcoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(chkcoffee.Checked == true)
            {
                txtcoffeecake.Enabled = true;
            }
            if(chkcoffee.Checked == false)
            {
                txtcoffeecake.Enabled = false;
                txtcoffeecake.Text = "0";
            }
        }

        private void txtcoffeecake_Click(object sender, EventArgs e)
        {
            txtcoffeecake.Text = "";
            txtcoffeecake.Focus();
        }

        private void chkredvalvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkredvalvet.Checked == true)
            {
                textBox10txtredvelvet.Enabled = true;
            }
            if (chkcoffee.Checked == false)
            {
                textBox10txtredvelvet.Enabled = false;
                textBox10txtredvelvet.Text = "0";
            }
        }

        private void textBox10txtredvelvet_Click(object sender, EventArgs e)
        {
            textBox10txtredvelvet.Text = "";
            textBox10txtredvelvet.Focus();
        }

        private void chkblackforest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkblackforest.Checked == true)
            {
                txtblackforest.Enabled = true;
            }
            if (chkblackforest.Checked == false)
            {
                txtblackforest.Enabled = false;
                txtblackforest.Text = "0";
            }
        }

        private void txtblackforest_Click(object sender, EventArgs e)
        {
            txtblackforest.Text = "";
            txtblackforest.Focus();
        }

        private void chkbostoncream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbostoncream.Checked == true)
            {
                txtbostoncream.Enabled = true;
            }
            if (chkbostoncream.Checked == false)
            {
                txtbostoncream.Enabled = false;
                txtbostoncream.Text = "0";
            }
        }

        private void txtbostoncream_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbostoncream_Click(object sender, EventArgs e)
        {
            txtbostoncream.Text = "0";
            txtbostoncream.Focus();
        }

        private void chklagoschocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chklagoschocolate.Checked == true)
            {
                txtlagoschocolate.Enabled = true;
            }
            if (chklagoschocolate.Checked == false)
            {
                txtlagoschocolate.Enabled = false;
                txtlagoschocolate.Text = "0";
            }
        }

        private void txtlagoschocolate_Click(object sender, EventArgs e)
        {
            txtlagoschocolate.Text = "";
            txtlagoschocolate.Focus();
        }

        private void chkkilburnchocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkilburnchocolate.Checked == true)
            {
                txtkilburnchocolate.Enabled = true;
            }
            if (chkkilburnchocolate.Checked == false)
            {
                txtkilburnchocolate.Enabled = false;
                txtkilburnchocolate.Text = "0";
            }
        }

        private void txtkilburnchocolate_Click(object sender, EventArgs e)
        {
            txtkilburnchocolate.Text = "";
            txtkilburnchocolate.Focus();
        }

        private void chkcarltonhillchocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcarltonhillchocolate.Checked == true)
            {
                txtcarltonhill.Enabled = true;
            }
            if (chkcarltonhillchocolate.Checked == false)
            {
                txtcarltonhill.Enabled = false;
                txtcarltonhill.Text = "0";
            }
        }

        private void txtcarltonhill_Click(object sender, EventArgs e)
        {
            txtcarltonhill.Text = "";
            txtcarltonhill.Focus();
        }

        private void chkqueenparkchocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqueenparkchocolate.Checked == true)
            {
                txtqueenpark.Enabled = true;
            }
            if (chkqueenparkchocolate.Checked == false)
            {
                txtqueenpark.Enabled = false;
                txtqueenpark.Text = "0";
            }
        }

        private void txtqueenpark_Click(object sender, EventArgs e)
        {
            txtqueenpark.Text = "";
            txtqueenpark.Focus();
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t" + "KIET CAFE" + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("latte \t\t\t\t\t\t" +txtlatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t\t" + txtespresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t\t" + txticedlatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee \t\t\t\t" + txtvalecoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t\t\t" + txtcappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t\t\t" + txtafricancoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("American Coffee \t\t\t\t" + txtamericancoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t\t" + txticedlatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake \t\t\t\t" + txtcoffeecake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet Cake \t\t\t\t" + textBox10txtredvelvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t\t" + txtblackforest.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake \t\t\t" + txtbostoncream.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake \t\t\t" + txtlagoschocolate.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate Cake \t\t" + txtkilburnchocolate.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Chocolate Cake \t\t" + txtcarltonhill.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen's Park Chocolate Cake \t" + txtqueenpark.Text + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t" + lblsubtotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t\t\t" + lbltotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t\t\t\t" + lblDate.Text);
        }

        private void pri(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear(); 
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.FileName = "NotePad Text";
            SaveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(SaveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;
            double latte, ilatte, espresson, capp, icapp, acoffee, amcoffee, vale;
            double cCake, rVelvet, bForest, cBoston, cLagos, ckilburn, ccaelton, cQueen;

            latte = 1.20;espresson = 1.29;ilatte = 1.50;vale = 1.45;acoffee = 1.50;amcoffee = 1.45; capp = 1.70;icapp = 1.10;
            double Latte_coffee = Convert.ToDouble(txtlatte.Text);
            double esprosson = Convert.ToDouble(txtespresso.Text);
            double IcedLatte = Convert.ToDouble(txticedlatte.Text);
            double vale_coff = Convert.ToDouble(txtvalecoffee.Text);
            double Afri_coff = Convert.ToDouble(txtafricancoffee.Text);
            double Amer_coff = Convert.ToDouble(txtamericancoffee.Text);
            double Capp_coff = Convert.ToDouble(txtcappuccino.Text);
            double icapp_coff    = Convert.ToDouble(txticedcappuccino.Text);

            cCake = 1.30; rVelvet = 1.20; bForest = 1.30; cBoston = 1.90; cLagos = 1.50; ckilburn = 1.40; ccaelton = 1.30; cQueen = 1.10;
            double c_Cake = Convert.ToDouble(txtcoffeecake.Text);
            double vl_Cake = Convert.ToDouble(textBox10txtredvelvet.Text);
            double bf_Cake = Convert.ToDouble(txtblackforest.Text);
            double cb_Cake = Convert.ToDouble(txtbostoncream.Text);
            double cl_Cake = Convert.ToDouble(txtlagoschocolate.Text);
            double ck_Cake = Convert.ToDouble(txtkilburnchocolate.Text);
            double cc_Cake = Convert.ToDouble(txtcarltonhill.Text);
            double cq_Cake = Convert.ToDouble(txtqueenpark.Text);

            Cafe eat_in_Cafe = new Cafe(Latte_coffee,esprosson,IcedLatte,vale_coff,Afri_coff,Amer_coff,Capp_coff,icapp_coff,c_Cake,vl_Cake,bf_Cake,
                cb_Cake,cl_Cake,ck_Cake,cc_Cake,cq_Cake);

            double cost_Of_drink = (Latte_coffee * latte) + (espresson * espresson) + (IcedLatte * ilatte) + (vale_coff * vale)
                + (Afri_coff * acoffee) + (Capp_coff * capp) + (icapp_coff * icapp);
            lblcod.Text = Convert.ToString(cost_Of_drink);

            double cost_of_cakes = (c_Cake * cCake) + (vl_Cake * rVelvet) + (bf_Cake * bForest) + (cb_Cake * cBoston)
                + (cl_Cake * cLagos) + (cc_Cake * ccaelton) + (ck_Cake * ckilburn);
            lblcoc.Text = Convert.ToString(cost_of_cakes);

            double service_charges = Convert.ToDouble(lblsc.Text);

            lblsubtotal.Text = Convert.ToString(cost_of_cakes + cost_Of_drink + service_charges);
            lblTax.Text = Convert.ToString(((cost_of_cakes + cost_Of_drink + service_charges) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lbltotal.Text = Convert.ToString(cost_of_cakes + cost_Of_drink + iTax + service_charges);

            lblcoc.Text = String.Format("{0:C}", cost_of_cakes);
            lblcod.Text = String.Format("{0:C}", cost_Of_drink);
            lblsc.Text = String.Format("{0:C}", service_charges);
            lblsubtotal.Text = String.Format("{0:C}", (cost_of_cakes + cost_Of_drink + service_charges));
            lblTax.Text = String.Format("{0:C}", iTax);
            lbltotal.Text = String.Format("{0:C}", (cost_of_cakes + cost_Of_drink + service_charges + iTax));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
