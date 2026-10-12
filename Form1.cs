namespace Sample_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtStudentName.Text);
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
             double.TryParse(txtAmount.Text, out var amount);
             double discountAmount = 0;
            /*
             if (rdoNoDiscount.Checked)
             {
                 txtDiscAmount.Text = discountAmount.ToString("N2");
                 txtTotal.Text = amount.ToString("N2");
             }

             if (rdo5Percent.Checked)
             {
                 discountAmount = 0.05;
                 amount = amount - (amount * discountAmount);
                 txtDiscAmount.Text = discountAmount.ToString("N2");
                 txtTotal.Text = amount.ToString("N2");
             }

             if (rdo12Percent.Checked)
             {
                 discountAmount = 0.12;
                 amount = amount - (amount * discountAmount);
                 txtDiscAmount.Text = discountAmount.ToString("N2");
                 txtTotal.Text = amount.ToString("N2");
             }
            */


            if (cboDiscount.Text == "No Discount")
            {
                rtxtResults.AppendText(discountAmount.ToString("N2") + Environment.NewLine);
                rtxtResults.AppendText(amount.ToString("N2"));
            }

            if (cboDiscount.Text == "5%")
            {
                discountAmount = 0.05;
                amount = amount - (amount * discountAmount);
                rtxtResults.AppendText(discountAmount.ToString("N2") + Environment.NewLine);
                rtxtResults.AppendText(amount.ToString("N2"));
            }

            if (cboDiscount.Text == "12%")
            {
                discountAmount = 0.12;
                amount = amount - (amount * discountAmount);
                rtxtResults.AppendText(discountAmount.ToString("N2") + Environment.NewLine);
                rtxtResults.AppendText(amount.ToString("N2"));
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiscAmount.Clear();
            txtTotal.Clear();
            rdo12Percent
        }
    }
}
