namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int pipespeed = 8;
        int gravity = 15;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvents(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            TopPipe.Left -= pipespeed;
            BottomPipe.Left -= pipespeed;
            scoretext.Text = "Score: " +score;


            if(BottomPipe.Left <= -150)
            {
                BottomPipe.Left = 730;
                score++;
            }

            if (TopPipe.Left <= -100)
            {
                TopPipe.Left = 750;
                score++;
            }

            if( (Bird.Bounds.IntersectsWith(BottomPipe.Bounds)) ||
               (Bird.Bounds.IntersectsWith(TopPipe.Bounds)) ||
               (Bird.Bounds.IntersectsWith(Ground.Bounds)) )
            {
                endGame();
            }

            if(Bird.Top <= -25)
            {
                endGame();
            }

            if(score>10)
            {
                pipespeed = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            GameTimer.Stop();
            scoretext.Text += " Game Over";
            GameTimer.Enabled = false;
        }

        private void gamerestart(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Bird.Top = 317;
                GameTimer.Enabled = true;
                score = 0;
                TopPipe.Left = 700;
                BottomPipe.Left = 730;
            }
        }
    }
}