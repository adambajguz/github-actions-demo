namespace PackSite.Library.Crypto
{
    using System;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// Data signer.
    /// </summary>
    public interface ISigner
    {
        /// <summary>
        /// Signs data object with X.509 certificate.
        /// </summary>
        /// <param name="data">Data to sign.</param>
        /// <param name="certificate">Certificate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when data or certificate is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA private key.</exception>
        byte[] Sign(byte[] data, X509Certificate2 certificate);

        /// <summary>
        /// Signs data object with X.509 certificate.
        /// </summary>
        /// <param name="stream">Data stream to sign.</param>
        /// <param name="certificate">Certificate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when data or certificate is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA private key.</exception>
        byte[] Sign(Stream stream, X509Certificate2 certificate);

        /// <summary>
        /// Verifies data object with X.509 certificate.
        /// </summary>
        /// <param name="data">Data to verify.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="signature">Signature to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when data, certificate, or signature is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA public key.</exception>
        bool Verify(byte[] data, X509Certificate2 certificate, byte[] signature);

        /// <summary>
        /// Verifies data object with X.509 certificate.
        /// </summary>
        /// <param name="stream">Data stream to verify.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="signature">Signature to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws when data, certificate, or signature is null.</exception>
        /// <exception cref="InvalidOperationException">Throws when certificate does not contain RSA public key.</exception>
        bool Verify(Stream stream, X509Certificate2 certificate, byte[] signature);
    }
}
