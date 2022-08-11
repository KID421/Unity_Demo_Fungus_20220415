using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 當角色碰到終點時 GM 會知道
    public Player player;

    private void Awake()
    {
        #region Unity 委派與事件
        player.onTouchEnd.AddListener(EndGame);
        #endregion

        #region C# 委派與事件
        player.onEnd += EndGame;
        #endregion
    }

    public void EndGame()
    {
        print("GM 結束遊戲");
    }
}
