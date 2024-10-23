using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPCS
{
    //  로봇의 X, Y, Z 좌표와 상태를 저장
    public class RobotState
    {
        // 상태가 변경될 때 이벤트를 발생시킴
        public event EventHandler StateChanged;

        // 로봇의 X, Y, Z 좌표
        private float _x, _y, _z;
        // 로봇의 현재 상태 (예: Running, Stopped)
        private string _status;

        // X 좌표에 대한 프로퍼티
        public float X
        {
            get { return _x; }  // X 좌표를 반환
            set
            {
                if (_x != value)  // 새로운 값이 이전 값과 다를 경우에만 업데이트
                {
                    _x = value;
                    OnStateChanged();  // 상태가 변경되었음을 알림
                }
            }
        }

        // Y 좌표에 대한 프로퍼티
        public float Y
        {
            get { return _y; }  // Y 좌표를 반환
            set
            {
                if (_y != value)  // 새로운 값이 이전 값과 다를 경우에만 업데이트
                {
                    _y = value;
                    OnStateChanged();  // 상태가 변경되었음을 알림
                }
            }
        }

        // Z 좌표에 대한 프로퍼티
        public float Z
        {
            get { return _z; }  // Z 좌표를 반환
            set
            {
                if (_z != value)  // 새로운 값이 이전 값과 다를 경우에만 업데이트
                {
                    _z = value;
                    OnStateChanged();  // 상태가 변경되었음을 알림
                }
            }
        }

        // 로봇의 상태에 대한 프로퍼티 (예: Running, Stopped)
        public string Status
        {
            get { return _status; }  // 로봇의 상태를 반환
            set
            {
                if (_status != value)  // 상태가 변경될 때만 업데이트
                {
                    _status = value;
                    OnStateChanged();  // 상태 변경을 알림
                }
            }
        }

        // 상태가 변경되었을 때 이벤트를 발생시키는 메서드
        protected virtual void OnStateChanged()
        {
            // 상태가 변경되면 연결된 이벤트 핸들러를 호출
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // 로봇의 현재 좌표를 문자열로 반환하는 함수
        public string GetRobotPosition()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";  // 로봇의 좌표를 형식에 맞게 반환
        }
    }
// 로봇의 위치를 관리하는 클래스
public class RobotPosition
    {

        public float X;
        public float Y;
        public float Z;
        public float W;  // Yaw
        public float P;  // Pitch
        public float R;  // Roll

        public RobotPosition()
        {
            X = Y = Z = W = P = R = 0;
        }

        public RobotPosition(float x, float y, float z, float w, float p, float r)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            P = p;
            R = r;
        }
    }
    // 로봇의 위치를 화면에 표시하는 컨트롤
    public class RobotDisplay : PictureBox
    {
        // 최소, 최대 위치
        private const float POSITION_MIN = -5000f;
        private const float POSITION_MAX = 5000f;

        // 현재 위치와 목표 위치
        private RobotPosition currentPosition;
        private RobotPosition targetPosition;

        private Timer animationTimer;
        private bool isMoving = false;
        public event EventHandler MovementCompleted;

        public RobotDisplay()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(400, 400);

            currentPosition = new RobotPosition();
            targetPosition = new RobotPosition();

            animationTimer = new Timer();
            animationTimer.Interval = 16; // 약 60fps
            animationTimer.Tick += AnimationTimer_Tick;
        }

        // 현재 위치 속성
        public RobotPosition Position
        {
            // 현재 위치 반환
            get => currentPosition;
            set
            {
                currentPosition = value;
                Invalidate();
            }
        }
        // 로봇을 이동시키는 메서드
        public void MoveTo(float x, float y, float z, float w = 0, float p = 0, float r = 0)
        {
            if (!isMoving)
            {
                // 목표 위치 설정
                targetPosition = new RobotPosition(
                    ClampPosition(x),
                    ClampPosition(y),
                    ClampPosition(z),
                    w, p, r
                );
                StartAnimation();
            }
        }
        // 로봇을 이동시키는 메서드 w, p, r은 그래픽으로 표시하지 않음
        private float ClampPosition(float value)
        {
            return Math.Max(POSITION_MIN, Math.Min(POSITION_MAX, value));
        }

        private void StartAnimation()
        {
            isMoving = true;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            const float stepSize = 2f;
            bool reachedTarget = true;

            // X, Y, Z 위치 업데이트
            reachedTarget &= UpdatePosition(ref currentPosition.X, targetPosition.X, stepSize);
            reachedTarget &= UpdatePosition(ref currentPosition.Y, targetPosition.Y, stepSize);
            reachedTarget &= UpdatePosition(ref currentPosition.Z, targetPosition.Z, stepSize);

            // W, P, R 업데이트
            reachedTarget &= UpdatePosition(ref currentPosition.W, targetPosition.W, stepSize);
            reachedTarget &= UpdatePosition(ref currentPosition.P, targetPosition.P, stepSize);
            reachedTarget &= UpdatePosition(ref currentPosition.R, targetPosition.R, stepSize);

            if (reachedTarget)
            {
                animationTimer.Stop();
                isMoving = false;
                MovementCompleted?.Invoke(this, EventArgs.Empty);
            }

            Invalidate();
        }
        // 현재 위치를 목표 위치로 이동시키는 메서드
        private bool UpdatePosition(ref float current, float target, float step)
        {
            if (Math.Abs(target - current) <= Math.Abs(step))
            {
                current = target;
                return true;
            }
            current += Math.Sign(target - current) * step;
            return false;
        }
        // scale 조정 (최소, 최대 좌표를 원의 크기에 맞춤)
        private float ScaleCoordinate(float value, float scaledMin, float scaledMax)
        {
            return (value - POSITION_MIN) / (POSITION_MAX - POSITION_MIN) *
                   (scaledMax - scaledMin) + scaledMin;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // 안티앨리어싱 적용
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // 중심점
            float centerX = 300;
            float centerY = 110;

            // 원 관련 변수 정의
            float circleRadius = 100;
            float circleY = 250;

            // X축 로봇 팔 관련 변수
            float arm1MaxLength = circleRadius * 2; // 원의 지름과 동일하게 설정
            float arm1StartX = centerX - circleRadius; // 원의 왼쪽 끝에서 시작

            // X축 로봇 팔 (가로 바)
            float scaledX = ScaleCoordinate(currentPosition.X, 0, 1); // X좌표를 0~1로 변환
            float arm1Length = arm1MaxLength * scaledX; // X좌표에 따라 길이 조절
            float arm1EndX = arm1StartX + arm1Length;  // X축 로봇팔이 끝나는 지점
            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.FillRectangle(brush, arm1StartX, centerY - 75, arm1Length, 15);
            }

            // Y축 로봇 팔 (세로 바) 
            float arm2Width = 10; // 굵기
            float scaledY = ScaleCoordinate(currentPosition.Y, 0, 1); // Y좌표를 0~1로 변환
            float arm2Height = 50 * scaledY; // Y좌표에 따라 길이 조절
            float arm2X = arm1EndX - arm2Width;  // X축 끝점에서 Y축 바의 중앙이 오도록 조정

            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.FillRectangle(brush, arm2X, centerY - 65, arm2Width, arm2Height);
            }

            // 원
            using (Brush brush = new SolidBrush(Color.White))
            using (Pen borderPen = new Pen(Color.Blue, 4)) // 테두리
            {
                g.DrawEllipse(borderPen, centerX - circleRadius, circleY - circleRadius, circleRadius * 2, circleRadius * 2);
                g.FillEllipse(brush, centerX - circleRadius, circleY - circleRadius, circleRadius * 2, circleRadius * 2);
            }

            // 원판 내부에 x,y 좌표축
            using (Pen pen = new Pen(Color.FromArgb(224, 224, 224), 2))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // 점선
                g.DrawLine(pen, centerX - circleRadius, circleY, centerX + circleRadius, circleY);
                g.DrawLine(pen, centerX, circleY - circleRadius, centerX, circleY + circleRadius);
            }

            // Y축 끝에서 아래로 향하는 실선
            float armEndX = arm2X + arm2Width / 2; // Y축 로봇팔의 중앙
            float armEndY = centerY - 65 + arm2Height; // Y축 로봇팔의 끝지점
            float lineLength = 30; // 선의 길이

            using (Pen pen = new Pen(Color.FromArgb(52, 199, 89), 4))
            {
                g.DrawLine(pen, armEndX, armEndY + 5, armEndX, circleY - circleRadius);
            }
            // Y축 로봇팔이 끝나는 지점 가로선
            using (Pen redPen = new Pen(Color.FromArgb(255, 59, 48), 5))
            {
                g.DrawLine(redPen, armEndX - lineLength / 2, armEndY, armEndX + lineLength / 2, armEndY);
            }
            // 십자선 
            float crosshairSize = 7;
            float normalizedX = ScaleCoordinate(currentPosition.X, -1, 1);
            float normalizedY = ScaleCoordinate(currentPosition.Y, -1, 1);
            float crosshairX = centerX + normalizedX * circleRadius;
            float crosshairY = circleY - normalizedY * circleRadius;
            using (Pen pen = new Pen(Color.FromArgb(255, 59, 48), 2))
            {
                // 가로선
                g.DrawLine(pen, crosshairX - crosshairSize, crosshairY, crosshairX + crosshairSize, crosshairY);
                // 세로선
                g.DrawLine(pen, crosshairX, crosshairY - crosshairSize, crosshairX, crosshairY + crosshairSize);
            }

            // 좌표 텍스트 표시
            using (Font font = new Font("맑은 고딕", 10))
            using (Brush textBrush = new SolidBrush(Color.Black))
            using (Pen borderPen = new Pen(Color.Black, 1)) // 테두리
            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }) // 텍스트 정렬
            {
                // X,Y,Z 좌표 텍스트
                string coordinates = $"X: {currentPosition.X:F2}\nY: {currentPosition.Y:F2}\nZ: {currentPosition.Z:F2}";
                float textX = arm2X + arm2Width + 20; // 로봇 팔 오른쪽에 표시
                float textY = centerY - 65 + arm2Height / 2; // Y축 로봇 팔의 중간 높이에 표시

                // 텍스트 배경
                using (Brush bgBrush = new SolidBrush(Color.FromArgb(220, 255, 255, 255)))
                {
                    SizeF textSize = g.MeasureString(coordinates, font);
                    RectangleF rect = new RectangleF(
                        textX - 2,
                        textY - textSize.Height / 2 - 2,
                        textSize.Width + 4,
                        textSize.Height + 4
                    );
                    g.FillRectangle(bgBrush, rect);  // 배경 채우기
                    g.DrawRectangle(borderPen, rect.X, rect.Y, rect.Width, rect.Height);  // 테두리 그리기
                }

                // 텍스트 그리기
                g.DrawString(coordinates, font, textBrush, textX, textY, sf);

                // W,P,R 텍스트 (십자선 옆)
                string wprText = $"W: {currentPosition.W:F2}\nP: {currentPosition.P:F2}\nR: {currentPosition.R:F2}";
                float wprTextX = crosshairX + 20; // 십자선 오른쪽에 표시
                float wprTextY = crosshairY;

                using (Brush wprBgBrush = new SolidBrush(Color.FromArgb(220, 255, 255, 255)))
                {
                    SizeF wprTextSize = g.MeasureString(wprText, font);
                    RectangleF wprRect = new RectangleF(
                        wprTextX - 2,
                        wprTextY - wprTextSize.Height / 2 - 2,
                        wprTextSize.Width + 4,
                        wprTextSize.Height + 4
                    ); // 텍스트 영역
                    g.FillRectangle(wprBgBrush, wprRect);  // 배경 채우기
                    g.DrawRectangle(borderPen, wprRect.X, wprRect.Y, wprRect.Width, wprRect.Height);  // 테두리 그리기
                }

                g.DrawString(wprText, font, textBrush, wprTextX, wprTextY, sf);
            }

            // 각도 텍스트 표시 (원의 끝점)
            using (Font angleFont = new Font("맑은 고딕", 12))
            using (Brush angleBrush = new SolidBrush(Color.Black))
            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }) // 텍스트 정렬
            {
                // 0°
                g.DrawString("0°", angleFont, angleBrush, centerX, circleY - circleRadius - 15, sf);
                // 90°
                g.DrawString("90°", angleFont, angleBrush, centerX + circleRadius + 20, circleY, sf);
                // 180°
                g.DrawString("180°", angleFont, angleBrush, centerX, circleY + circleRadius + 20, sf);
                // 270°
                g.DrawString("270°", angleFont, angleBrush, centerX - circleRadius - 20, circleY, sf);
            }
        }
    }
}
