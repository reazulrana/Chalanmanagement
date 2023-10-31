using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace EncriptionLibrabry
{
    public class EncriptionMD5 : IEncription
    {

        string keyvalue = "1 (Ek) No Encription";
        public  string Encryption(string Value)
        {
            byte[] data = Encoding.UTF8.GetBytes(Value);

            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(keyvalue));


                using(TripleDESCryptoServiceProvider t=new TripleDESCryptoServiceProvider() {Key=keys, Mode=CipherMode.ECB, Padding= PaddingMode.PKCS7})
                {
                    ICryptoTransform itransform = t.CreateEncryptor();

                    byte[] result = itransform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(result, 0, result.Length);
                }



            }
        }




        public string Decryption(string Value)
        {

          

            byte[] data = Convert.FromBase64String(Value);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(keyvalue));


                using (TripleDESCryptoServiceProvider t = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform itransform = t.CreateDecryptor();

                    byte[] result = itransform.TransformFinalBlock(data, 0, data.Length);

                    return UTF8Encoding.UTF8.GetString(result, 0, result.Length);
                }
                            }
        }
    }
}
