using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceBlackJack
{
    public partial class Form1 : Form
    {
        static int[] scorecard = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
        static int numbercard;
        static int numbercardenemy;
        static int score;
        static int scorenemy;
        static int timescorenemy;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number;
            number = random.Next(0, 13);
            if (number == 13 && score > 10) score++;
            else score = score + scorecard[number];
            label1.Text = String.Format("Ваш счет: {0}", score);
            if (score > 21)
            {
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                label3.Text = ("You Lose!!!");
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }
            else if ((score == 21) && (score > scorenemy))
            {
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                label3.Text = ("You Win!!!");
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }
            else if ((score == 21) && (score < scorenemy))
            {
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                label3.Text = ("You Win!!!");
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }
            else if ((score == 21) && (score == scorenemy))
            {
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                label3.Text = ("You Lose!!!");
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }

            else if ((score == scorenemy) && (score > 21))
            {
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                label3.Text = ("You Lose!!!");
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number;
            int numcard = 0;
            scorenemy += timescorenemy;
            if (scorenemy > 15) numcard = 1;
            else if (scorenemy < 15) numcard = 2;
            else if (scorenemy < 20) numcard = 0;
            while (numcard != 0)
            {
                number = random.Next(0, 13);
                if (number == 13 && scorenemy > 10) scorenemy++;
                else scorenemy = scorenemy + scorecard[number];
                numcard--;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = true;
            label1.Text = String.Format("Ваш счет: {0}", score);
            label2.Text = String.Format("Счет противника: {0}", scorenemy);
            if (score > 21) label3.Text = ("You Lose!!!");
            else if ((score == 21) && (score > scorenemy)) label3.Text = ("You Win!!!");
            else if ((score == 21) && (score < scorenemy)) label3.Text = ("You Win!!!");
            else if ((score == 21) && (score == scorenemy)) label3.Text = ("You Lose!!!");
            else if ((score == scorenemy) && (score > 21)) label3.Text = ("You Lose!!!");
            else if ((score == scorenemy) && (score < 21)) label3.Text = ("You Lose!!!");
            else if (((score < scorenemy) && (score < 21)) && (scorenemy < 21)) label3.Text = ("You Lose!!!");
            else if (((score < scorenemy) && (score < 21)) && (scorenemy == 21)) label3.Text = ("You Lose!!!");
            else if (((score < scorenemy) && (score < 21)) && (scorenemy > 21)) label3.Text = ("You Win!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("C:\\Users\\Лева\\Documents\\Visual Studio 2013\\Projects\\InterfaceBlackJack\\InterfaceBlackJack\\card\\card.png");
            Random random = new Random();
            int number;
            for (int i = 0; i < 2; i++)
            {
                number = random.Next(0, 13);
                pictureBox1.Image = bitmap;
                pictureBox1.Margin = new Margin(46, 67, 92, 134);
                if (number == 13 && score > 10) score++;
                else score+=scorecard[number];
            }
            //generation enemy
            number = random.Next(0, 13);
            timescorenemy+=scorecard[number];
            //generation open card enemy
            number = random.Next(0, 13);
            if (number == 13 && timescorenemy > 10) scorenemy++;
            else scorenemy+=scorecard[number];
            label1.Text = String.Format("Ваш счет: {0}", score);
            label2.Text = String.Format("Счет противника: {0} + 1 карта не известна", scorenemy);
            button3.Enabled = false;
            button3.Visible = false;
            if ((score == 21) && (score > scorenemy))
            {
                label3.Text = ("You Win!!!");
                scorenemy += timescorenemy;
                label2.Text = String.Format("Счет противника: {0}", scorenemy);
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
