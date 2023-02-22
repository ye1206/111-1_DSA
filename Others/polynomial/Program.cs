using System;
using ClassLibrary_Cheng3001.DSA;

namespace polynomial
{
    class Program
    {
        struct Poly
        {
            public int coeff; //係數
            public int exop;  //次方
        }

        static void Main(string[] args)
        {
            #region global
            string[] poly_a, poly_b;
            int i = 0;
            int indexA, indexB, totalTerms;
            #endregion global

            #region Polynomial
            Console.Write("輸入多項式A = ");
            poly_a = Console.ReadLine().Split(); //對多項式作切割並儲存
            //Poly[] polyA = new Poly[poly_a.Length / 2];

            //for (i = 0; i < polyA.Length; i++)
            //{
            //    polyA[i].exop = int.Parse(poly_a[i * 2]); // 跳格儲存 (切割後儲存方式為 係數 次方 係數 次方...)
            //    polyA[i].coeff = int.Parse(poly_a[i * 2 + 1]);
            //}

            Console.Write("輸入多項式B = ");
            poly_b = Console.ReadLine().Split(); //對多項式作切割並儲存
            //Poly[] polyB = new Poly[poly_b.Length / 2];

            //for (i = 0; i < polyB.Length; i++)
            //{
            //    polyB[i].exop = int.Parse(poly_b[2 * i]); // 跳格儲存 (切割後儲存方式為 係數 次方 係數 次方...)
            //    polyB[i].coeff = int.Parse(poly_b[2 * i + 1]);
            //}

            //Poly[] polyC = new Poly[polyA.Length + poly_b.Length];
            //indexA = 0;
            //indexB = 0;
            //totalTerms = 0;

            //while ((indexA < polyA.Length) && (indexB < polyB.Length))
            //{
            //    if (polyA[indexA].exop > polyB[indexB].exop)
            //    {
            //        polyC[totalTerms].exop = polyA[indexA].exop;
            //        polyC[totalTerms].coeff = polyA[indexA].coeff;
            //        totalTerms++;
            //        indexA++;
            //    } //if
            //    else if (polyA[indexA].exop == polyB[indexB].exop)
            //    {
            //        polyC[totalTerms].exop = polyA[indexA].exop;
            //        polyC[totalTerms].coeff = polyA[indexA].coeff + polyB[indexB].coeff;
            //        totalTerms++;
            //        indexA++;
            //        indexB++;
            //    } //else if 
            //    else
            //    {
            //        polyC[totalTerms].exop = polyB[indexB].exop;
            //        polyC[totalTerms].coeff = polyB[indexB].coeff;
            //        totalTerms++;
            //        indexB++;
            //    } // else

            //    while (indexA < polyA.Length)
            //     {
            //        polyC[totalTerms] = polyA[indexA];
            //        //poly_c[totalTerms].coeff = poly_a[indexA].coeff;
            //        totalTerms++;
            //        indexA++;
            //     } //while indexA < polyA.Length
            //    while (indexB < polyA.Length)
            //     {
            //        polyC[totalTerms] = polyB[indexB];
            //        //poly_c[totalTerms].coeff = poly_a[indexA].coeff;
            //        totalTerms++;
            //        indexB++;
            //     } //while indexB < polyB.Length

            //} //while

            #endregion polynomial

            //for (i = 0; i < totalTerms; i++)
            //    Console.Write($"{polyC[i].coeff} x^{polyC[i].exop} ");

            Polynomial.polynomial(poly_a, poly_b);



            Console.ReadLine();
        }
    }
}
