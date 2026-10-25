using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormBai03 : Form
    {
        public FormBai03()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    rtbContent.Text = streamReader.ReadToEnd();
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbContent.Text))
            {
                MessageBox.Show("Chưa có nội dung biểu thức để tính toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = rtbContent.Lines;
                StringBuilder outputBuilder = new StringBuilder();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        double result = EvaluateExpression(line);
                        outputBuilder.AppendLine($"{line} = {result}");
                    }
                    catch (Exception)
                    {
                        outputBuilder.AppendLine($"{line} = Lỗi biểu thức");
                    }
                }

                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(outputBuilder.ToString());
                }

                rtbContent.Text = outputBuilder.ToString();
                MessageBox.Show("Đã tính toán và ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double EvaluateExpression(string expression)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentCharacter = expression[i];

                if (char.IsWhiteSpace(currentCharacter))
                    continue;

                if (char.IsDigit(currentCharacter) || currentCharacter == '.')
                {
                    StringBuilder numberBuffer = new StringBuilder();
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        numberBuffer.Append(expression[i]);
                        i++;
                    }
                    i--;
                    values.Push(double.Parse(numberBuffer.ToString(), CultureInfo.InvariantCulture));
                }
                else if (currentCharacter == '(')
                {
                    operators.Push(currentCharacter);
                }
                else if (currentCharacter == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    if (operators.Count > 0) operators.Pop();
                }
                else if (IsOperator(currentCharacter))
                {
                    while (operators.Count > 0 && HasPrecedence(currentCharacter, operators.Peek()))
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(currentCharacter);
                }
            }

            while (operators.Count > 0)
            {
                values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
            }

            return values.Count > 0 ? values.Pop() : 0;
        }

        private bool IsOperator(char character)
        {
            return character == '+' || character == '-' || character == '*' || character == '/';
        }

        private bool HasPrecedence(char operator1, char operator2)
        {
            if (operator2 == '(' || operator2 == ')')
                return false;
            if ((operator1 == '*' || operator1 == '/') && (operator2 == '+' || operator2 == '-'))
                return false;
            return true;
        }

        private double ApplyOperation(char operatorType, double secondOperand, double firstOperand)
        {
            return operatorType switch
            {
                '+' => firstOperand + secondOperand,
                '-' => firstOperand - secondOperand,
                '*' => firstOperand * secondOperand,
                '/' => secondOperand != 0 ? firstOperand / secondOperand : throw new DivideByZeroException(),
                _ => 0
            };
        }
    }
}
