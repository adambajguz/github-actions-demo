namespace Crypto
{
    using System.IO;
    using System.Security.Cryptography;

    /// <summary>
    /// Data hasher implementation.
    /// </summary>
    public class Hasher : IHasher
    {
        /// <inheritdoc/>
        public byte[] ToSHA256(byte[] data)
        {
            using var hasher = SHA256.Create();

            return hasher.ComputeHash(data);
        }

        /// <inheritdoc/>
        public byte[] ToSHA384(byte[] data)
        {
            using var hasher = SHA384.Create();

            return hasher.ComputeHash(data);
        }

        /// <inheritdoc/>
        public byte[] ToSHA512(byte[] data)
        {
            using var hasher = SHA512.Create();

            return hasher.ComputeHash(data);
        }

        /// <inheritdoc/>
        public byte[] ToSHA256(Stream stream)
        {
            using var hasher = SHA256.Create();

            return hasher.ComputeHash(stream);
        }

        /// <inheritdoc/>
        public byte[] ToSHA384(Stream stream)
        {
            using var hasher = SHA384.Create();

            return hasher.ComputeHash(stream);
        }

        /// <inheritdoc/>
        public byte[] ToSHA512(Stream stream)
        {
            using var hasher = SHA512.Create();

            return hasher.ComputeHash(stream);
        }
    }
}
