namespace Crypto.Extensions
{
    using System;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    /// <summary>
    /// Signer extensions.
    /// </summary>
    public static class SignerExtensions
    {
        /// <summary>
        /// Signs data object with X.509 certificate.
        /// </summary>
        /// <param name="signer">Signer instance.</param>
        /// <param name="text">Text to sign.</param>
        /// <param name="certificate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when signer, text, or certificate is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA private key.</exception>
        public static byte[] Sign(this ISigner signer, string text, X509Certificate2 certificate)
        {
            _ = signer ?? throw new ArgumentNullException(nameof(signer), "Signer instance cannot be null");
            _ = text ?? throw new ArgumentNullException(nameof(text), "Data cannot be null");

            byte[] data = Encoding.UTF8.GetBytes(text);

            return signer.Sign(data, certificate);
        }

        /// <summary>
        /// Verifies data object with X.509 certificate.
        /// </summary>
        /// <param name="signer">Signer instance.</param>
        /// <param name="text">Text to verify.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="signature">Signature to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when signer, text, certificate, or signature is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA public key.</exception>
        public static bool Verify(this ISigner signer, string text, X509Certificate2 certificate, byte[] signature)
        {
            _ = signer ?? throw new ArgumentNullException(nameof(signer), "Signer instance cannot be null");
            _ = text ?? throw new ArgumentNullException(nameof(text), "Data cannot be null");
            _ = signature ?? throw new ArgumentNullException(nameof(signature), "Signature cannot be null.");

            byte[] data = Encoding.UTF8.GetBytes(text);

            return signer.Verify(data, certificate, signature);
        }

        /// <summary>
        /// Verifies data object with X.509 certificate.
        /// </summary>
        /// <param name="signer">Signer instance.</param>
        /// <param name="text">Text to verify.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="signature">Signature to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when signer, text, certificate, or signature is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA public key.</exception>
        public static bool Verify(this ISigner signer, string text, X509Certificate2 certificate, string signature)
        {
            _ = signer ?? throw new ArgumentNullException(nameof(signer), "Signer instance cannot be null");
            _ = text ?? throw new ArgumentNullException(nameof(text), "Data cannot be null");
            _ = signature ?? throw new ArgumentNullException(nameof(signature), "Signature cannot be null.");

            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] s = Encoding.UTF8.GetBytes(signature);

            return signer.Verify(data, certificate, s);
        }

        /// <summary>
        /// Verifies data object with X.509 certificate.
        /// </summary>
        /// <param name="signer">Signer instance.</param>
        /// <param name="stream">Stream to verify.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="signature">Signature to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when signer, text, certificate, or signature is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA public key.</exception>
        public static bool Verify(this ISigner signer, Stream stream, X509Certificate2 certificate, string signature)
        {
            _ = signer ?? throw new ArgumentNullException(nameof(signer), "Signer instance cannot be null");
            _ = signature ?? throw new ArgumentNullException(nameof(signature), "Signature cannot be null.");

            byte[] s = Encoding.UTF8.GetBytes(signature);

            return signer.Verify(stream, certificate, s);
        }
    }
}
