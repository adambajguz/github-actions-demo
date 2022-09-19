namespace PackSite.Library.Crypto.Extensions
{
    using System.Text;

    /// <summary>
    /// Hasher extensions.
    /// </summary>
    public static class HasherExtensions
    {
        /// <summary>
        /// Hashes data to SHA256 from array.
        /// </summary>
        /// <param name="hasher">Hasher instance.</param>
        /// <param name="text">Text to hash.</param>
        /// <returns></returns>
        public static byte[] ToSHA256(this IHasher hasher, string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            return hasher.ToSHA256(data);
        }

        /// <summary>
        /// Hashes data to SHA384 from array.
        /// </summary>
        /// <param name="hasher">Hasher instance.</param>
        /// <param name="text">Text to hash.</param>
        /// <returns></returns>
        public static byte[] ToSHA384(this IHasher hasher, string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            return hasher.ToSHA384(data);
        }

        /// <summary>
        /// Hashes data to SHA512 from array.
        /// </summary>
        /// <param name="hasher">Hasher instance.</param>
        /// <param name="text">Text to hash.</param>
        /// <returns></returns>
        public static byte[] ToSHA512(this IHasher hasher, string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            return hasher.ToSHA512(data);
        }
    }
}
