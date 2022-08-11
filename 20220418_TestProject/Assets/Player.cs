using UnityEngine;

#region Unity �e���P�ƥ�
using UnityEngine.Events;
#endregion

public class Player : MonoBehaviour
{
    #region Unity �e���P�ƥ�
    public UnityEvent onTouchEnd;
    #endregion

    #region C# �e���P�ƥ�
    public delegate void delegateNoReturnNoPar();
    public event delegateNoReturnNoPar onEnd;
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("���I"))
        {
            #region Unity �e���P�ƥ�
            onTouchEnd.Invoke();
            #endregion

            #region C# �e���P�ƥ�
            onEnd();
            #endregion
        }
    }
}
