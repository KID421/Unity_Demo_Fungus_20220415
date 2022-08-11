using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ����I����I�� GM �|���D
    public Player player;

    private void Awake()
    {
        #region Unity �e���P�ƥ�
        player.onTouchEnd.AddListener(EndGame);
        #endregion

        #region C# �e���P�ƥ�
        player.onEnd += EndGame;
        #endregion
    }

    public void EndGame()
    {
        print("GM �����C��");
    }
}
