using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_250_Activity4
{
    public class SuperHero
    {
        public string name { get; set; }
        public decimal yearsExperience { get; set; }
        public List<String> importantDates { get; set; }
        public List<String> skills { get; set; }
        public string officeLocation { get; set; }
        public int speed { get; set; }
        public int stamina { get; set; }
        public int strength { get; set; }
        public string capeColor { get; set; }
        public int darkSide { get; set; }
        public string transportation { get; set; }
        

        public SuperHero(string name, decimal yearsExperience, List<String> importantDates, List<String> skills, string officeLocation, int speed, int stamina, int strength, string capeColor, int darkSide, string transportation)
        {
            this.name = name;
            this.yearsExperience = yearsExperience;
            this.importantDates = importantDates;
            this.skills = skills;
            this.officeLocation = officeLocation;
            this.speed = speed;
            this.stamina = stamina;
            this.strength = strength;
            this.capeColor = capeColor;
            this.darkSide = darkSide;
            this.transportation = transportation;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} has these powers: {1}. Date of Birth: {2}, Superpower discovery: {3}, Fateful day {4}, Years of experience {5}," +
                                      "He has an office in {6}, Preffered method of transport: {7}, Propensity for Dark Side: {8}," +
                                      "Strength: {9}%, Speed: {10}%, Stamina {11}%. Cape color is {12}",
                                     name, string.Join(", ", skills.ToList()), importantDates[0], importantDates[1], importantDates[2], yearsExperience,
                                     officeLocation, transportation, darkSide, strength, speed, stamina, capeColor);
            }
        }
    }
}
