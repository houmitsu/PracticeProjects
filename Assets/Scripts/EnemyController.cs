using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("プレイヤーを検出した　-　攻撃せよ");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("プレイヤーは領域外。パトロール続行");
        }
    }
}
