using System;

namespace Calculator.Model
{
    public class Calcul
    {
        private string result;

        #region Конструкторы

        public Calcul(string firstOperand, string secondOperand, string operation)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
            result = string.Empty;
        }

        public Calcul(string firstOperand, string operation)
        {
            FirstOperand = firstOperand;
            SecondOperand = string.Empty;
            Operation = operation;
            result = string.Empty;
        }

        public Calcul()
        {
            FirstOperand = string.Empty;
            SecondOperand = string.Empty;
            Operation = string.Empty;
            result = string.Empty;
        }
        #endregion

        #region Свойства и методы

        public string FirstOperand { get; set; }
        public string SecondOperand { get; set; }
        public string Operation { get; set; }
        public string Result { get { return result; } }

        public void CalculateResult()
        {
            switch (Operation)
            {
                case ("+"):
                    result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case ("-"):
                    result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case ("*"):
                    result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                    break;

                case ("/"):
                    result = (Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand)).ToString();
                    break;
               
            }
        }
        #endregion
    }
}