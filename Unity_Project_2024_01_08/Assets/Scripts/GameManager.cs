using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;                 //������ �̱��� ȭ

    public enum GAMESTATION : int
    {
        READY,
        PLAY = 10,
        STOP,
        LEVELUPUI = 20,
        END = 30
    }

    //�÷��̾� ������ 
    public int currentHp = 100;
    public int level = 1;
    public int[] levelUpExp = new int[30];              //30�������� ����
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

    public void HpLevelUp()
    {
        maxHp += 10;
        GameUIManager.instance.levelUpPanel_OnOff(false);
        gameStation = GAMESTATION.PLAY;
    }

    public void moveSpeedLevelUp()
    {
        moveSpeed += 0.1f;
        GameUIManager.instance.levelUpPanel_OnOff(false);
        gameStation = GAMESTATION.PLAY;
    }

    public void fireSpeedLevelUp()
    {
        fireSpeed += 0.5f;
        GameUIManager.instance.levelUpPanel_OnOff(false);
        gameStation = GAMESTATION.PLAY;
    }

    public void PowerLevelUp()
    {
        playerPower += 1;
        GameUIManager.instance.levelUpPanel_OnOff(false);
        gameStation = GAMESTATION.PLAY;
    }

    public void Start()
    {
        GameUIManager.instance.levelUpPanel_OnOff(false);
    }

    public void GamePlay()
    {
        gameStation = GAMESTATION.PLAY;
    }

    public void GamePlayStop()
    {
        gameStation = GAMESTATION.STOP;
    }

    public void GamePlayLevelUp()
    {
        gameStation = GAMESTATION.LEVELUPUI;
    }

    public void ExpUp(int amount)
    {
        if (level == levelUpExp.Length) return;

        currentExp += amount;
        LevelupCheck();
    }

    public void LevelupCheck()                          //������ üũ �Լ�
    {
        if(currentExp >= levelUpExp[level - 1])         //���� ����ġ�� �ʿ� ����ġ���� Ŭ ���
        {
            currentExp -= levelUpExp[level - 1];        //
            level += 1;

            if(level >= levelUpExp.Length)
            {
                level = levelUpExp.Length;
            }
            GameUIManager.instance.levelUpPanel_OnOff(true);
            gameStation = GAMESTATION.LEVELUPUI;
            
        }
    }
}