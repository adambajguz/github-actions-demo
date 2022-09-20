namespace PackSite.Library.Crypto.IntegrationTests
{
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using FluentAssertions;
    using Microsoft.Extensions.DependencyInjection;
    using PackSite.Library.Crypto.IntegrationTests.Data;
    using Xunit;

    public class SignerTests
    {
        [Theory]
        [InlineData(TestCertificates.Sample0Cert, TestCertificates.Sample0PrivateKey, TestCertificates.Sample0PassPhrase)]
        public void Should_sign_and_verify_data(string certPem, string keyPem, string passPhrase)
        {
            var certificate = X509Certificate2.CreateFromEncryptedPem(certPem, keyPem, passPhrase);

            ISigner signer = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<ISigner>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            byte[] expected = Convert.FromHexString("e9cee71ab932fde863338d08be4de9dfe39ea049bdafb342ce659ec5450b69ae");

            Action signAction = () => signer.Sign(data, certificate);
            signAction.Should().NotThrow();

            byte[] signature = signer.Sign(data, certificate);

            signer.Verify(data, certificate, signature).Should().BeTrue();
        }
    }
}
