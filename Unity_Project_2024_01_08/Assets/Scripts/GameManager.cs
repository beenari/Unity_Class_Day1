using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;                 //간단한 싱글톤 화

    public enum GAMESTATION : int
    {
        READY,
        PLAY = 10,
        STOP,
        LEVELUPUI = 20,
        END = 30
    }

    //플레이어 데이터 
    public int currentHp = 100;
    public int level = 1;
    public int[] levelUpExp = new int[30];              //30레벨까지 설정
    public int currentExp = 0;

    public int maxHp = 100;
    public float moveSpeed = 10.0f;
    public float fireSpeed = 4.0f;
    public int playerPower = 1;

    public GAMESTATION gameStation = GAMESTATION.READY;

    private void Awake()
    {
        Instance = this;
    }

    public void ExpUp(int amount)
    {
        if (level == levelUpExp.Length) return;

        currentExp += amount;
        LevelupCheck();
    }

    public void LevelupCheck()                          //레벨업 체크 함수
    {
        if(currentExp >= levelUpExp[level - 1])         //기존 경험치가 필요 경험치보다 클 경우
        {
            currentExp -= levelUpExp[level - 1];        //
            level += 1;

            if(level >= levelUpExp.Length)
            {
                level = levelUpExp.Length;
            }
            
        }
    }
}