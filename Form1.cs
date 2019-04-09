using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunnies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (side_panel.Visible)
            {
                side_panel.Visible = false;
            }
            else side_panel.Visible = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();
            Bunnie_colony colony = new Bunnie_colony(80000);

            Thread thread = new Thread((obj) => run_cycle(colony));
            Thread thread2 = new Thread((obj) => print_out(colony));
            thread.Start();
            thread2.Start();

            thread.Join();
            thread2.Join();
            death_stats.Text = colony.total_deaths.ToString();
            infected_stats.Text = colony.total_infected.ToString();
            born_stats.Text = colony.total_borns.ToString();
            population_stats.Text = colony.max_population.ToString();
            age_stats.Text = colony.year.ToString();
        }

        public void print_out(Bunnie_colony colony)
        {
            while (colony.population > 0)
            {
                lock (this)
                {
                    death_stats.Text = colony.recent_deaths.ToString();
                    infected_stats.Text = colony.recent_infected.ToString();
                    born_stats.Text = colony.recent_borns.ToString();
                    age_stats.Text = colony.year.ToString();
                    population_stats.Text = colony.population.ToString();
                    chart1.Series["Series1"].Points.AddXY(colony.year, colony.population);
                    chart1.Series["Series2"].Points.AddXY(colony.year, colony.recent_deaths);
                    chart1.Series["Series3"].Points.AddXY(colony.year, colony.recent_borns);
                }
            }
        }

        public void run_cycle(Bunnie_colony colony)
        {
            
            while (colony.population > 0)
            {
                //richTextBox2.AppendText(String.Format("Year: {0}\nPopulation: {1}\nRecent deaths: {2}\nRecent borned: {3}\nRecent infected: {4}\n\n\n",
                //  colony.year, colony.population, colony.recent_deaths, colony.recent_borns, colony.recent_infected));

                    colony.Live();
                Thread.Sleep(200);
            }
        }
    }
}
