using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T11_1
{
    internal class Address
    {
        /// <summary>
        /// Index
        /// </summary>
        public ushort index;
        /// <summary>
        /// Country's name
        /// </summary>
        public string country;
        /// <summary>
        ///  City's ame
        /// </summary>
        public string city;
        /// <summary>
        ///  Street
        /// </summary>
        public string street;
        /// <summary>
        /// House
        /// </summary>
        public ushort house;
        /// <summary>
        /// Apartament
        /// </summary>
        public ushort apartament;

        /// <summary>
        /// Output
        /// </summary>
        /// <returns>индекс,страна,город,улица,дом,квартира</returns>
        public override string ToString()
        {
            return $"{index}\t{country}\t{city}\t{street}\t{house}\t{apartament}\t";
        }
    }
}
