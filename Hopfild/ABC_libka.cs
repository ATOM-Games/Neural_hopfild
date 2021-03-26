using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hopfild
{
    class ABC_libka
    {

        static public int[] yy = new int[100];

        public static int[] Raspoznat(int[] obraz_krivoy, List<obraz> Obr) {
            int[] Raspoznnny = new int[100];
            int[,] W_matrix = new int[100, 100];
            ///-------------------
            ///
            for (int i = 0; i < Obr.Count(); i++) {
                int[,] XtXshtr = new int[100, 100];
                for (int y = 0; y < 100; y++) {
                    for (int x = 0; x < 100; x++) {
                        XtXshtr[y, x] = Obr[i].Vector[y] * Obr[i].Vector[x];
                    }
                }
                for (int y = 0; y < 100; y++) {
                    for (int x = 0; x < 100; x++) {
                        W_matrix[y, x] += XtXshtr[y, x];
                    }
                }
            }
            ///-----------------
            ///
            for (int y = 0; y < 100; y++)
            {
                for (int x = 0; x < 100; x++) {
                    if (x == y) W_matrix[y, x] = 0;
                }
            }
            ///-----------------
            ///
            for (int y = 0; y < 100; y++) {
                for (int x = 0; x < 100; x++) {
                    yy[y] += (W_matrix[x, y] * obraz_krivoy[x]);
                }
            }
            ///-----------------
            ///
            return yy;
        }
    }
}
