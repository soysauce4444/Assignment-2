using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method takes 4 integers representing
        /// different foods ordered at Chip's Fast Food emporium.
        /// Each food has 3 possible choices, represented by
        /// entering  values between 1-3 for them. 4 Means you didn't
        /// order that particular food item.
        /// The first integer represents which burger you ordered,
        /// the second integer represents drinks, 
        /// the third integer represents sides,
        /// and the fourth integer represents desserts.
        /// It will return the total sum of calories you've ingested
        /// during your meal by taking the sum of the foods ordered
        /// via the variable "totalCalories".
        /// </summary>
        /// <param name="burger">Integer representing which burger you chose: 1 = cheeseburger, 2 = fish burger, 3 = veggie burger, 4 = nothing</param>
        /// <param name="drink">Integer representing which drink you chose: 1 = soft drink, 2 = orange juice, 3 = milk, 4 = nothing</param>
        /// <param name="side">Integer representing which side you chose: 1 = fries, 2 = baked potato, 3 = chef salad, 4 = nothing</param>
        /// <param name="dessert">Integer representing which dessert you chose: 1 = apple pie, 2 = sundae, 3 = fruit cup, 4 = nothing</param>
        /// <example> GET ../api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0" </example>
        /// <example> GET ../api/J1/Menu/1/2/3/4 -> Your total calorie count is 691 </example>
        /// <returns>["Your total calorie count is " + totalCalories]</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public IEnumerable<string> GETCalorieCount(int burger, int drink, int side, int dessert)
        {
            if (burger == 1)
            {
                burger = 461;
            }
            else if (burger == 2)
            {
                burger = 431;
            }
            else if (burger == 3)
            {
                burger = 420;
            }
            else
            {
                burger = 0;
            }

            if (drink == 1)
            {
                drink = 130;
            }
            else if (drink == 2)
            {
                drink = 160;
            }
            else if (drink == 3)
            {
                drink = 118;
            }
            else
            {
                drink = 0;
            }

            if (side == 1)
            {
                side = 100;
            }
            else if (side == 2)
            {
                side = 57;
            }
            else if (side == 3)
            {
                side = 70;
            }
            else
            {
                side = 0;
            }

            if (dessert == 1)
            {
                dessert = 167;
            }
            else if (dessert == 2)
            {
                dessert = 266;
            }
            else if (dessert == 3)
            {
                dessert = 75;
            }
            else
            {
                dessert = 0;
            }

            int totalCalories = burger + drink + side + dessert;
            return new string[] { "Your total calorie count is " + totalCalories };
        }
    }

}
