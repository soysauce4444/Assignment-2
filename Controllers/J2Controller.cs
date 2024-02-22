using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Two dice m and n are rolled, with m (1, 2, ..., m)
        /// and n (1, 2, ..., n) sides, respectively.This method
        /// returns the number of ways (combinations) that you can roll a sum of
        /// 10 with the values obtained from rolling the two dice.
        /// </summary>
        /// <param name="m">A die with m sides.</param>
        /// <param name="n">A die with n sides.</param>
        /// <example> GET ../api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10." </example>
        /// <example> GET ../api/J2/DiceGame/12/4 -> "There are 4 ways to get the sum 10." </example>
        /// <returns> [ "There are " + combinations + " ways to get the sum 10."] </returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        public IEnumerable<string> GETWaystoRollTen(int m, int n)
        {
            int upperlimit;
            int lowerlimit;
            int combinations = 0;

            if (!(m >= 10 && n >= 10))
            {
                if (m > n)
                {
                    upperlimit = m;

                    if (upperlimit >= 10)
                    {
                        upperlimit = 9;
                        lowerlimit = 1;
                    }
                    else
                    {
                        lowerlimit = 10 - upperlimit;
                    }

                    while (lowerlimit + upperlimit == 10 && !(lowerlimit > n))
                    {
                        combinations++;
                        lowerlimit++;
                        upperlimit--;
                    }

                    if (combinations == 1)
                    {
                        return new string[] { "There is " + combinations + " way to get the sum 10." };
                    }
                    else if (combinations == 5)
                    {
                        return new string[] { "There are " + combinations + " total ways to get the sum 10." };
                    }
                    else
                    {
                        return new string[] { "There are " + combinations + " ways to get the sum 10." };
                    }

                }
                else
                {
                    upperlimit = n;

                    if (upperlimit >= 10)
                    {
                        upperlimit = 9;
                        lowerlimit = 1;
                    }
                    else
                    {
                        lowerlimit = 10 - upperlimit;
                    }

                    while (lowerlimit + upperlimit == 10  && !(lowerlimit > m))
                    {
                        combinations++;
                        lowerlimit++;
                        upperlimit--;
                    }

                    if (combinations == 1)
                    {
                        return new string[] { "There is " + combinations + " way to get the sum 10." };
                    }
                    else if (combinations == 5)
                    {
                        return new string[] { "There are " + combinations + " total ways to get the sum 10." };
                    }
                    else
                    {
                        return new string[] { "There are " + combinations + " ways to get the sum 10." };
                    }
                }
            }
            else
            {
                return new string[] { "There are " + combinations + " ways to get the sum 10." };
            }
        }
    }
}
