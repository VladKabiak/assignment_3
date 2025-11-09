namespace CalculatorLib
{
    public class Calculator
    {
        private readonly double m_a;
        private readonly double m_b;
        private readonly string m_operation;

        public Calculator(double a, double b, string operation)
        {
            m_a = a;
            m_b = b;
            m_operation = operation;
        }

        public double Calculate()
        {
            switch (m_operation)
            {
                case "+":
                    return m_a + m_b;
                case "-":
                    return m_a - m_b;
                case "*":
                    return m_a * m_b;
                case "/":
                    // intentionally commented out to test invalid operation
                    // if (m_b == 0)
                    //     return double.NaN;
                    return m_a / m_b;

                default:
                    return double.NaN;
            }
        }
    }
}
