namespace DI_Example.Inject
{
    public class ValuesHardCoded : IValues
    {
        public string[] GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        public string GetValue(int value)
        {
            return value.ToString();
        }
    }
}