using System;
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
    public class RobotControl : UserControl
    {

        public RobotControl()
        {
        }
    }
}
