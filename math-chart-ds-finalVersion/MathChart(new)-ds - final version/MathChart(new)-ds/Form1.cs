using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MathChart_new__ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FinalCalbtn_Click(object sender, EventArgs e)
        {
            
            if(textBoxequation.Text=="")
            {
                MessageBox.Show("لطفا تابع را وارد کنید");
            }
            else if(textBoxUp.Text==""|| textBoxDown.Text=="")
            {
                MessageBox.Show("لطفا حدود تابع را وارد کنید");
            }
            else if(double.Parse(textBoxUp.Text)<double.Parse(textBoxDown.Text))
            {
                MessageBox.Show("حد بالا باید بیشتر از حد پایین باشد");
            }
            else
            {
                string equation = textBoxequation.Text;
                double HighLimit = double.Parse(textBoxUp.Text);
                double LowLimit = double.Parse(textBoxDown.Text);
                Placement(equation, HighLimit, LowLimit);

            }
            
        }
        private void Placement(string equation, double HighLimit, double LowLimit)
        {
            double x = LowLimit;
            int count = (int)Math.Floor((HighLimit - LowLimit) * 2);
            count = count + 1;
            Expression mathChartEquation = new Expression();
            string[] EquationArray = mathChartEquation.MakeArray(equation);
            string[] secondEquationArray = new string[EquationArray.Length];
            for (int i = 0; i < EquationArray.Length; i++)
            {
                secondEquationArray[i] = EquationArray[i];
            }
            double[] y = new double[count];
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < EquationArray.Length; i++)
                {
                    if (EquationArray[i] == "x")
                    {
                        EquationArray[i] = x.ToString();

                    }
                    if (i == EquationArray.Length - 1)
                    {
                        textBoxData.Text = textBoxData.Text + "\n" + "for x = " + x.ToString() +Environment.NewLine;
                        y[j] = mathChartEquation.Arzyabi(mathChartEquation.MianvandToPasvand(EquationArray));
                    }
                }
                x = x + 0.5;
                for (int i = 0; i < EquationArray.Length; i++)
                {
                    EquationArray[i] = secondEquationArray[i];
                }
            }
            x = LowLimit;
            chart1.Series["xy"].Points.Clear();
            for (int i = 0; i < y.Length; i++)
            {
                this.chart1.Series["xy"].Points.AddXY(x, y[i]);
                x = x + 0.5;
            }
            
        }
        private void Placement(string equation , double HighLimit ,double LowLimit , int timeDealy)
        {
            double x = LowLimit;
            int count = (int)Math.Floor((HighLimit - LowLimit) * 2);
            count = count + 1;
            Expression mathChartEquation = new Expression();
            string [] EquationArray = mathChartEquation.MakeArray(equation);
            string[] secondEquationArray = new string[EquationArray.Length];
            for(int i=0;i<EquationArray.Length;i++)
            {
                secondEquationArray[i] = EquationArray[i];
            }
            double[] y = new double[count];
            for(int j =0;j<count;j++)
            {
                for (int i = 0; i < EquationArray.Length; i++)
                {
                    if (EquationArray[i] == "x")
                    {
                        EquationArray[i] = x.ToString();
                        
                    }
                    if(i==EquationArray.Length-1)
                    {
                        textBoxData.Text = textBoxData.Text + Environment.NewLine + "for x = " + x.ToString()+Environment.NewLine;
                        y[j] = mathChartEquation.Arzyabi(mathChartEquation.MianvandToPasvand(EquationArray,timeDealy,textBoxData),timeDealy,textBoxData);
                    }
                }
                x = x + 0.5;
                for(int i=0;i<EquationArray.Length;i++)
                {
                    EquationArray[i] = secondEquationArray[i];
                }
            }
            x = LowLimit;
            for(int i=0;i<y.Length;i++)
            {
                this.chart1.Series["xy"].Points.AddXY(x, y[i]);
                x = x + 0.5;
            }
            
        }

        private void StepByStepCalBtn_Click(object sender, EventArgs e)
        {
            int timeDelay = 1000;
            if (textBoxequation.Text == "")
            {
                MessageBox.Show("لطفا تابع را وارد کنید");
            }
            else if (textBoxUp.Text == "" || textBoxDown.Text == "")
            {
                MessageBox.Show("لطفا حدود تابع را وارد کنید");
            }
            else if (double.Parse(textBoxUp.Text) < double.Parse(textBoxDown.Text))
            {
                MessageBox.Show("حد بالا باید بیشتر از حد پایین باشد");
            }
            else
            {
                string equation = textBoxequation.Text;
                double HighLimit = double.Parse(textBoxUp.Text);
                double LowLimit = double.Parse(textBoxDown.Text);
                Placement(equation, HighLimit, LowLimit,timeDelay);

            }
        }
    }
    public class stack<T>
    {
        static public int size = 100;
        public int top = -1;
        
        public T[] elements = new T[size];
        //constructor dar in ja mana nadarad chon khod barname bayad pishfarz size bedahad.
        //public stack(int x )
        //{

        //}

        public T peek()
        {
            if (top == -1)
                throw new EmtyException();
            return elements[top];
        }
        public void Push(T element)
        {
            if (top == size - 1)
            {
                throw new FullStackException();
            }
            top++;
            elements[top]=element;
        }
        public T Pop()
        {
            T element = peek();
            top--;
            return element;
        }
        public Boolean IsEmpty()
        {
            return -1 == top;
        }
        public Boolean IsFull()
        {
            return top == size - 1;
        }
    }

    public class Expression
    {
        public string[] MakeArray(string text)
        {
            char[] array = text.ToCharArray();
            string[] numbers = text.Split('+', '-','*','/','^');
            List<string> Operations = new List<string>();
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]=='+'|| array[i] == '-' || array[i] == '/' || array[i] == '*' || array[i] == '^' )
                {
                    Operations.Add(array[i].ToString());
                }
            }
            string[] EquationArray = new string[numbers.Length + Operations.Count];
            int length = 0;
            int count = 0;
            for(int i=0;i<EquationArray.Length;i++)
            {
                if((i+1)%2==1)
                {
                    EquationArray[i] = numbers[length];
                    
                    if(length<numbers.Length-1)
                        length++;
                }
                else
                {
                    EquationArray[i] = Operations[count];
                    
                    if(count<Operations.Count-1)
                        count++;
                }
            }
            
            return EquationArray;
        }
        public bool Pre(string a, string b)
        {
            if ((a == "+" || a == "-") && (b == "*" || b == "/" || b == "^" || b == "!" ))
            {
                return false;
            }
            else if ((a == "/" || a == "*") && ( b == "^" || b == "!"))
            {
                return false;
            }
            else if ((a == "!") && (b == "^"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<string> MianvandToPasvand(string [] array)
        {
            
            stack<string> Operations = new stack<string>();
            for(int i =0; i<array.Length;i++)
            {
                if(array[i].Contains("!"))
                {
                    string[] numbers = array[i].Split('!');
                    int number = int.Parse(numbers[0]);
                    int product = 1;
                    for(int j=1;j<=number;j++)
                    {
                        product = product * j;
                    }
                    array[i] = product.ToString();
                }
            }
            
            List<string> answer = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "+" && array[i] != "-" && array[i] != "*" && array[i] != "/" && array[i] != "^")
                {
                    answer.Add(array[i]);
                }
                else
                {
                    l1:
                    if (Operations.top != -1)
                    {
                        if (Pre(Operations.elements[Operations.top], array[i]))
                        {
                            
                            string obj = Operations.Pop();
                            answer.Add(obj.ToString());
                            goto l1;
                        }
                        else
                        {
                            Operations.Push(array[i]);
                        }
                    }

                    
                    else
                    {
                        Operations.Push(array[i]);
                    }
                }
                
            }
            while(Operations.IsEmpty()==false)
            {
                string character = Operations.Pop();
                answer.Add(character);
            }
            return answer;
        }

        public List<string> MianvandToPasvand(string[] array, int timeDelay, TextBox textboxData)
        {
            
            stack<string> Operations = new stack<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains("!"))
                {
                    string[] numbers = array[i].Split('!');
                    int number = int.Parse(numbers[0]);
                    int product = 1;
                    for (int j = 1; j <= number; j++)
                    {
                        product = product * j;
                    }
                    array[i] = product.ToString();
                }
            }
            
            List<string> answer = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "+" && array[i] != "-" && array[i] != "*" && array[i] != "/" && array[i] != "^")
                {
                    answer.Add(array[i]);
                }
                else
                {
                    l1:
                    if (Operations.top != -1)
                    {
                        if (Pre(Operations.elements[Operations.top], array[i]))
                        {
                            string obj = Operations.Pop();
                            answer.Add(obj.ToString());
                            goto l1;
                        }
                        else
                        {
                            Operations.Push(array[i]);
                        }
                    }
                    
                    else
                    {
                        Operations.Push(array[i]);
                    }
                }
                textboxData.Text = textboxData.Text+ Environment.NewLine + "Pasvandi:";
                for (int x = 0; x < answer.Count; x++)
                {
                    textboxData.Text = textboxData.Text + answer[x] + " ";
                }
                textboxData.Text = textboxData.Text + Environment.NewLine + "OperationStack:";
                for (int x = 0; x < Operations.elements.Length; x++)
                {
                    textboxData.Text = textboxData.Text + Operations.elements[x] + " ";
                }
                textboxData.Text = textboxData.Text + Environment.NewLine;
                Application.DoEvents();
                Thread.Sleep(timeDelay);
            }
            while (Operations.IsEmpty() == false)
            {
                
                string character = Operations.Pop();
                answer.Add(character);
            }
            textboxData.Text = textboxData.Text + Environment.NewLine + "Final Pasvandi:" ;
            for(int x =0;x<answer.Count;x++)
            {
                textboxData.Text = textboxData.Text + answer[x] + " ";
            }
            textboxData.Text = textboxData.Text + Environment.NewLine;
            
            Application.DoEvents();
            Thread.Sleep(timeDelay);
            return answer;
        }

        public double Arzyabi(List<string> array)
        {
            stack<double> mohasebe = new stack<double>();

            
            for(int i=0;i<array.Count;i++)
            {
                if(array[i]=="+"|| array[i] == "-" || array[i] == "*" || array[i] == "/" || array[i] == "^" || array[i] == "!")
                {
                    double a = mohasebe.Pop();
                    double b = mohasebe.Pop();
                    double c = 0;
                    switch (array[i])
                    {
                        case "+":
                            c = b + a;
                            break;
                        case "-":
                            c = b - a;
                            break;
                        case "*":
                            c = b * a;
                            break;
                        case "/":
                            c = b / a;
                            break;
                        case "^":
                            c = Math.Pow(b,a);
                            break;
                        //case ! be sorat jodagne handle shode.
                        

                    }
                    mohasebe.Push(c);
                }
                else
                {
                    double x = double.Parse(array[i].ToString());
                    mohasebe.Push(x);
                }
            }

            double answer = mohasebe.Pop();
            return answer;
        }

        public double Arzyabi(List<string> array, int timeDelay, TextBox textboxData)
        {
            stack<double> mohasebe = new stack<double>();
            
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == "+" || array[i] == "-" || array[i] == "*" || array[i] == "/" || array[i] == "^" || array[i] == "!")
                {
                    double a = mohasebe.Pop();
                    double b = mohasebe.Pop();
                    double c = 0;
                    switch (array[i])
                    {
                        case "+":
                            c = b + a;
                            break;
                        case "-":
                            c = b - a;
                            break;
                        case "*":
                            c = b * a;
                            break;
                        case "/":
                            c = b / a;
                            break;
                        case "^":
                            c = Math.Pow(b, a);
                            break;
                            //case '!':


                    }
                    mohasebe.Push(c);
                }
                else
                {
                    double x = double.Parse(array[i].ToString());
                    mohasebe.Push(x);
                }
                textboxData.Text = textboxData.Text + "CalculateStack:";
                for (int x = 0; x <= mohasebe.top; x++)
                {
                    textboxData.Text = textboxData.Text + mohasebe.elements[x] + " ";
                }
                textboxData.Text = textboxData.Text + Environment.NewLine;
                Application.DoEvents();
                Thread.Sleep(timeDelay);
            }

            double answer = mohasebe.Pop();
            return answer;
        }
    }
    public class EmtyException : Exception
    {
        public EmtyException()
        {
            MessageBox.Show("the stack is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class FullStackException : Exception
    {
        public FullStackException()
        {
            MessageBox.Show("the stack is full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
