using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab2
{
    /**
     * This class defines a generic Person
     *
     * @class Person
     * 
     */
    public class Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age=19;

        // PUBLIC PROPERTY ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is a property for our _name field
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /**
         * This is default empty constructor for the Person class
         * 
         * @constructor Person
        */

        public Person()
        {
            this._name = "unknown name";
        }

        /**
        * This is the constructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * 
        * @constructor Person
        * @param {string} name
       */
        public Person(string name)
        {
            this._name = name;
        }


        /**
          * This method prints the private name value and then "says hello" to the console.
          *
          * @method SayHello
          */
        public static void SayHello(string _name)
        {
            Console.WriteLine("Hello" + _name);
                             
        }

        /**
         * This method prints the private name value followed by 
         * "is" and then the private age value followed by "years old" to the console
         *
        * @method ShowAge 
        */
        public static void ShowAge(string _name, int _age)
        {
            Console.WriteLine(_name+" is "+_age+" years old");           
        }

       
    }
}
