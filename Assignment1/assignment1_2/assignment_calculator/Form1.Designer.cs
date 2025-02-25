using System.Windows.Forms;  // 添加此行
using System.Drawing;        // 如果涉及布局（如 Location/Size 属性）
namespace CalculatorApp

{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private ComboBox comboBoxOperator;
        private Button buttonCalculate;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(67, 58);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(132, 25);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(267, 58);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(132, 25);
            this.textBoxNum2.TabIndex = 1;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(200, 58);
            this.comboBoxOperator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(52, 23);
            this.comboBoxOperator.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(167, 115);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 27);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "计算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(167, 173);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 4;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 231);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CalculatorForm";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}