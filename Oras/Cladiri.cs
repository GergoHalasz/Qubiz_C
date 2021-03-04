using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
   
    public abstract class Building 
    {

        public string StreetName { get; set; }
        public string BlockNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string HouseNumber { get; set; }


        private static int Counter = 0;
        protected static int houseCounter = 0;
        protected static int institutionCounter = 0;
        protected static int blocCounter = 0;

        public static int count { get { return Counter; } }
        public Building()
        {
            Counter++;
        }
        
            
        

    }
    
    public abstract class House : Building  
    {
        
        public static int count { get { return Building.houseCounter; } }
        public House()
        {
            houseCounter++;
            
        }
    }
    public class Bloc : Building
    {
        
        public static int count { get { return Building.blocCounter; } }
        public Bloc()
        {
            blocCounter++;

        }
    }
    public abstract class Institution : Building
    {
        
        public static int count { get { return Building.institutionCounter; } } 
        public Institution()
        {
            institutionCounter++;

        }
    }
    public abstract class Firma : Building
    {
        
    }
    // House Styles
    public class ContemporaryStyle : House
    {
        
    }
    public class ColonialStyle : House
    {
        
    }
    public class CapeCodStyle : House
    {
    }
    // Institutions
    public class Church : Institution
    {
    }
    public class Hospital : Institution
    {
    }
    public class School : Institution
    {
    }
}

