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
    class Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        // PUBLIC PROPERTy ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is a property for our _name field
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }
}
