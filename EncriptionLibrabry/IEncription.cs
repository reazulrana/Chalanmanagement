using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptionLibrabry
{
   public interface IEncription
    {


        string Encryption(string Value);
        string Decryption(string Value);
    }
}
