namespace Crypto
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;

    /// <summary>
    /// Crypto service collection extensions.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds crypto services (signer and hasher).
        /// </summary>
        public static IServiceCollection AddCrypto(this IServiceCollection services)
        {
            return services
                .AddSigner()
                .AddHasher();
        }

        /// <summary>
        /// Adds signer service.
        /// </summary>
        public static IServiceCollection AddSigner(this IServiceCollection services)
        {
            services.TryAddSingleton<ISigner, Signer>();

            return services;
        }

        /// <summary>
        /// Adds hasher service.
        /// </summary>
        public static IServiceCollection AddHasher(this IServiceCollection services)
        {
            services.TryAddSingleton<IHasher, Hasher>();

            return services;
        }
    }
}
