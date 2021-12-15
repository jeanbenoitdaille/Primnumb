    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static bool IsPrime(int a,int b = 0)
            {
                if(b == 0)
                    b = a / 2;
                
                if(a == 1 || b==1)
                {
                    return true;
                }
                else
                {
                    if(a % b == 0)
                        return false;
                    else
                        return IsPrime(a,b-1);
                }       
            } 
        }
    }