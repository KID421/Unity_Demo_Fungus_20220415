using UnityEngine;

#region Unity 委派與事件
using UnityEngine.Events;
#endregion

public class Player : MonoBehaviour
{
    #region Unity 委派與事件
    public UnityEvent onTouchEnd;
    #endregion

    #region C# 委派與事件
    public delegate void delegateNoReturnNoPar();
    public event delegateNoReturnNoPar onEnd;
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("終點"))
        {
            #region Unity 委派與事件
            onTouchEnd.Invoke();
            #endregion

            #region C# 委派與事件
            onEnd();
            #endregion
        }
    }
}
