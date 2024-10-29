using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPCS
{
    public class Turntable
    {
        private float targetAngle;
        private float currentAngle;
        private Timer animationTimer;
        private const float AnimationSpeed = 5.0f; // 회전 속도 조절

        public float Angle
        {
            get => currentAngle;
            private set
            {
                currentAngle = value;
                AngleChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler AngleChanged;

        public Turntable()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 16; // 약 60fps
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // 현재 각도에서 목표 각도까지의 시계방향 거리 계산
            float clockwiseDistance = (targetAngle - currentAngle + 360) % 360;

            if (clockwiseDistance < AnimationSpeed)
            {
                // 목표 각도에 거의 도달했을 때
                Angle = targetAngle;
                animationTimer.Stop();
                return;
            }
            
            Angle = (currentAngle + AnimationSpeed) % 360; // 항상 시계방향으로 회전
        }

        public void GetTurnTableAngle(float angleRotate)
        {
            targetAngle = (angleRotate + 360) % 360;
            animationTimer.Start();
        }
    }

    public class TurntableDisplay : Control
    {
        private Turntable turntable;

        public TurntableDisplay(Turntable turntable)
        {
            this.turntable = turntable;
            this.DoubleBuffered = true;
            turntable.AngleChanged += (s, e) => this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.TranslateTransform(211, 190);

            // 기준선 그리기
            using (Pen referencePen = new Pen(Color.FromArgb(224, 224, 224), 4))
            {
                referencePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(referencePen, 0, 0, 0, -125);
            }

            // 중심점 그리기
            using (SolidBrush origin = new SolidBrush(Color.FromArgb(255, 59, 48)))
            {
                e.Graphics.FillEllipse(origin, -4, -4, 8, 8);
            }

            // 전체 원 그리기
            Rectangle circleRect = new Rectangle(-125, -125, 250, 250);

            // 비활성화 원 그리기 (현재 각도부터 360도까지)
            using (Pen grayPen = new Pen(Color.FromArgb(224, 224, 224), 3))
            {
                float grayStartAngle = -90 + turntable.Angle;  // -90는 12시 방향을 0도로 맞추기 위함
                float graySweepAngle = 360 - turntable.Angle;
                e.Graphics.DrawArc(grayPen, circleRect, grayStartAngle, graySweepAngle);
            }

            // 활성화 원 그리기 (0도부터 현재 각도까지)
            using (Pen bluePen = new Pen(Color.FromArgb(45, 107, 255), 3))
            {
                float blueStartAngle = -90;  // 12시 방향을 0도로
                float blueSweepAngle = turntable.Angle;
                e.Graphics.DrawArc(bluePen, circleRect, blueStartAngle, blueSweepAngle);
            }

            // 회전하는 선 그리기
            e.Graphics.RotateTransform(-90);
            e.Graphics.RotateTransform(turntable.Angle);

            using (Pen pen = new Pen(Color.FromArgb(45, 107, 255), 3))
            {
                e.Graphics.DrawLine(pen, 0, 0, 125, 0);
            }
        }
    }
}