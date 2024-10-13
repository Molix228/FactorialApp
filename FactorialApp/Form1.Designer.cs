namespace FactorialApp
{
    partial class FactorialApp
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
            label2 = new Label();
            txtResult = new TextBox();
            txtInput = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(40, 122);
            label1.Name = "label1";
            label1.Size = new Size(367, 51);
            label1.TabIndex = 0;
            label1.Text = "Enter the n! number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(40, 312);
            label2.Name = "label2";
            label2.Size = new Size(132, 51);
            label2.TabIndex = 1;
            label2.Text = "Result:";
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Font = new Font("Segoe UI", 14F);
            txtResult.Location = new Point(218, 309);
            txtResult.Margin = new Padding(20);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.PlaceholderText = "n! = ";
            txtResult.Size = new Size(450, 247);
            txtResult.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(448, 133);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(153, 39);
            txtInput.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.SteelBlue;
            btnCalculate.Font = new Font("Segoe UI", 10F);
            btnCalculate.ForeColor = SystemColors.Control;
            btnCalculate.Location = new Point(612, 122);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 60);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // FactorialApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(774, 672);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(800, 743);
            Name = "FactorialApp";
            Text = "Calculate Factorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtResult;
        private TextBox txtInput;
        private Button btnCalculate;
    }
}
