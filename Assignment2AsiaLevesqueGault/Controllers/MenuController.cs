using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
/// <summary>
/// Plan: Identify all the variables and their caloric values.
/// Call on those values in an array so that the Userinputs reference their respective indicies.
/// Use the user input -1 (so zero is the first index)
/// Summate all caloric values. 
/// Return that value
/// </summary>
namespace Assignment2AsiaLevesqueGault.Controllers
{
    public class MenuController : ApiController
    {
        //GET : /api/Menu/{UserInput1}/{UserInput2}/{UserInput3}/{UserInput4}
        [HttpGet]
        [Route("api/Menu/{UserInput1}/{UserInput2}/{UserInput3}/{UserInput4}")]
        public string GetCalories(int UserInput1, int UserInput2, int UserInput3, int UserInput4)
        {
            //Calories of burgers
            int CheeseBurger = 461;
            int FishBurger = 431;
            int VeggieBurger = 420;
            int NoBurger = 0;
            int[] Burger = { CheeseBurger, FishBurger, VeggieBurger, NoBurger };

            //Calories of drinks
            int SoftDrink = 130;
            int OrangeJuice = 160;
            int Milk = 118;
            int NoDrink = 0;
            int[] drinks = { SoftDrink, OrangeJuice, Milk, NoDrink };

            //Calories of Sides
            int Fries = 100;
            int BakedPot = 57;
            int ChefSalad = 70;
            int noSide = 0;
            int[] sides = { Fries, BakedPot, ChefSalad, noSide };

            //Calories of dessert
            int ApplePie = 167;
            int Sundae = 266;
            int FruitCup = 75;
            int NoDessert = 0;
            int[] dessert = { ApplePie, Sundae, FruitCup, NoDessert };

            int MealCalories = Burger[UserInput1 - 1] + drinks[UserInput2 - 1] + sides[UserInput3 - 1] + +dessert[UserInput4 - 1];

            string ans = "You Consumed in this meal" + MealCalories.ToString() +"Calories";
            return ans;

         }
    }
}
