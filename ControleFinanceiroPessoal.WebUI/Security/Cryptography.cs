using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ControleFinanceiroPessoal.WebUI.Security {
    public class Cryptography {

        private static Cryptography instance = null;

        private Cryptography() {

        }

        /// <summary>
        /// Singleton
        /// </summary>
        /// <returns></returns>
        public static Cryptography getInstance() {
            if (instance == null) {
                instance = new Cryptography();
            }
            return instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string GetMD5Hash(string text) {
            MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();
            byte[] hasedvalue = MD5provider.ComputeHash(Encoding.Default.GetBytes(text));
            StringBuilder str = new StringBuilder();
            for (int counter = 0; counter < hasedvalue.Length; counter++) {
                str.Append(hasedvalue[counter].ToString("x2"));
            }
            return str.ToString();
        }

    }
}