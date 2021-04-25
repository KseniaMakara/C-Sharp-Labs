using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Label labelscore;
        private PictureBox[] snake = new PictureBox[400];
        private int r1, r2;
        private PictureBox fruit;
        private int _width = 900;
        private int _hight = 800;
        private int sides = 40;
        private int dirX, dirY;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(O);
            this.Width = _width;
            this.Height = _hight;
            labelscore = new Label();
            labelscore.Text = "Score: 0";
            labelscore.Location = new Point(810, 10);
            this.Controls.Add(labelscore);
            dirX = 1;
            dirY = 0;
            snake[0] = new PictureBox();
            snake[0].Location = new Point(201,201);
            snake[0].Size = new Size(sides-1, sides-1);
            snake[0].BackColor = Color.Red;
            this.Controls.Add(snake[0]);
            Map();
            
            timer.Tick += new EventHandler(_update);
            timer.Interval = 500;
            timer.Start();

            fruit = new PictureBox();
            fruit.BackColor = Color.YellowGreen;
            fruit.Size = new Size(sides, sides);
            Fruit();

        }
        private void SelfHarm()
        {
            for (int i = 1; i < score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    for (int j = 0; j <= score; j++)
                    {
                        this.Controls.Remove(snake[j]);
                    }
                    score = score - (score + i - 1);
                }
            }
        }
        private void Borders()
        {
            if (snake[0].Location.X < 0)
            {
                for (int i=1; i<=score; i++)
                {
                    this.Controls.Remove(snake[i]);
                }
                score = 0;
                labelscore.Text = "Score:" + score;
                dirX = 1;
            }

            if (snake[0].Location.X > _hight)
            {
                for (int i = 1; i <= score; i++)
                {
                    this.Controls.Remove(snake[i]);
                }
                score = 0;
                labelscore.Text = "Score:" + score;
                dirX = -1;
            }
            if (snake[0].Location.Y < 0)
            {
                for (int i = 1; i <= score; i++)
                {
                    this.Controls.Remove(snake[i]);
                }
                score = 0;
                labelscore.Text = "Score:" + score;
                dirY = 1;
            }
            if (snake[0].Location.Y > _hight)
            {
                for (int i = 1; i <= score; i++)
                {
                    this.Controls.Remove(snake[i]);
                }
                score = 0;
                labelscore.Text = "Score:" + score;
                dirY = -1;
            }
        }
        private void Move()
        {
            for(int i=score; i>=1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * (sides), snake[0].Location.Y + dirY * (sides));
            SelfHarm();
        }
        private void Eating()
        {
            if (snake[0].Location.X == r1 && snake[0].Location.Y == r2)
            {
                labelscore.Text = "Score:" + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(sides-1, sides-1);
                snake[score].BackColor = Color.Red;
                this.Controls.Add(snake[score]);
                Fruit();
            }
        }
        private void Fruit()
        {
            Random r = new Random();
            r1 = r.Next(0, _hight-sides-100);
            int temp1 = r1 % sides;
            r1 -= temp1;

            r2 = r.Next(0, _hight-sides-100);
            int temp2 = r2 % sides;
            r2 -= temp2;
            r1++;
            r2++;
            fruit.Location = new Point(r1,r2);
            this.Controls.Add(fruit);
        }

        private void _update(object MyObject, EventArgs eventArgs)
        {
            Move();
            Eating();
            Borders();
        }
        private void Map()
        {
            for (int i=0; i<_width/sides;i++)
            {
                PictureBox p = new PictureBox();
                p.BackColor = Color.Black;
                p.Location = new Point(0, sides * i);
                p.Size = new Size(_width - 100, 1);
                this.Controls.Add(p);
            }
            for (int i = 0; i <= _hight  / sides; i++)
            {
                PictureBox p = new PictureBox();
                p.BackColor = Color.Black;
                p.Location = new Point(sides * i, 0 );
                p.Size = new Size( 1, _width);
                this.Controls.Add(p);
            }
        }
        private void O(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX=1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX=-1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY=-1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY=1;
                    dirX = 0;
                    break;
            }
        }

    }
}
