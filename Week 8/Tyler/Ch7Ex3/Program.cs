/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Tyler Davis
 * Date: 10/18/2020
 * Purpose: This application demonstrates the use of the Array.Copy method and transferring data from two arrays into one.
 *
 * Class: CITP 180
 * Assignment: Chapter #7 - Programming Excercise #3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7Ex3
{
    class Program
    {
        private static readonly double[] _array1 = new double[3] { 1.4D, 3.5D, 6.0D };
        private static readonly double[] _array2 = new double[5] { 4.7D, 8.2D, 9.1D, 2.3D, 5.2D };
        private static double[] _array3;

        private static int _multiplier = 1;

        static void Main(string[] args)
        {
            // i assume 'multiplier' is for the length of the third array?
            _array3 = new double[_multiplier * (_array1.Length + _array2.Length)];

            // copy elements from both pre-initialized arrays into the final array.
            Array.Copy(_array1, _array3, _array1.Length);
            
            // the second Array copy requires us to modify the 'destinationIndex' value.
            Array.Copy(_array2, 0, _array3, (_array3.Length - 1) - (_array2.Length - 1), _array2.Length);

            // create some StringBuilder's to easily format the array data.
            StringBuilder array1Contents = new StringBuilder();
            StringBuilder array2Contents = new StringBuilder();
            StringBuilder array3Contents = new StringBuilder();

            #region Move Array values into their StringBuilder.
            for (int i = 0; i < _array1.Length; i++)
                array1Contents.AppendLine(_array1[i].ToString());

            for (int i = 0; i < _array2.Length; i++)
                array2Contents.AppendLine(_array2[i].ToString());

            for (int i = 0; i < _array3.Length; i++)
                array3Contents.AppendLine(_array3[i].ToString());
            #endregion

            // print the contents of each array.
            MessageBox.Show($"Contents of Array 1\n" +
                            $"{array1Contents}\n" +
                            $"===================\n\n" +
                            $"Contents of Array 2\n" +
                            $"{array2Contents}\n" +
                            $"===================\n\n" +
                            $"Contents of Array 3\n" +
                            $"{array3Contents}", "Chapter 7, Exercise 3");
        }
    }
}
