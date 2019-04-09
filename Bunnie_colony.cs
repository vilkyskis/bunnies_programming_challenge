using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class Bunnie_colony
    {
        Bunnie[] buns;
        Random rnd = new Random();
        string female_file = @"names_female.csv";
        string male_file = @"names_male.csv";
        string color_file = @"colors.csv";
        public int population = 0;
        int seed;
        public int year = 0;
        //----------------------
        public int total_deaths = 0;
        public int total_borns = 0;
        public int total_infected = 0;
        public int max_population = -999;
        //----------------------
        public int recent_deaths = 0;
        public int recent_borns = 0;
        public int recent_infected = 0;

        //Define properties of bunnie.
        /*Color BLACK   age 1   name Amanda Beatch      sex female      infected? = random(1,100)*0,02%     Gene    AA1
         Color WHITE    age 1   name Russ Cow           sex male        infected? = random(1,100)*0,02%     Gene    AA2
         */



        public Bunnie_colony(int size) {
            buns = new Bunnie[size];
            generateBunnie(1);
            generateBunnie(2);
            //Generate two random buns
        }

        public void generateBunnie(int i)
        {
            string name;
            int age = 1;
            bool infected = bornWithInfection();
            string sex;
            string gene="A";

            seed = rnd.Next(1, 1000);
            //Name and gender
            //if (rnd.Next(1, 2) == 1)
            if (i == 1)
            {
                sex = "female";
                name = File.ReadAllLines(female_file)[seed];//1- moteris
            }
            else
            {
                sex = "male";
                name = File.ReadAllLines(male_file)[seed];
            }            
            //Gene
            gene += seed;
            this.buns[population] = new Bunnie(name, age, sex, gene, infected,File.ReadAllLines(color_file)[seed],seed);
            population++;
        }

        public bool bornWithInfection()
        {
            int t_virus = rnd.Next(1, 10000);
            if (t_virus == 7 || t_virus == 84)
            {
                return true;
            }
            return false;
        }

        public void reproducing(Bunnie mom, Bunnie father)
        {
            string name;
            int age = 1;
            string sex;
            string gene = "A";
            //validation
            if (mom.Age1 < 4 && father.Age1 < 4)
                return;
            if (mom.isInfected() || father.isInfected())
                return;
            //color
            string color = mom.Color;
            //sekla
            seed = rnd.Next(1, 1000);
            int gender = rnd.Next(1, 2);
            //Name and gender
            if (rnd.Next(1, 2) == 1)
            {
                sex = "female";
                name = File.ReadAllLines(female_file)[seed];//1- moteris
            }
            else
            {
                sex = "male";
                name = File.ReadAllLines(male_file)[seed];
            }
            gene += seed;
            this.buns[population++] = new Bunnie(name, age, sex, gene, bornWithInfection(), File.ReadAllLines(color_file)[seed],seed);
        }

        public int reproduce()
        {
            int born = 0;
            foreach(Bunnie male in buns)
            {
                if (male != null)
                {
                    if (male.Sex == "male" && male.Age1 >= 4 && !male.Infected)
                    {
                        //ieskom jam laisvos panos
                        foreach (Bunnie female in buns)
                        {
                            if (female != null)
                            {
                                if (female.Sex == "female" && female.Age1 >= 4 && !female.Infected && female.CantHaveBabies == 0)
                                {
                                    for (int i = 0; i < rnd.Next(1, 5); i++)
                                    {
                                        reproducing(male, female);
                                        born++;
                                    }
                                    female.CantHaveBabies = 3;
                                }
                            }
                        }
                    }
                }
            }
            return born;
        }

        public void rabbitsAge()
        {
            foreach(Bunnie bun in buns)
            {
                if (bun != null)
                {
                    bun.Age();
                    if (bun.CantHaveBabies > 0)
                        bun.CantHaveBabies--;
                }
            }
        }

        public int rabbitsDie()
        {
            int died = 0;
            foreach (Bunnie bun in buns)
            {
                if (bun != null)
                {
                    if (!bun.Infected)
                    {
                        if (bun.Age1 > 10)
                        {
                            died++;
                            population--;
                            //Die
                        }
                    }
                    else
                    {
                        if (bun.Age1 > 50)
                        {
                            died++;
                            population--;
                            //Die
                        }
                    }
                }
            }
            return died;
        }

        public int infectsOthers()
        {
            var infected_population = 0;
            foreach (Bunnie bun in buns)
            {
                if (bun != null)
                {
                    if (bun.Infected)
                    {
                        infected_population++;
                        int i = rnd.Next(1, 1000);
                        while (i == bun.Seed)
                        {
                            i = rnd.Next(1, 1000);
                        }
                        if ( buns[i] != null)
                        {
                            if (!buns[i].Infected)
                            {
                                infected_population++;
                                buns[i].Infected = true;
                            }
                        }
                    }
                }
            }
            return infected_population;
        }

        public void Live()
        {
            if (population > 0)
            {
                rabbitsAge();

                
                    recent_borns = reproduce();
                total_borns += recent_borns;

                recent_infected = infectsOthers();
                total_infected += recent_infected;

                recent_deaths = rabbitsDie();
                total_deaths += recent_deaths;

                year++;
                if (population > max_population)
                    max_population = population;

            }
        }
    }
}
