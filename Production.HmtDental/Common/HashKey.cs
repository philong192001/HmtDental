using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Production.HmtDental.Common
{
    public class HashKey :IHashServices
    {
        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
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

        public string ConvertMd5(string code)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(code);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            var sb = "";

            for (int i = 0; i < hash.Length; i++)
            {
                sb += (hash[i].ToString("X2")).ToString();
            }

            return sb;
        }
    }
}
