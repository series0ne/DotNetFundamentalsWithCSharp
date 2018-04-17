namespace AsyncronousSample
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Threading.Tasks;

    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            DateTime start = DateTime.UtcNow;
            Task<string> calculateHashAsyncTask = HashAsync(Guid.NewGuid().ToByteArray(), 7);

            Console.WriteLine("Calculating hash...");
            Console.WriteLine(await calculateHashAsyncTask);

            Console.WriteLine($"Elapsed time: {DateTime.UtcNow - start}");

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
