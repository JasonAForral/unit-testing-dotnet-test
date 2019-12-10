using System;

namespace Prime.Service
{
    public class PrimeService
    {
        public bool IsPrime(int candiadate)
        {
            if (candiadate < 2)
            {
                return false;
            }

            double root = Math.Sqrt(candiadate);
            for(int i = 2; i <= root; ++i)
            {
                if ((candiadate  % i) == 0)
                    return false;
            }
            return true;
        }
    }
}
