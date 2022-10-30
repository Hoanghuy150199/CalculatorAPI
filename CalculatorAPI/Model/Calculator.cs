namespace CalculatorAPI.Model
{
    public class Calculator
    {
        public float a;
        public float b;
        public float result;
        public Calculator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void add()
        {
            result = a + b;
        }

        public void sub()
        {
            result = a - b;
        }

        public void mul()
        {
            result = a * b;
        }
    }
}
