using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace SiteOrder.helper
{
    public static class Helper
    {
        public static string MD5Hash(string startString)
        {
            byte[] hash = Encoding.ASCII.GetBytes(startString);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach (var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">String input</param>
        /// <param name="notEmptyFlag">if string cant be empty or null => true</param>
        /// <returns></returns>
        public static String FirstCharToUpper(this string input, bool notEmptyFlag = true)
        {
            switch (input)
            {
                case null:
                    if (notEmptyFlag)
                        throw new ArgumentNullException(nameof(input));
                    else
                        return "";
                case "":
                    if (notEmptyFlag)
                        throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                    else
                        return "";
                default:
                    return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        private static readonly Regex _regex = new Regex("[^a-zA-Z0-9_-]+"); //regex that matches disallowed text

        public static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        public static bool IsEmailValid(String text)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(text);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }

        public static bool IsValidURL(String url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
            /*return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);*/
        }
    }
}
