namespace PackSite.Library.Crypto
{
    using System;

    /// <summary>
    /// Helper that verifies types of crypto services used in application.
    /// </summary>
    public static class CryptoServicesIntegrity
    {
        /// <summary>
        /// Verifies hasher service type.
        /// </summary>
        /// <param name="hasher">Hasher instance.</param>
        /// <exception cref="ArgumentException">Throws on integrity error.</exception>
        public static void Verify(IHasher hasher)
        {
            if (hasher is not Hasher)
            {
                throw new ArgumentException($"Application corrupted. Invalid hasher implementation type: '{hasher.GetType().FullName}' is not '{typeof(Hasher)}'");
            }
        }

        /// <summary>
        /// Verifies hasher service type.
        /// </summary>
        /// <param name="signer">Signer instance.</param>
        /// <exception cref="ArgumentException">Throws on integrity error.</exception>
        public static void Verify(ISigner signer)
        {
            if (signer is not Signer)
            {
                throw new ArgumentException($"Application corrupted. Invalid singer implementation type: '{signer.GetType().FullName}' is not '{typeof(Signer)}'");
            }
        }
    }
}
