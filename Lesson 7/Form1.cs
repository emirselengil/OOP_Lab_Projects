using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Stack<string > stack = new Stack<string>();
        public Form1()
        {
            InitializeComponent(); 
        }
        private double EvaluateExpression(string expression)
        {
            var tokens = Tokenize(expression);
            var postfix = ConvertToPostfix(tokens);
            return EvaluatePostfix(postfix);
        }
        private List<string> Tokenize(string expression)
        {
            var tokens = new List<string>();
            var number = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (char.IsDigit(ch) || ch == ',')
                {
                    number += ch;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        number = string.Empty;
                    }

                    if ("+-*/^()%".IndexOf(ch) >= 0)
                    {
                        tokens.Add(ch.ToString());
                    }
                    else if (char.IsLetter(ch))
                    {
                        string func = ch.ToString();
                        while (i + 1 < expression.Length && char.IsLetter(expression[i + 1]))
                        {
                            func += expression[++i];
                        }
                        tokens.Add(func);
                    }
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                tokens.Add(number);
            }

            return tokens;
        }

        private Queue<string> ConvertToPostfix(List<string> tokens)
        {
            var output = new Queue<string>();
            var operators = new Stack<string>();

            var precedence = new Dictionary<string, int>
            {
                { "+", 1 },
                { "-", 1 },
                { "*", 2 },
                { "/", 2 },
                { "^", 3 },
                { "sin", 4 },
                { "cos", 4 },
                { "tan", 4 },
                { "ln", 4 },
                { "log", 4 },
                { "π", 4 },
                { "e", 4 },
                { "%", 4 }
            };
            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Enqueue(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Count > 0 && operators.Peek() != "(")
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                {
                    while (operators.Count > 0 && precedence.ContainsKey(operators.Peek()) && precedence[operators.Peek()] >= precedence[token])
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            return output;
        }

        private double EvaluatePostfix(Queue<string> postfix)
        {
            var stack = new Stack<double>();

            while (postfix.Count > 0)
            {
                var token = postfix.Dequeue();

                if (double.TryParse(token, out var number))
                {
                    stack.Push(number);
                }
                else
                {
                    double result = 0.0;

                    if (token == "sin" || token == "cos" || token == "tan" || token == "ln" || token == "log" || token == "π" || token == "e")
                    {
                        var operand = stack.Pop();

                        if (token == "sin")
                        {
                            double radyan = operand * (Math.PI / 180.0);
                            result = Math.Sin(radyan);
                        }
                        else if (token == "cos")
                        {
                            double radyan = operand * (Math.PI / 180.0);
                            result = Math.Cos(radyan);
                        }
                        else if (token == "tan")
                        {
                            double radyan = operand * (Math.PI / 180.0);
                            result = Math.Tan(radyan);
                        }
                        else if (token == "ln")
                        {
                            result = Math.Log(operand);
                        }
                        else if (token == "log")
                        {
                            result = Math.Log10(operand);
                        }
                        else if (token == "π")
                        {
                            result = Math.PI;
                        }
                        else if (token == "e")
                        {
                            result = Math.E;
                        }
                        

                        stack.Push(result);
                    }
                    else
                    {
                        double right = stack.Pop();
                        double left = 0.0;
                        try
                        {
                            left = stack.Pop();
                        }
                        catch
                        {
                            stack.Push(0);
                        }


                        if (token == "+")
                        {
                            result = left + right;
                        }
                        else if (token == "-")
                        {

                            result = left - right;
                        }
                        else if (token == "*")
                        {
                            result = left * right;
                        }
                        else if (token == "/")
                        {
                            result = left / right;
                        }
                        else if (token == "^")
                        {
                            result = Math.Pow(left, right);
                        }
                        else if (token == "%")
                        {
                            result = left % right;
                        }
                        else
                        {
                            throw new InvalidOperationException("Invalid operation");
                        }

                        stack.Push(result);
                    }
                }
            }

            return stack.Pop();
        }


        private void evaluateButton_Click(object sender, EventArgs e)
        {
            
            label1.Text = ExpressionTextBox.Text + " =";
            
            double result = EvaluateExpression(ExpressionTextBox.Text);
            ExpressionTextBox.Text = result.ToString();
            stack.Push(label1.Text + result);
        }
        private double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void parantezAç_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "(";
        }

        private void parantezKapa_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += ")";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "%";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "9";
        }

        private void dört_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "4";
        }

        private void beş_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "5";
        }

        private void altı_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "6";
        }

        private void bir_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "2";
        }

        private void üç_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "3";
        }

        private void sıfır_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "0";
        }

        private void nokta_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += ",";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text = string.Empty;
        }

        private void div_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "/";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "*";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "-";
        }

        private void add_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "+";
        }
        static int Faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Faktoriyel(n - 1);
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressionTextBox.Text = Faktoriyel(int.Parse(ExpressionTextBox.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Only one number");
            }

        }

        private void log_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "log";
        }

        private void ln_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "ln";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "^(1/2)";
        }

        private void üsAlma_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "^";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "sin";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "cos";

        }

        private void tan_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "tan";
        }

        private void e_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += Math.E.ToString().Replace(',','.');
        }

        private void piNumber_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += Math.PI.ToString().Replace(',', '.');
        }

        private void History_Click(object sender, EventArgs e)
        {
            if (label2.Visible == true)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            foreach (string item in stack)
            {
                label2.Text += item + Environment.NewLine;
            }
            label2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void onUseri_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "10^";
        }

        private void exp_Click(object sender, EventArgs e)
        {
            ExpressionTextBox.Text += "2,71828^";
        }
    }
}
