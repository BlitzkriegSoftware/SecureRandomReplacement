using System;
using System.Security.Cryptography;

namespace SecureRandomLibrary
{
    /// <summary>
    /// Attempts to implement System.Random but with the <c>RNGCryptoServiceProvider</c>
    /// </summary>
    public class SecureRandom
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public SecureRandom()
        {
        }

        /// <summary>
        /// CTOR w. Seed
        /// <para>For compatibility not used</para>
        /// </summary>
        /// <param name="seed">(ignored)</param>
        public SecureRandom(int seed)
        {
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <returns>Random Positive integer 0 or greater</returns>
        public int Next()
        {
            var min = 0;
            var max = int.MaxValue;
            return Next(min, max);
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <param name="max">Upper limit (not inclusive)</param>
        /// <returns>0 to max random integer</returns>
        public int Next(int max)
        {
            var min = 0;
            return Next(min, max);
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <param name="min">Lower Limit (inclusive)</param>
        /// <param name="max">Upper limit (not inclusive)</param>
        /// <returns>random integer min to max</returns>
        public int Next(int min, int max)
        {
            var rnd = new byte[4];
            using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(rnd);
            var i = Math.Abs(BitConverter.ToInt32(rnd, 0));
            return Convert.ToInt32(i % (max - min + 1) + min);
        }

        /// <summary>
        /// Next Double
        /// </summary>
        /// <returns>0 to .999.... Random Double</returns>
        public double NextDouble()
        {
            var min = 0.0;
            var max = 1.0;
            var rnd = new byte[8];
            using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(rnd);
            var i = Math.Abs(BitConverter.ToDouble(rnd, 0));
            return Convert.ToDouble(i % (max - min + 1) + min);
        }

        public void NextBytes(byte[] buf)
        {
            using (var rng = new RNGCryptoServiceProvider()) rng.GetNonZeroBytes(buf);
        }

#if DOTNETCORE3_0
        public void NextBytes(Span<byte> span)
        {
            // Not implemented yet
        }
#endif

    }
}
