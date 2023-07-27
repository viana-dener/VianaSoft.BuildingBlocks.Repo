using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using VianaSoft.BuildingBlocks.Core.Cryptography;

namespace VianaSoft.BuildingBlocks.Core.Extensions
{
    public static class ExtensionMethods
    {
        public static string FirstCharToUpper(this string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return null;

            string[] excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
            var palavras = new Queue<string>();
            foreach (var palavra in data.Split(' '))
            {
                if (!string.IsNullOrEmpty(palavra))
                {
                    var emMinusculo = palavra.ToLower();
                    var letras = emMinusculo.ToCharArray();
                    if (!excecoes.Contains(emMinusculo)) letras[0] = char.ToUpper(letras[0]);
                    palavras.Enqueue(new string(letras));
                }
            }
            return string.Join(" ", palavras);
        }
        public static string GetDescription(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (!memInfo.Equals(null) && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (!attrs.Equals(null) && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }
        public static async Task<bool> IsNumeric(this string value)
        {
            return await Task.Run(() => double.TryParse(value, out _));
        }
        public static async Task<bool> IsGuid(this string value)
        {
            return await Task.Run(() => Guid.TryParse(value, out _));
        }
        public static async Task<bool> IsEmail(this string value)
        {
            return await Task.Run(() => new EmailAddressAttribute().IsValid(value));
        }
        public static DateTime LastTimeDay(this DateTime data)
        {
            return data.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }
        public static string StringShortDate(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }
        public static string RemoveAccentsAndSpecialCharacters(this string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "¹", "²", "³", "£", "¢", "¬", "º", "¨", "\"", "'", ".", ",", "-", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "@", "#", "!", "$", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            /** Troca os caracteres especiais da string por " " **/
            str = Regex.Replace(str, @"[^\w\.@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));

            return str.Trim();
        }
        public static string Encrypt(this string str)
        {
            return CryptoMD5.Encrypt(str);
        }
        public static string GetCorrelationId(IHeaderDictionary context)
        {
            string correlatioId;
            if (context.TryGetValue("CorrelationId", out var value))
                correlatioId = value;
            else
                correlatioId = Guid.NewGuid().ToString();

            return correlatioId;
        }
        public static bool DateMajorEqualNow(this DateTime data)
        {
            return data >= DateTime.Now;
        }
        public static bool NotEmpty(this string str)
        {
            return str != null;
        }
    }
}
