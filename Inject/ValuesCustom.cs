namespace DI_Example.Inject
{
    public class ValuesCustom : IValues
    {
        public string[] GetValues()
        {
            string[] values = null;
            // Implement your own custom method
            return values;
        }

        public string GetValue(int value)
        {
            int newvalue = value;
            // Implement your own custom method
            return newvalue.ToString();
        }
    }
}