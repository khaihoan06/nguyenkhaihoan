namespace bai1
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
            labelPrice = new Label();
            labelQuantity = new Label();
            labelDiscount = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(24, 22);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(141, 25);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Đơn giá dịch vụ:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(24, 62);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(140, 25);
            labelQuantity.TabIndex = 0;
            labelQuantity.Text = "Số lượng khách:";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(24, 102);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(145, 25);
            labelDiscount.TabIndex = 0;
            labelDiscount.Text = "Mã giảm giá (%):";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(171, 19);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 31);
            txtPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(170, 59);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 31);
            txtQuantity.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(170, 102);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(180, 31);
            txtDiscount.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(24, 150);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(236, 28);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng tiền thanh toán: 0";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(160, 190);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(85, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(255, 190);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 30);
            btnReset.TabIndex = 4;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 250);
            Controls.Add(labelPrice);
            Controls.Add(txtPrice);
            Controls.Add(labelQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(labelDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính cước dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}
