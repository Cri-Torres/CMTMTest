using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTM.Texto
{
    public class Texto
    {
        // Método que invierte la cadena
        public string ReverseString(string input)
        {
            if (input == null) return null;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Método que elimina todos los espacios en blanco
        public string RemoveSpaces(string input)
        {
            if (input == null) return null;

            return input.Replace(" ", "");
        }
    }
}
