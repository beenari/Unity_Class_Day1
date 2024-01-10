using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;                 //간단한 싱글톤 화

    //플레이어 데이터 
    public int maxHp = 100;
    public int currentHp = 100;
    public int level = 1;
    public int[] levelUpExp = new int[30];              //30레벨까지 설정
    public int currentExp = 0;
    public float moveSpeed = 10.0f;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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