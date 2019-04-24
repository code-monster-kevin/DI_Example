using System;

namespace DI_Example.Inject
{
    public class ValuesRandom : IValues
    {
        public string[] GetValues()
        {
            Random rand = new Random();
            return new string[] { rand.Next(100).ToString(), rand.Next(100).ToString() };
        }

        public string GetValue(int value)
        {
            Random rand = new Random();
            return rand.Next(value).ToString();
        }
    }
}