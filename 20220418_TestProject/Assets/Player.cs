using UnityEngine;

#region Unity 쯥В팒㉵τ
using UnityEngine.Events;
#endregion

public class Player : MonoBehaviour
{
    #region Unity 쯥В팒㉵τ
    public UnityEvent onTouchEnd;
    #endregion

    #region C# 쯥В팒㉵τ
    public delegate void delegateNoReturnNoPar();
    public event delegateNoReturnNoPar onEnd;
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("꾕헕"))
        {
            #region Unity 쯥В팒㉵τ
            onTouchEnd.Invoke();
            #endregion

            #region C# 쯥В팒㉵τ
            onEnd();
            #endregion
        }
    }
}
