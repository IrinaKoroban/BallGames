using BallsGame.Common;

namespace AngryBirdsWinFormsApp
{

    public class Bird : MoveBall
    {
        public event EventHandler<StatusChangedEventArgs> StatusChanged;

        private float g = 0.4F;
        private float slowdown = 3F;
        private Ball targetBall;
        private int startPosition = 130;

        public Bird(Form form) : base(form)
        {
            centerX = startPosition;
            centerY = form.ClientSize.Height - startPosition;
            color = Color.DarkRed;
        }

        public int GetStartPosition()
        {
            return startPosition;
        }

        public void SetTrajectory()
        {
            var scaleVariable = 5;
            vx = (startPosition - centerX) / scaleVariable;
            vy = (form.ClientSize.Height - startPosition - centerY) / scaleVariable;
        }

        public void GetTarget(Ball targetBall)
        {
            this.targetBall = targetBall;

        }
        public bool IsHitTarget()
        {
            return Math.Sqrt((targetBall.GetCenterX() - centerX) * (targetBall.GetCenterX() - centerX) +
                (targetBall.GetCenterY() - centerY) * (targetBall.GetCenterY() - centerY)) <= targetBall.GetRadius() + radius;
        }
        public bool OutsideForm()
        {
            return centerX > form.ClientSize.Width + radius || centerY < -form.ClientSize.Height * 1.5 || centerX < -radius;
        }
        public void GoToStartPosition()
        {
            Stop();
            Clear();
            centerX = startPosition;
            centerY = form.ClientSize.Height - startPosition;
            Show();
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            if (centerY >= BottomSide())
            {
                centerY = BottomSide();

                vy = (slowdown - vy < 0) ? slowdown - vy : 0;


                if (vx < 0)
                {
                    vx = (slowdown / 3 - vx > 0) ? vx - slowdown / 3 : 0;
                }
                else
                {
                    vx = (vx - slowdown / 3 > 0) ? vx - slowdown / 3 : 0;
                }
            }

            if (vy == 0 && vx == 0)
            {
                StatusChanged?.Invoke(this, new StatusChangedEventArgs(Status.Stoped));
                GoToStartPosition();
            }

            if (IsHitTarget())
            {
                StatusChanged?.Invoke(this, new StatusChangedEventArgs(Status.HitTarget));
                GoToStartPosition();
            }

            if (OutsideForm())
            {
                StatusChanged?.Invoke(this, new StatusChangedEventArgs(Status.OutsideForm));
                GoToStartPosition();
            }
        }
    }
}
