using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string labelText = "4つのアイテムを集めて自由を勝ち取ろう";
    public int maxItems = 4;
    public bool showWininScreen = false;

    private int _itemsCollected = 0;

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            //Debug.LogFormat("Items: {0}", _itemsCollected);

            if(_itemsCollected >= maxItems)
            {
                labelText = "アイテムを全部見つけたね！";
                showWininScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "アイテムを見つけたね。あと"
                    + (maxItems - _itemsCollected) + "つだよ！";
            }
        }
    }

    private int _playerHP = 10;

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "プレイヤーのHP:"
            + _playerHP);

        GUI.Box(new Rect(20, 50, 150, 25), "あつめたアイテム:"
            + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height
            - 50, 300, 50), labelText);

        if(GUI.Button(new Rect(Screen.width/2 -100,
            Screen.height/2 - 50, 200, 100), "きみの勝ちだ！"))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }
    }
}
