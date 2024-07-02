using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp._1___Compartilhado
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string textoEscolhido)
        {
            string[] textoQuebrado = textoEscolhido.Split(' ');

            for (int i = 0; i < textoQuebrado.Length; i++)
            {
                string palavraMaiuscula = CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(textoQuebrado[i].ToLower());

                textoQuebrado[i] = palavraMaiuscula;
            }

            return string.Join(" ", textoQuebrado);
        }
    }
}
