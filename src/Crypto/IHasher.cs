namespace Crypto
{
    using System.IO;

    /// <summary>
    /// Data hasher.
    /// </summary>
    public interface IHasher
    {
        /// <summary>
        /// Hashes data to SHA256 from array.
        /// </summary>
        /// <param name="data">Data to hash.</param>
        /// <returns></returns>
        byte[] ToSHA256(byte[] data);

        /// <summary>
        /// Hashes data to SHA384 from array.
        /// </summary>
        /// <param name="data">Data to hash.</param>
        /// <returns></returns>
        byte[] ToSHA384(byte[] data);

        /// <summary>
        /// Hashes data to SHA512 from array.
        /// </summary>
        /// <param name="data">Data to hash.</param>
        /// <returns></returns>
        byte[] ToSHA512(byte[] data);

        /// <summary>
        /// Hashes data to SHA256 from stream.
        /// </summary>
        /// <param name="stream">Data stream to hash.</param>
        /// <returns></returns>
        byte[] ToSHA256(Stream stream);

        /// <summary>
        /// Hashes data to SHA384 from stream.
        /// </summary>
        /// <param name="stream">Data stream to hash.</param>
        /// <returns></returns>
        byte[] ToSHA384(Stream stream);

        /// <summary>
        /// Hashes data to SHA512 from stream.
        /// </summary>
        /// <param name="stream">Data stream to hash.</param>
        /// <returns></returns>
        byte[] ToSHA512(Stream stream);
    }
}
