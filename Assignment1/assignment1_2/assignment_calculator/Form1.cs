using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // 初始化运算符下拉框
            comboBoxOperator.Items.AddRange(new string[] { "+", "-", "*", "/" });
            comboBoxOperator.SelectedIndex = 0; // 默认选择第一个运算符
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取用户输入的数字
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);

                // 获取选择的运算符
                string op = comboBoxOperator.SelectedItem.ToString();

                double result = 0;

                // 根据运算符执行计算
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("错误：除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                // 显示计算结果
                labelResult.Text = "结果: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("错误：请输入有效的数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}