using System;
class Calculator
{
    static void Main()
    {
        Console.Write("请输入第一个数字: ");
        double num1 = Convert.ToDouble(Console.ReadLine());//读取输入的数据转换为double类型

        Console.Write("请输入运算符 (+, -, *, /): ");
        char op = Console.ReadLine()[0];//读取输入的数据，返回string类型

        Console.Write("请输入第二个数字: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;//定义计算结果

        switch (op)//case语句选择运算
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("除数为0，计算错误！");
                    return;
                }
                break;
            default:
                Console.WriteLine("未知运算符！");//输入错误弹出提示
                return;
        }
        Console.WriteLine($"计算结果: {num1} {op} {num2} = {result}");
    }
}