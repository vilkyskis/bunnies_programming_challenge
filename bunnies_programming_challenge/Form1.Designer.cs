namespace Bunnies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.death_stats = new System.Windows.Forms.Label();
            this.infected_stats = new System.Windows.Forms.Label();
            this.born_stats = new System.Windows.Forms.Label();
            this.population_stats = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.age_stats = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(1214, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(82, 34);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 34);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(540, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 100);
            this.panel2.TabIndex = 6;
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.side_panel.Controls.Add(this.label1);
            this.side_panel.Controls.Add(this.richTextBox1);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(207, 639);
            this.side_panel.TabIndex = 3;
            this.side_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiek negali gimdyti?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1115, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1115, 198);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // death_stats
            // 
            this.death_stats.AutoSize = true;
            this.death_stats.Location = new System.Drawing.Point(1029, 55);
            this.death_stats.Name = "death_stats";
            this.death_stats.Size = new System.Drawing.Size(0, 13);
            this.death_stats.TabIndex = 9;
            // 
            // infected_stats
            // 
            this.infected_stats.AutoSize = true;
            this.infected_stats.Location = new System.Drawing.Point(1028, 84);
            this.infected_stats.Name = "infected_stats";
            this.infected_stats.Size = new System.Drawing.Size(0, 13);
            this.infected_stats.TabIndex = 10;
            // 
            // born_stats
            // 
            this.born_stats.AutoSize = true;
            this.born_stats.Location = new System.Drawing.Point(1029, 113);
            this.born_stats.Name = "born_stats";
            this.born_stats.Size = new System.Drawing.Size(0, 13);
            this.born_stats.TabIndex = 11;
            // 
            // population_stats
            // 
            this.population_stats.AutoSize = true;
            this.population_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_stats.Location = new System.Drawing.Point(1197, 74);
            this.population_stats.Name = "population_stats";
            this.population_stats.Size = new System.Drawing.Size(0, 20);
            this.population_stats.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bunnies.Properties.Resources.hourglass;
            this.pictureBox5.Location = new System.Drawing.Point(999, 140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 30);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bunnies.Properties.Resources.population;
            this.pictureBox4.Location = new System.Drawing.Point(1143, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 48);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bunnies.Properties.Resources.baby;
            this.pictureBox3.Location = new System.Drawing.Point(999, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bunnies.Properties.Resources.zombie;
            this.pictureBox2.Location = new System.Drawing.Point(1000, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bunnies.Properties.Resources.deaths;
            this.pictureBox1.Location = new System.Drawing.Point(1000, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Bunnies.Properties.Resources.iconfinder_Settings_5_379393;
            this.button1.Location = new System.Drawing.Point(3, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // age_stats
            // 
            this.age_stats.AutoSize = true;
            this.age_stats.Location = new System.Drawing.Point(1032, 144);
            this.age_stats.Name = "age_stats";
            this.age_stats.Size = new System.Drawing.Size(0, 13);
            this.age_stats.TabIndex = 15;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(67, 55);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.CustomProperties = "LineTension=0.1";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Lime;
            series1.MarkerColor = System.Drawing.Color.LimeGreen;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Fuchsia;
            series2.CustomProperties = "LineTension=0.1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Yellow;
            series3.CustomProperties = "LineTension=0.1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(926, 300);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1293, 639);
            this.Controls.Add(this.age_stats);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.population_stats);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.born_stats);
            this.Controls.Add(this.infected_stats);
            this.Controls.Add(this.death_stats);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label death_stats;
        private System.Windows.Forms.Label infected_stats;
        private System.Windows.Forms.Label born_stats;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label population_stats;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label age_stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

