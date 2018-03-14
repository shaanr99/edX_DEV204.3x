/****************************** Module Header ******************************\
Module Name:  ArraysClass.cs
Project:      edX_DEV204.3x
Copyright (c) Shaan Foltz

ArraysClass - examples of different types of arrays.


THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
namespace edX_DEV204
{
    public class ArraysClass
    {
        public ArraysClass()
        {
        }
        public int[] CreateSingleArray(int size){
            int[] returnArray = new int[size];
            Random rand = new Random();
            for (int count = 0; count < size; count++){
                returnArray[count] = rand.Next(0, 100);
            }
            return returnArray;
        }

        public int[ , ] CreateMultiArray(int row, int col){
            int[,] returnArray = new int[row, col];
            Random rand = new Random();
            for (int countRow = 0; countRow < row; countRow++)
            {
                for (int countCol = 0; countCol < col; countCol++)
                {
                    returnArray[countRow, countCol] = rand.Next(0, 100);
                }
            }
            return returnArray;
        }

        public int[][] CreateJaggedArray(int row){
            int[][] returnArray = new int[row][];

            Random randCol = new Random();
            Random randVal = new Random();
            for (int countRow = 0; countRow < row; countRow++){
                int colLength = randCol.Next(1, 10);
                returnArray[countRow] = new int[colLength];
                for (int countCol = 0; countCol < colLength;countCol++){
                    returnArray[countRow][countCol] = randVal.Next(1, 100);
                }
            }

            return returnArray;
        }
    }
}
