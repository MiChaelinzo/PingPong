using RotatePictureBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pingpong.Properties;

namespace Pingpong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        PictureBox[] Score_Player = new PictureBox[5];  //Array to hold the score pictureboxes
        PictureBox[] Score_Enemy = new PictureBox[5];   
        Color ScoreColor = Color.Silver;                //Just to set the background color of the scoreboxes
        Random rng = new Random();                      //If you change this, change it from the design page too
        Boolean Player_Up, Player_Down = false;         //Booleans to see if player is going up or down
        Boolean BallGoingLeft = true;                   //Is the ball going left or right?
        Boolean GameOn = false;                         //Is the game on or paused

        int Speed_Player;                           //Dont change these, change them from the settings page
        int Speed_Enemy;                            
        int BallSpeed;
        int BallForce;
        int Round = 0;

        public Boolean Collision_Left(PictureBox obj)
        {
            if (obj.Location.X <= 0)    //If the "obj" picturebox is behind the screen
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox obj)
        {
            if (obj.Location.X + obj.Width >= WorldFrame.Width) //If the obj is further away the screen
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Up(PictureBox obj)
        {
            if (obj.Location.Y <= 0)    //If the objs Y coordinate is above the screen
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Down(PictureBox obj)
        {
            if (obj.Location.Y + obj.Height >= WorldFrame.Height)   //If the Obj is below the screen
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Enemy(PictureBox tar)
        {
                    PictureBox temp1 = new PictureBox();    //This is how I made the different points
                    temp1.Bounds = pb_Enemy.Bounds;         //on each block, where it shoots up/how fast
                                                            //Created a temp rectangle where the enemy is
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))    //Changed the temp rectangles size to be
                    {                                               //Just the 10 pixels on its side
                        BallForce = 3;                              //If the ball intersects here, BOOM 3 in force
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))    //Changeing the temp rectangle 5 points further down and same thing
                    {
                        BallForce = 2;                              //but less force
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))    //and so on, choose the put it 10 below for the rest
                    {
                        BallForce = 1;
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                    {
                        BallForce = 0;
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                    {
                        BallForce = -1;
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                    {
                        BallForce = -2;
                        return true;
                    }
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                    {
                        BallForce = -3;
                        return true;
                    }
            return false;
        }

        public Boolean Collision_Player(PictureBox tar)
        {
            if (tar.Bounds.IntersectsWith(pb_Player.Bounds))    //This is the same as above, but for the player instead
            {
                PictureBox temp1 = new PictureBox();
                temp1.Bounds = pb_Player.Bounds;
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 10);
                //PaintBox(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 10, Color.Red);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))    //All these "PaintBox" was for troubleshooting
                {
                    BallForce = 3;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 5, 1, 10, Color.Purple);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 2;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 10, 1, 10, Color.Pink);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 1;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 10, 1, 10, Color.Silver);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 0;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 10, 1, 10, Color.Yellow);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -1;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 10, 1, 10, Color.Green);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -2;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                //PaintBox(temp1.Location.X, temp1.Location.Y + 10, 1, 10, Color.Blue);
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -3;
                    return true;
                }
            }
            return false;
        }

        public void PaintBox(int X, int Y, int W, int H, Color C)
        {
            PictureBox Temp = new PictureBox();
            Temp.BackColor = C;
            Temp.Size = new Size(W, H);
            Temp.Location = new Point(X, Y);
            WorldFrame.Controls.Add(Temp);
        }

        public void ApplySettings()
        {   //Function to set colors from the programs settings file, happens once every 1ms :b
            pb_Player.BackColor = Properties.Settings.Default.Color_Player;
            pb_Enemy.BackColor = Properties.Settings.Default.Color_Enemy;
            pb_Ball.BackColor = Properties.Settings.Default.Color_Ball;
            WorldFrame.BackColor = Properties.Settings.Default.Color_Frame;
            BallSpeed = Properties.Settings.Default.BallSpeed;
            timer_Moveball.Interval = Properties.Settings.Default.Timer_Movement;
            timer_Enemy.Interval = Properties.Settings.Default.Timer_Enemy;
            Speed_Enemy = Properties.Settings.Default.EnemySpeed;
            Speed_Player = Properties.Settings.Default.Speed_Player;
        }

        public int ReverseInt(int x, Boolean Force = false, Boolean Negative = false)
        {
            if (Force)  //Kinda overdid this, not sure why but here's how it works
            {
                if (Negative)   //If the Negative boolean is on, it's always returns a negative number
                {
                    if (x > 0)  //So if X is above 0 it changes it
                    {
                        x = ~x + 1; //Not sure how this worked, ask the guy behind you.
                    }          
                }
                else
                {   //Simple math, negatives a positive number
                    x = x - (x * 2);
                }
            }
            else
            {
                if (x > 0)
                {
                    x = x - (x * 2);
                }
                else
                {           
                    x = ~x + 1;
                }
            }
            return x;
        }

        public void RandomStart(Boolean x)
        {
            for (int i = 0; i < rng.Next(5, 10); i++)
            {   //Just a random thing to select a random way for ball to start
                if (x)
                {
                    x = false;
                }
                else
                {
                    x = true;
                }
            }
        }

        private void timer_Moveball_Tick(object sender, EventArgs e)
        {
            ApplySettings();    // Every ms the settings are set

            if (GameOn)         // All movement only happens with game is on
            {
                if (Player_Up && !Collision_Up(pb_Player))
                {               // If Player should to up, and doesnt collide with the top
                    pb_Player.Top -= Speed_Player;    //Move player up
                }
                if (Player_Down && !Collision_Down(pb_Player))
                {               // Same here but going down instead, collision at the bottom check
                    pb_Player.Top += Speed_Player;
                }

                if (BallForce > 0)
                {   //If BallForce is positive, it moves the ball up #ballforce pixels
                    pb_Ball.Top -= BallForce;
                }
                if (BallForce < 0)
                {   //Same as above but negative
                    pb_Ball.Top -= BallForce;
                }

                if (pb_Ball.Location.Y <= 1)
                {   //If the ball hits the top, changes reverses the ballforce to it goes down same amount
                    BallForce = ReverseInt(BallForce, true, true);
                }
                    //If the ball hits the floor, changes to positive and goes up
                if (pb_Ball.Location.Y + pb_Ball.Height >= WorldFrame.Height - 1)
                {
                    BallForce = ReverseInt(BallForce, true, false);
                }

                if (BallGoingLeft)  //If the ball is going left
                {
                    if (Collision_Left(pb_Ball))    //If the ball collides with the left side wall
                    {
                        AddScore(Score_Player);     //Adds a box to the player, and resets the ball
                        pb_Ball.Location = new Point(206, 67);
                        RandomStart(BallGoingLeft);
                        BallForce = 0;
                    }
                    if (!Collision_Player(pb_Ball)) //If the ball is going left, not colliding with the left side wall
                    {                               //and it doesnt collide with the player, it goes left.
                        pb_Ball.Left -= BallSpeed;
                    }
                    else
                    {                               //Otherwise, if it does collide with the player. Going right
                        BallGoingLeft = false;
                    }
                }
                else
                {
                    if (Collision_Right(pb_Ball))  //Same as the ones above, but for the enemy/right side.
                    {
                        AddScore(Score_Enemy);
                        pb_Ball.Location = new Point(206, 67);
                        RandomStart(BallGoingLeft);
                        BallForce = 0;
                    }
                    if (!Collision_Enemy(pb_Ball))
                    {
                        pb_Ball.Left += BallSpeed;
                    }
                    else
                    {
                        BallGoingLeft = true;
                    }
                }
            }
        }

        public void CircleThis(PictureBox pic)  //Just a function to redraw the ball into a circle.
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width - 3, pic.Height - 3);
            Region rg = new Region(gp);
            pic.Region = rg;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)      //Regular key input, if press the right keys it moves in its direction
            {
                case Keys.W:
                case Keys.Up:
                    Player_Down = false;
                    Player_Up = true;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Up = false;
                    Player_Down = true;
                    break;
                case Keys.Space:    //If hit space it starts the game,
                    GameOn = true;
                    RandomStart(BallGoingLeft);
                    label_Start.Visible = false;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    Player_Up = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Down = false;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Score_Player[i] = PicID(i + 1);         //Adds the "score" pictureboxes to an array each
                Score_Enemy[i] = PicID(i + 1, true);
            }
            CircleThis(pb_Ball);    // Circles the ball
            ApplySettings();        // Applies all the global settings, happens every 1 ms anyways
            pb_Ball.Location = new Point(208, rng.Next(10, 190));   // Moves the ball in place
            RandomStart(BallGoingLeft); //Randomizes the direction of the ball
        }        

        public void AddScore(PictureBox[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {   //Goes through the entire array, checks where the first "non black" box is
                if (Arr[i].BackColor == ScoreColor)
                {   //And then changes it to black
                    Arr[i].BackColor = Color.Black;
                    break;
                }
            }

            if (Arr[4].BackColor == Color.Black)
            {   //If they all are black, game ends.
                GameOn = false;
                label_Start.Visible = true;
                RestoreScore();
                pb_Ball.Location = new Point(208, rng.Next(10, 190));
                pb_Player.Location = new Point(3, 67);
                pb_Enemy.Location = new Point(409, 67);
                Round = 0;
                label_Time.Visible = false;
            }
        }

        public void RestoreScore()
        {
            for (int i = 0; i <= 5; i++)
            {   //Resets all the score boxes to their original color
                PicID(i).BackColor = ScoreColor;
                PicID(i, true).BackColor = ScoreColor;
            }
        }

        public PictureBox PicID(int i, Boolean Enemy = false)
        {
            if (Enemy)
            {   //Just to make life easier, able to do a loop and go through all of these.
                switch (i)
                {
                    case 1:
                        return enemy_1;
                    case 2:
                        return enemy_2;
                    case 3:
                        return enemy_3;
                    case 4:
                        return enemy_4;
                    case 5:
                        return enemy_5;
                }
            }
            else
            {
                switch (i)
                {
                    case 1:
                        return player_1;
                    case 2:
                        return player_2;
                    case 3:
                        return player_3;
                    case 4:
                        return player_4;
                    case 5:
                        return player_5;
                }
            }
            return pb_Ball;
        }

        private void timer_Enemy_Tick(object sender, EventArgs e)
        {
            if (GameOn) //Timer to move the Enemy
            {   //Always tries to be in the middle
                if (pb_Enemy.Location.Y + 28 < pb_Ball.Location.Y)
                {   //Which is around 28 pixels below its Y coordinate
                    pb_Enemy.Top += Speed_Enemy;
                }
                else
                {
                    pb_Enemy.Top -= Speed_Enemy;
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sF = new SettingsForm();
            sF.Show();
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                Round++;
                label_Time.Visible = true;

                TimeSpan time = TimeSpan.FromSeconds(Round);

                string str = time.ToString(@"mm\:ss");
                label_Time.Text = "Time: " + str;
            }
        }
    }
}
