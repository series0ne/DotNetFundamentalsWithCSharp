namespace AsyncronousSample
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Threading.Tasks;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Task.Run(async () => {
                string result = await HashAsync(Guid.NewGuid().ToByteArray(), 5);
                Console.WriteLine(result);
            });

            Console.WriteLine("Calculating hash...");

            Console.Read();
        }

        private static async Task<string> HashAsync(byte[] data, int difficulty = 1)
        {
            int nonce = default;
            string result = default;

            byte[] GetDataBytesWithNOnce()
            {
                return data
                    .Concat(BitConverter.GetBytes(nonce++))
                    .ToArray();
            }

            byte[] ComputeHash(byte[] bytes)
            {
                using (SHA256 sha = SHA256.Create())
                {
                    return sha.ComputeHash(sha.ComputeHash(bytes));
                }
            }

            string ConvertToHash(byte[] hashBytes)
            {
                return BitConverter
                    .ToString(hashBytes)
                    .Replace("-", string.Empty)
                    .ToLower();
            }

            return await Task.Run(() =>
            {
                do
                {
                    result = ConvertToHash(ComputeHash(GetDataBytesWithNOnce()));
                } while (!result.StartsWith(new string('0', difficulty)));

                return result;
            });
        }
    }
}
