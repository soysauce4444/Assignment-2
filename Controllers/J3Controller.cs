using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Professor Santos has decided to hide a secret formula for a new type of biofuel. She
        /// left a sequence of coded instructions for her assistant.
        /// Each instruction is a sequence of five digits which represents a direction to turn and the
        /// number of steps to take. Only the last input will be 99999, and is a signal that there are no
        /// more instructions.The direction will be stored in the variable "direction"
        /// and be returned in this method.
        /// </summary>
        /// <param name="instructions"> 
        /// A sequence of 5 digit integers which represents a direction to turn and the number of steps to take.
        /// The first two digits represent the direction to turn:
        /// If their sum is odd, then the direction to turn is left.
        /// If their sum is even and not zero, then the direction to turn is right.
        /// If their sum is zero, then the direction to turn is the same as the previous instruction.
        /// The remaining three digits represent the number of steps to take which will always be at least 100
        /// </param>        
        /// <example> GET ../api/secret/57234/00907/34100/99999 -> right 234, right 907, left 100 </example>
        /// <returns> [direction + " " + instruction[2] + instruction[3] + instruction[4]] </returns>
        /// Source of the problem: https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2021/index.html
        [Route("api/J3/secret/{*instructions}")]
        public IEnumerable<string> GETInstructions(string instructions)
        {
            string[] instructionsArray = instructions.Split('/');
            List<string> secret = new List<string>();
                 
            foreach (string instruction in instructionsArray.Take(instructionsArray.Length -1)) 
            {
                string direction;

                if ((instruction[0] + instruction[1]) % 2 == 0 &&
                    (instruction[0] + instruction[1]) != 0)
                {
                    direction = "right";
                }
                else
                {
                    direction = "left";
                }
                secret.Add(direction + " " + instruction[2] + instruction[3] + instruction[4]);
            }
            return secret;
        }
    }
}
