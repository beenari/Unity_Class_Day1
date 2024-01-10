using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }      //static을 사용해 Instance 등록

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;                        //this는 자신의 class를 return한다
            DontDestroyOnLoad(gameObject);          //MonoBehaviour 동작을 위해 GameObject에 소스를 넣고 파괴되지 않게하기 위해 선언
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int playerScore = 0;

    public void AddScore(int amount)
    {
        playerScore += amount;
    }
}
