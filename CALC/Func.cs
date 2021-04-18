using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public class Calculate : Parser
    {
        public decimal result(string input)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>(ConvertToPFNotation(input));
            string str = queue.Dequeue();
            while (queue.Count >= 0)
            {
                if (!_operators.Contains(str))
                {
                    stack.Push(str);
                    if (queue.Count == 0) break;
                    
                    str = queue.Dequeue();
                }
                else
                {
                    decimal summ = 0;
                    try
                    {

                        switch (str)
                        {

                            case "+":
                                {
                                    decimal a = Convert.ToDecimal(stack.Pop());
                                    decimal b = Convert.ToDecimal(stack.Pop());
                                    summ = a + b;
                                    break;
                                }
                            case "-":
                                {
                                    decimal a = Convert.ToDecimal(stack.Pop());
                                    decimal b = Convert.ToDecimal(stack.Pop());
                                    summ = b - a;
                                    break;
                                }
                            case "*":
                                {
                                    decimal a = Convert.ToDecimal(stack.Pop());
                                    decimal b = Convert.ToDecimal(stack.Pop());
                                    summ = b * a;
                                    break;
                                }
                            case "/":
                                {
                                    decimal a = Convert.ToDecimal(stack.Pop());
                                    decimal b = Convert.ToDecimal(stack.Pop());
                                    summ = b / a;
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    stack.Push(summ.ToString());
                    if (queue.Count > 0)
                        str = queue.Dequeue();
                    else
                        break;
                }

            }
            return Convert.ToDecimal(stack.Pop());
        }
    }
    public class Parser
    {
        private List<string> _all_operators = new List<string>(new string[] { "(", ")", "+", "-", "*", "/", "," });
        protected List<string> _operators;
        public Parser()
        {
            _operators = new List<string>(_all_operators);
        }

        private IEnumerable<string> Separate(string expression)
        {
            int position = 0;
            while (position < expression.Length)
            {
                string s = String.Empty + expression[position];
                if (!_all_operators.Contains(expression[position].ToString()))
                {
                    if (Char.IsDigit(expression[position]))
                        for (int i = position + 1; i < expression.Length && (Char.IsDigit(expression[i]) || expression[i] == ','); i++)
                            s += expression[i];
                    else if (Char.IsLetter(expression[position]))
                        for (int i = position + 1; i < expression.Length &&
                            (Char.IsLetter(expression[i]) || Char.IsDigit(expression[i])); i++)
                            s += expression[i];
                }
                yield return s;
                position += s.Length;
            }


        }


        private int Priority(string s)
        {
            switch (s)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 3;
            }
        }

        public string[] ConvertToPFNotation(string expression)
        {
            List<string> _outputSeparate = new List<string>();
            Stack<string> _stack = new Stack<string>();

            foreach (string s in Separate(expression))
            {
                #region working conditions with stack
                if (_operators.Contains(s))
                {
                    if (_stack.Count > 0 && !s.Equals("("))
                    {
                        if (s.Equals(")"))
                        {
                            string c = _stack.Pop();
                            while (c != "(")
                            {
                                _outputSeparate.Add(c);
                                c = _stack.Pop();
                            }
                        }
                        else if (Priority(s) > Priority(_stack.Peek()))
                        {
                            _stack.Push(s);
                        }
                        else
                        {
                            while (_stack.Count > 0 && Priority(s) <= Priority(_stack.Peek()))
                                _outputSeparate.Add(_stack.Pop());


                            _stack.Push(s);
                        }

                    }
                    else
                    {
                        _stack.Push(s);
                    }
                }
                else
                {
                    _outputSeparate.Add(s);
                }
                #endregion
            }
            if (_stack.Count > 0)
                foreach (string c in _stack)
                    _outputSeparate.Add(c);

            return _outputSeparate.ToArray();
        }



    }
}
