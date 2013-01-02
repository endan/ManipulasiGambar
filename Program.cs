using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManipulasiGambar
{
    static class Program
    {
        /// <summary>
        /// Tugas Besar Sistem Multimedia
        ///         Kelompok 1
        /// Endan Kurnia (10109005)
        /// M Rizki Sidik (10109022)
        /// Adrianto Akbar (10109029)
        /// Damar Andika (10109044)
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManipulasiGambar());
        }
    }
}