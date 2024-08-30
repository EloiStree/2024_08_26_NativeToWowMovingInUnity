
using System.Collections.Generic;
using UnityEngine.Events;
using WindowsInput.Native;

public class WindowWowInputMono : AbstractWowMoveInputMono
{

    public ThreadWindowSimListenerMono m_threadListener;
    public WindowsInput.Native.VirtualKeyCode  m_moveForward= VirtualKeyCode.UP;
    public WindowsInput.Native.VirtualKeyCode  m_moveBack= VirtualKeyCode.DOWN;
    public WindowsInput.Native.VirtualKeyCode  m_rotateLeft= VirtualKeyCode.LEFT;
    public WindowsInput.Native.VirtualKeyCode m_rotateRight= VirtualKeyCode.RIGHT;
    public WindowsInput.Native.VirtualKeyCode  m_rotateUp =VirtualKeyCode.VK_Y;
    public WindowsInput.Native.VirtualKeyCode  m_rotateDown= VirtualKeyCode.VK_H;
    public WindowsInput.Native.VirtualKeyCode  m_moveUp = VirtualKeyCode.VK_I;
    public WindowsInput.Native.VirtualKeyCode  m_moveDown = VirtualKeyCode.VK_K;
    public WindowsInput.Native.VirtualKeyCode  m_strafeLeft = VirtualKeyCode.VK_J;
    public WindowsInput.Native.VirtualKeyCode  m_strafeRight = VirtualKeyCode.VK_L;




    public UnityEvent<bool> m_isMovingForward;
    public UnityEvent<bool> m_isMovingBack;
    public UnityEvent<bool> m_isRotatingLeft;
    public UnityEvent<bool> m_isRotatingRight;
    public UnityEvent<bool> m_isRotatingUp;
    public UnityEvent<bool> m_isRotatingDown;
    public UnityEvent<bool> m_isMovingUp;
    public UnityEvent<bool> m_isMovingDown;
    public UnityEvent<bool> m_isStrafeLeft;
    public UnityEvent<bool> m_isStrafeRight;

    public void Update()
    {
        List<WindowsInput.Native.VirtualKeyCode> windowKeys = m_threadListener.GetWindowKey();

        m_inputState.m_moveBackIsDown = windowKeys.Contains(m_moveBack);
        m_inputState.m_moveForwardIsDown = windowKeys.Contains(m_moveForward);
        m_inputState.m_rotateLeftIsDown = windowKeys.Contains(m_rotateLeft);
        m_inputState.m_rotateRightIsDown = windowKeys.Contains(m_rotateRight);
        m_inputState.m_rotateUpIsDown = windowKeys.Contains(m_rotateUp);
        m_inputState.m_rotateDownIsDown = windowKeys.Contains(m_rotateDown);
        m_inputState.m_moveUpIsDown = windowKeys.Contains(m_moveUp);
        m_inputState.m_moveDownIsDown = windowKeys.Contains(m_moveDown);
        m_inputState.m_strafeLeftIsDown = windowKeys.Contains(m_strafeLeft);
        m_inputState.m_strafeRightIsDown = windowKeys.Contains(m_strafeRight);
            

        
    }


}