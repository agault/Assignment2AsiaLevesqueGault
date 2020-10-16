using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
/// <summary>
/// A nested loop is best to make this work:
/// it allows you to multiple iterations of a block of code.
/// I am taking the users input with M and N setting a count at 0 to allow the number 
/// of tens to be counted and essentially added to the tally.
/// Starting the count at one as every dice requires one side
/// i and j are the for loops parameters constraining the outputs.
///     Where they start counting
///     What the size constraints are
///     The quantity each loop adds
/// The second forloop takes the imput from the first 
/// The if statement contains the count
/// I ran into problems with it reading my practice controller and not my actual
/// ....definitly need to work on trouble shooting
/// </summary>
namespace Assignment2AsiaLevesqueGault.Controllers
{
   
    public class DiceTrialController : ApiController
    {
        //GET : /api/DiceTrial/{UserInputM}/{UserInputN}
        [HttpGet]
        [Route("api/DiceTrial/GetDice/{M}/{N}")]
        public string GetDice(int M, int N)
        {
            int count = 0;
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if ((i + j) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return "There are " + count.ToString() + " total ways to get the sum 10.";
        }
    }
}