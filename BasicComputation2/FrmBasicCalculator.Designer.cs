namespace BasicComputation2
{
    partial class FrmBasicCalculator
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
            lblResult = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtSecondNum = new TextBox();
            cmbOperation = new ComboBox();
            txtFirstNum = new TextBox();
            label1 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.LimeGreen;
            lblResult.Location = new Point(12, 41);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(72, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "000000";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 91);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 0;
            label2.Text = "Total:";
            // 
            // txtSecondNum
            // 
            txtSecondNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecondNum.Location = new Point(33, 132);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(227, 31);
            txtSecondNum.TabIndex = 9;
            // 
            // cmbOperation
            // 
            cmbOperation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(106, 93);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(82, 33);
            cmbOperation.TabIndex = 8;
            // 
            // txtFirstNum
            // 
            txtFirstNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstNum.Location = new Point(33, 56);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(227, 31);
            txtFirstNum.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 6;
            label1.Text = "Basic Calculator";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = SystemColors.ActiveBorder;
            btnCompute.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(98, 283);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(102, 33);
            btnCompute.TabIndex = 11;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 336);
            Controls.Add(panel1);
            Controls.Add(txtSecondNum);
            Controls.Add(cmbOperation);
            Controls.Add(txtFirstNum);
            Controls.Add(label1);
            Controls.Add(btnCompute);
            Name = "FrmBasicCalculator";
            Text = "Form1";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Panel panel1;
        private Label label2;
        private TextBox txtSecondNum;
        private ComboBox cmbOperation;
        private TextBox txtFirstNum;
        private Label label1;
        private Button btnCompute;
    }
}
