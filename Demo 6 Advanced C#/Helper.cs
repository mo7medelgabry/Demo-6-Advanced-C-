using Demo_6_Advanced_C_.genarics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_6_Advanced_C_
{
    internal class Helper <T>
    {
        
        // T Genaric type
        //public static void Swap(ref T X, ref T Y)
        //{
          //  T temp = X;
            //X = Y;
            //Y = temp;
       // }

        public static int SearchArray(T [] array, T value)
         { if (array != null)
           { for (int i = 0; i < array.Length; i++)
            {
                if (value.Equals(array[i]))
                return i;   
        }

           }
          return -1;
          }  


       // public static int SearchArray(int[] array,  int value)
        //{
          //  if (array != null)
            //{
              //  for (int i = 0; i < array.Length; i++)
                //{
                  //  if (value == array[i])
                    //    return i;
                //}

           // }
            //return -1;
        //}
    }
  }
