namespace Sample_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentName = new TextBox();
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            rdo12Percent = new RadioButton();
            rdo5Percent = new RadioButton();
            rdoNoDiscount = new RadioButton();
            lblAmount = new Label();
            txtAmount = new TextBox();
            txtDiscAmount = new TextBox();
            lblDiscount = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnCompute = new Button();
            btnClear = new Button();
            lblChooseDiscount = new Label();
            cboDiscount = new ComboBox();
            rtxtResults = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(253, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(323, 49);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(365, 35);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(58, 127);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 77);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo12Percent);
            groupBox1.Controls.Add(rdo5Percent);
            groupBox1.Controls.Add(rdoNoDiscount);
            groupBox1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(61, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 163);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Discount:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdo12Percent
            // 
            rdo12Percent.AutoSize = true;
            rdo12Percent.Location = new Point(22, 94);
            rdo12Percent.Name = "rdo12Percent";
            rdo12Percent.Size = new Size(67, 32);
            rdo12Percent.TabIndex = 8;
            rdo12Percent.TabStop = true;
            rdo12Percent.Text = "12%";
            rdo12Percent.UseVisualStyleBackColor = true;
            // 
            // rdo5Percent
            // 
            rdo5Percent.AutoSize = true;
            rdo5Percent.Location = new Point(25, 65);
            rdo5Percent.Name = "rdo5Percent";
            rdo5Percent.Size = new Size(58, 32);
            rdo5Percent.TabIndex = 7;
            rdo5Percent.TabStop = true;
            rdo5Percent.Text = "5%";
            rdo5Percent.UseVisualStyleBackColor = true;
            // 
            // rdoNoDiscount
            // 
            rdoNoDiscount.AutoSize = true;
            rdoNoDiscount.Location = new Point(22, 34);
            rdoNoDiscount.Name = "rdoNoDiscount";
            rdoNoDiscount.Size = new Size(142, 32);
            rdoNoDiscount.TabIndex = 6;
            rdoNoDiscount.TabStop = true;
            rdoNoDiscount.Text = "No Discount";
            rdoNoDiscount.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(323, 145);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(147, 46);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(704, 145);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(367, 35);
            txtAmount.TabIndex = 5;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtDiscAmount
            // 
            txtDiscAmount.Location = new Point(704, 227);
            txtDiscAmount.Multiline = true;
            txtDiscAmount.Name = "txtDiscAmount";
            txtDiscAmount.ReadOnly = true;
            txtDiscAmount.Size = new Size(367, 35);
            txtDiscAmount.TabIndex = 7;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(323, 216);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(181, 46);
            lblDiscount.TabIndex = 6;
            lblDiscount.Text = "Disc, Amt:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(704, 286);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(367, 35);
            txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(323, 286);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(249, 46);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total Payment:";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(415, 349);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(203, 77);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(651, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 77);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblChooseDiscount
            // 
            lblChooseDiscount.AutoSize = true;
            lblChooseDiscount.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChooseDiscount.Location = new Point(61, 489);
            lblChooseDiscount.Name = "lblChooseDiscount";
            lblChooseDiscount.Size = new Size(147, 46);
            lblChooseDiscount.TabIndex = 12;
            lblChooseDiscount.Text = "Amount:";
            // 
            // cboDiscount
            // 
            cboDiscount.FormattingEnabled = true;
            cboDiscount.Items.AddRange(new object[] { "No Discount", "5%", "12%" });
            cboDiscount.Location = new Point(71, 547);
            cboDiscount.Name = "cboDiscount";
            cboDiscount.Size = new Size(218, 23);
            cboDiscount.TabIndex = 13;
            // 
            // rtxtResults
            // 
            rtxtResults.Location = new Point(415, 489);
            rtxtResults.Name = "rtxtResults";
            rtxtResults.Size = new Size(616, 185);
            rtxtResults.TabIndex = 14;
            rtxtResults.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 707);
            Controls.Add(rtxtResults);
            Controls.Add(cboDiscount);
            Controls.Add(lblChooseDiscount);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtDiscAmount);
            Controls.Add(lblDiscount);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Button btnSubmit;
        private GroupBox groupBox1;
        private RadioButton rdoNoDiscount;
        private Label lblAmount;
        private TextBox txtAmount;
        private RadioButton rdo12Percent;
        private RadioButton rdo5Percent;
        private TextBox txtDiscAmount;
        private Label lblDiscount;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnCompute;
        private Button btnClear;
        private Label lblChooseDiscount;
        private ComboBox cboDiscount;
        private RichTextBox rtxtResults;
    }
}
