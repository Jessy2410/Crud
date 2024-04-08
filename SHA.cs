using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class SHA
    {

        public static string GenerateSHA256String(string inputString)//SHA256
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        public static string MakeMD5Hash(string input)//MD5
        {
            // etape 1, calculer MD5 depuis la chaine
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // etape 2, concertir vers chaine Hexa
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string mdpHasheAvecSel(string mdp)
        {
            string hache = MakeMD5Hash(mdp);

            int premierChiffre = 0;
            char premierCaractere = ' ';
            bool premierCaractereTrouve = false;
            bool premierChiffreTrouve = false;

            string listeChiffres = "0123456789";

            for (int i = 0; i < hache.Length; i++)
            {
                if (listeChiffres.Contains(hache[i]))
                {
                    if (!premierChiffreTrouve)
                    {
                        premierChiffre = int.Parse(hache[i].ToString());
                        premierChiffreTrouve = true;
                    }

                }
                else if (!premierCaractereTrouve)
                {
                    premierCaractere = hache[i];
                    premierCaractereTrouve = true;
                }
            }

            string hasheSale = hache.Insert(premierChiffre, premierCaractere.ToString());

            return hasheSale;
        }



        public static string petitsha(string input)
        {
            var data = Encoding.ASCII.GetBytes(input);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }

        

        public static string GenerateSHA512String(string inputString)//Sha512
        {
            SHA512 sha512 = SHA512.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

    }

}

