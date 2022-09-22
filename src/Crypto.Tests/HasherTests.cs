namespace Crypto.Tests
{
    using System;
    using System.IO;
    using System.Text;
    using FluentAssertions;
    using Microsoft.Extensions.DependencyInjection;
    using Crypto.Extensions;
    using Xunit;

    public class HasherTests
    {
        [Fact]
        public void Should_hash_to_SHA256_from_array()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            byte[] expected = Convert.FromHexString("e9cee71ab932fde863338d08be4de9dfe39ea049bdafb342ce659ec5450b69ae");

            hasher.ToSHA256(data).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA384_from_array()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            byte[] expected = Convert.FromHexString("ccd30e4ffacb44db598f1130cacff9d5a79ea234ca6242a9eaecacb629e5e637236a6ee452c819b54a13c7e706fb5a7b");

            hasher.ToSHA384(data).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA512_from_array()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            byte[] expected = Convert.FromHexString("925f43c3cfb956bbe3c6aa8023ba7ad5cfa21d104186fffc69e768e55940d9653b1cd36fba614fba2e1844f4436da20f83750c6ec1db356da154691bdd71a9b1");

            hasher.ToSHA512(data).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA256_from_stream()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            using Stream stream = new MemoryStream(data);

            byte[] expected = Convert.FromHexString("e9cee71ab932fde863338d08be4de9dfe39ea049bdafb342ce659ec5450b69ae");

            hasher.ToSHA256(stream).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA384_from_stream()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            using Stream stream = new MemoryStream(data);

            byte[] expected = Convert.FromHexString("ccd30e4ffacb44db598f1130cacff9d5a79ea234ca6242a9eaecacb629e5e637236a6ee452c819b54a13c7e706fb5a7b");

            hasher.ToSHA384(stream).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA512_from_stream()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            byte[] data = Encoding.UTF8.GetBytes("abcd1234");
            using Stream stream = new MemoryStream(data);

            byte[] expected = Convert.FromHexString("925f43c3cfb956bbe3c6aa8023ba7ad5cfa21d104186fffc69e768e55940d9653b1cd36fba614fba2e1844f4436da20f83750c6ec1db356da154691bdd71a9b1");

            hasher.ToSHA512(stream).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA256_from_string()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            string data = "abcd1234";
            byte[] expected = Convert.FromHexString("e9cee71ab932fde863338d08be4de9dfe39ea049bdafb342ce659ec5450b69ae");

            hasher.ToSHA256(data).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA384_from_string()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            string data = "abcd1234";
            byte[] expected = Convert.FromHexString("ccd30e4ffacb44db598f1130cacff9d5a79ea234ca6242a9eaecacb629e5e637236a6ee452c819b54a13c7e706fb5a7b");

            hasher.ToSHA384(data).Should().Equal(expected);
        }

        [Fact]
        public void Should_hash_to_SHA512_from_string()
        {
            IHasher hasher = new ServiceCollection()
                .AddCrypto()
                .BuildServiceProvider()
                .GetRequiredService<IHasher>();

            string data = "abcd1234";
            byte[] expected = Convert.FromHexString("925f43c3cfb956bbe3c6aa8023ba7ad5cfa21d104186fffc69e768e55940d9653b1cd36fba614fba2e1844f4436da20f83750c6ec1db356da154691bdd71a9b1");

            hasher.ToSHA512(data).Should().Equal(expected);
        }
    }
}
