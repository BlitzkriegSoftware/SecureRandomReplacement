using System;
using System.Security.Cryptography;

namespace BlitzkriegSoftware.SecureRandomLibrary
{
    /// <summary>
    /// Attempts to implement System.Random but with the <c>RNGCryptoServiceProvider</c>
    /// </summary>
    public class SecureRandom
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public SecureRandom() { }

        /// <summary>
        /// CTOR w. Seed
        /// <para>For compatibility not used</para>
        /// </summary>
        /// <param name="seed">(ignored)</param>
#pragma warning disable IDE0060 // This is for compatibility to .NET System.Random
        public SecureRandom(int seed) { }
#pragma warning restore IDE0060 // Remove unused parameter

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
#pragma warning disable CA1716 // Required for compatibility w. Random()
        public virtual int Next(int min, int max)
#pragma warning restore CA1716 // Identifiers should not match keywords
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
        public virtual double NextDouble()
        {
            var min = 0.0;
            var max = 1.0;
            var rnd = new byte[8];
            using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(rnd);
            var i = Math.Abs(BitConverter.ToDouble(rnd, 0));
            return Convert.ToDouble(i % (max - min + 1) + min);
        }

        /// <summary>
        /// Next Bytes given initial buffer
        /// </summary>
        /// <param name="buf">byte array buffer</param>
        public virtual void NextBytes(byte[] buf)
        {
            using RNGCryptoServiceProvider rng = new(); rng.GetNonZeroBytes(buf);
        }

    }
}
