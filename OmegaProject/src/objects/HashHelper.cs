using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Provides methods for computing SHA256 hashes.
/// </summary>
public class HashHelper
{
    /// <summary>
    /// Computes the SHA256 hash of the input string.
    /// </summary>
    /// <param name="rawData">The input string to hash.</param>
    /// <returns>The SHA256 hash value as a hexadecimal string.</returns>
    public string ComputeSha256Hash(string rawData)
    {
        // Create a SHA256 hash object
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
