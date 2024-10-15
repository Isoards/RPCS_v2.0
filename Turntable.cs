using System.Drawing;
using System.Windows.Forms;

namespace RPCS
{
    // 턴테이블의 로직을 담당하는 클래스
    public class Turntable
    {
        public float Angle { get; private set; }

        public void GetTurnTableAngle()
        {
            Angle = (Angle + 1) % 360;
        }

    }

    // 턴테이블의 그래픽을 담당하는 클래스
    public class TurntableDisplay : Control
    {
        private Turntable turntable;

        public TurntableDisplay(Turntable turntable)
        {
            this.turntable = turntable;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TranslateTransform(211, 228);
            e.Graphics.RotateTransform(-90);
            e.Graphics.RotateTransform(turntable.Angle);

            using (Pen pen = new Pen(Color.FromArgb(45, 107, 255), 3))
            {
                e.Graphics.DrawLine(pen, 0, 0, 150, 0);
            }
            using (Pen circlePen = new Pen(Color.FromArgb(45, 107, 255), 2))
            {
                e.Graphics.DrawEllipse(circlePen, -150, -150, 300, 300);
            }

        }
    }
}
