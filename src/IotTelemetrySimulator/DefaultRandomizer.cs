namespace IotTelemetrySimulator
{
    using System;

    public class DefaultRandomizer : IRandomizer
    {
        [ThreadStatic]
        private static Random generator;

        private static Random RandomGenerator => generator ??= new Random();

        public int Next()
        {
            return RandomGenerator.Next();
        }

        public int Next(int max)
        {
            return RandomGenerator.Next(max);
        }

        public int Next(int min, int max)
        {
            return RandomGenerator.Next(min, max);
        }
    }
}
