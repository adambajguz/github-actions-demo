namespace Crypto
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// Data signer implementation.
    /// </summary>
    public class Signer : ISigner
    {
        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA512;
        private static readonly RSASignaturePadding _signaturePadding = RSASignaturePadding.Pss;

        /// <inheritdoc/>
        public byte[] Sign(byte[] data, X509Certificate2 certificate)
        {
            _ = data ?? throw new ArgumentNullException(nameof(data), "Data cannot be null.");
            _ = certificate ?? throw new ArgumentNullException(nameof(certificate), "Certificate cannot be null.");

            using RSA? rsa = certificate.GetRSAPrivateKey();
            _ = rsa ?? throw new NullReferenceException("Certificate does not contain RSA private key.");

            byte[] signature = rsa.SignData(data, _hashAlgorithmName, _signaturePadding);

            return signature;
        }

        /// <inheritdoc/>
        public byte[] Sign(Stream stream, X509Certificate2 certificate)
        {
            _ = stream ?? throw new ArgumentNullException(nameof(stream), "Stream cannot be null.");
            _ = certificate ?? throw new ArgumentNullException(nameof(certificate), "Certificate cannot be null.");

            using RSA? rsa = certificate.GetRSAPrivateKey();
            _ = rsa ?? throw new NullReferenceException("Certificate does not contain RSA private key.");

            byte[] signature = rsa.SignData(stream, _hashAlgorithmName, _signaturePadding);

            return signature;
        }

        /// <inheritdoc/>
        public bool Verify(byte[] data, X509Certificate2 certificate, byte[] signature)
        {
            _ = data ?? throw new ArgumentNullException(nameof(data), "Data cannot be null");
            _ = certificate ?? throw new ArgumentNullException(nameof(certificate), "Certificate cannot be null");
            _ = signature ?? throw new ArgumentNullException(nameof(signature), "Signature cannot be null.");

            if (signature.Length == 0)
            {
                return false;
            }

            using RSA? rsa = certificate.GetRSAPublicKey();
            _ = rsa ?? throw new NullReferenceException("Certificate does not contain RSA public key.");

            bool result = rsa.VerifyData(data, signature, _hashAlgorithmName, _signaturePadding);

            return result;
        }

        /// <inheritdoc/>
        public bool Verify(Stream stream, X509Certificate2 certificate, byte[] signature)
        {
            _ = stream ?? throw new ArgumentNullException(nameof(stream), "Stream cannot be null");
            _ = certificate ?? throw new ArgumentNullException(nameof(certificate), "Certificate cannot be null");
            _ = signature ?? throw new ArgumentNullException(nameof(signature), "Signature cannot be null.");

            if (signature.Length == 0)
            {
                return false;
            }

            using RSA? rsa = certificate.GetRSAPublicKey();
            _ = rsa ?? throw new NullReferenceException("Certificate does not contain RSA public key.");

            bool result = rsa.VerifyData(stream, signature, _hashAlgorithmName, _signaturePadding);

            return result;
        }
    }
}
