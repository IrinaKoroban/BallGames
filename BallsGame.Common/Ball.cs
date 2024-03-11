
using Timer = System.Windows.Forms.Timer;

namespace BallsGame.Common
{
    public class Ball
    {
        protected Form form;
        protected float centerX = 20;
        protected float centerY = 20;
        protected float vx = 1;
        protected float vy = 1;
        protected int radius = 30;
        protected Color color = Color.DarkSeaGreen;

        protected Timer timer;

        protected Random random = new Random();

        public Ball(Form form)
        {
            this.form = form;
            
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
        public void SlowDown()
        {
            timer.Interval = 40;
        }
        public void SpeedUp()
        {
            timer.Interval = 15;
        }

        public void Move()
        {
            Clear();
            Go();
            Draw(color);
        }
        public void Show()
        {
            Draw(color);
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int BottomSide()
        {
            return form.ClientSize.Height - radius;
        }

        public float GetCenterX()
        {
            return centerX;
        }
        public float GetCenterY()
        {
            return centerY;
        }

        public int GetRadius()
        {
            return radius;
        }
        public void SetPosition(float mouseX, float mouseY)
        { 
            centerX = mouseX;
            centerY = mouseY;
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerY > TopSide() && centerX < RightSide() && centerY < BottomSide();
        }

        public void OutsideOfForm()
        {
            if (centerY > form.ClientSize.Height + radius)
            {
                Stop();
            }
        }
        public bool Contains(int pointX, int pointY)
        {
            return (pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY) <= radius * radius;
        }

        public void Clear()
        {
            Draw(form.BackColor);
        }

        public Color GetColor()
        {
            return color;
        }

        public bool IsMoving()
        {
            return timer.Enabled;
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        private void Draw(Color color)
        {
            var brush = new SolidBrush(color);
            var graphis = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphis.FillEllipse(brush, rectangle);
        }
    }
}
