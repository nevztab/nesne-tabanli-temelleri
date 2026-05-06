using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nesne_tabanli_temelleri
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Anasayfa());
        }

        public static void kaydet(string ad, string soyad, int yas, float not)
        {
            string dosyaYolu = "ogrenci_kayitlari.txt";
            if (!File.Exists(dosyaYolu))
            {
                File.Create(dosyaYolu).Close();
            }
            File.AppendAllText(dosyaYolu, $"{ad}:{soyad}:{yas}:{not}\n");
        }
    }
}
