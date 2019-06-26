using System;


namespace SecondAssignment
{
    public class Solutions{ /* A class where the solutions are kept */
        public int SumOfArray(int[]arr,int length){
            if(length<=0) return 0; /* Base case */
            return (SumOfArray(arr,length-1)+arr[length-1]); /* get the sum by starting from the 
                                              last element and then recurse  */
        }
        public int CountSpacesInString(string str){ /* takes a string as an input */
            if(str.Length<= 0) return 0; /* base case */
            return (str[0] == ' ' ? 1 : 0) + CountSpacesInString(str.Substring(1)); /* check for spaces starting from first 
                                                                         character and then recurse until the base case is hit*/
        }


        public int CheckNearestValue(int numOne, int numTwo){ /* takes two integer parameters and 
                                                            returns the number which is nearest to 100 */
          const int referenceValue = 100;  /* Reference value which is to be checked */
            if( numOne == numTwo )  /* check if both the numbers are equal, if both are equal then return 0 */
                return 0;
            int differenceOne = referenceValue - numOne; /* store the difference in difference_one  */
            int differenceTwo = referenceValue - numTwo; /* store the difference in difference_two */
            int minimumOne = Math.Min(differenceOne,differenceTwo); /* Get the minimum difference*/

             return (referenceValue - minimumOne);
        }

        public void ConvertLastThreeCharectersOfString(string str){ /* takes an input string */
            if(str.Length == 0) return; /* check if it is an empty string  */
            string lastThree = str.Substring(str.Length-3); /* gets the last 3 string */
            string first = str.Substring(0,str.Length-3); /*gets the first string excluding the last three characters */
            Console.WriteLine(first+lastThree.ToUpper()); /* join the two strings and convert the last 3 to uppercase */
        }
        
        public int LargestOfThree(int a , int b , int c){ /* Calculates Largest of three numbers */
            int res = (a>b)? a:b;     /* is a greater than b? if it is then store the largest of then inside res  */
            return ((res>c) ? res: c); /* checks if c is greater than res */
        }

        public string ReturnHeightsOfPersons(int height){ /* takes height as input  */
            if( height == 0) /* if height is 0  */
                return "Height Cannot Be 0";
            if(height > 190) /* if height is greater than 190cms */
                return "Tall";
            if(height>= 130 && height <=190) /* if height is greater than 130 and is less than or equal to 190 */
                return "Normal";


            return "Short"; /* if none of the conditions satisfy  */
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {10,10,10,10}; /* Test array */
            Solutions test = new Solutions(); /* creating an instance of solutions class */
            string testString = "hello world jsjj jjj     "; /* test string */
            Console.WriteLine(test.SumOfArray(testArray,testArray.Length));
            Console.WriteLine(test.CountSpacesInString(testString));
            Console.WriteLine(test.CheckNearestValue(60,100));
            test.ConvertLastThreeCharectersOfString("akash");
            Console.WriteLine(test.LargestOfThree(7,2,9));
            Console.WriteLine(test.ReturnHeightsOfPersons(150));
        }
    }
}
