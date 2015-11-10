namespace _02.TradeCompany
{
    using System;
    using System.Collections.Generic;

    public class RandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string Numbers = "0123456789";
        private const int BarcodeLenght = 13;

        private readonly Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string GetRandomString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Letters[this.GetRandomNumber(0, Letters.Length - 1)];
            }

            return new string(chars);
        }

        public string GetRandomNumString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Numbers[this.GetRandomNumber(0, Numbers.Length - 1)];
            }

            return new string(chars);
        }

        public HashSet<string> GetRandomBarcodes(int count)
        {
            var uniqueBarcodes = new HashSet<string>();

            while (uniqueBarcodes.Count < count)
            {
                uniqueBarcodes.Add(this.GetRandomNumString(BarcodeLenght));
            }

            return uniqueBarcodes;
        }

        public double GetRandomPrice(double min, double max)
        {
            return (this.random.NextDouble() * (max - min)) + min;
        }
    }
}
