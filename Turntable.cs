using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPCS
{
    // 턴테이블의 로직을 담당하는 클래스
    public class Turntable
    {
        public float Angle { get; private set; }
        public event EventHandler AngleChanged;

        // 턴테이블의 현재 각도를 변경하는 메서드
        public void GetTurnTableAngle(float angleRotate)
        {
            Angle = (Angle + angleRotate) % 360;
            if (Angle < 0)
            {
                Angle += 360;
            }
            AngleChanged?.Invoke(this, EventArgs.Empty);
            //Angle = (Angle + 1) % 360; 계속 회전하게 만드는 코드
        }

    }

    // 턴테이블의 그래픽을 담당하는 클래스
    public class TurntableDisplay : Control
    {
        private Turntable turntable;
        private float targetAngle;

        public TurntableDisplay(Turntable turntable)
        {
            this.turntable = turntable;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 안티앨리어싱 적용
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // 중심점으로 이동
            e.Graphics.TranslateTransform(211, 211);

            // 기준선 그리기
            using (Pen referencePen = new Pen(Color.FromArgb(224, 224, 224), 4))
            {
                referencePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(referencePen, 0, 0, 0, -150);
            }

            // 원 그리기
            using (Pen circlePen = new Pen(Color.FromArgb(45, 107, 255), 3))
            {
                e.Graphics.DrawEllipse(circlePen, -150, -150, 300, 300);
            }

            // 회전 적용
            e.Graphics.RotateTransform(-90);
            e.Graphics.RotateTransform(turntable.Angle);

            // 회전하는 선 그리기
            using (Pen pen = new Pen(Color.FromArgb(45, 107, 255), 3))
            {
                e.Graphics.DrawLine(pen, 0, 0, 150, 0);
            }
        }
    }
}
