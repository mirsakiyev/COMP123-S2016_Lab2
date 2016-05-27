﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab2
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {           
            Person person = new Person("Aslan");

            person.SayHello();
            person.ShowAge();


        }

        
    }
}
