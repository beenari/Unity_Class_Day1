using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;                 //������ �̱��� ȭ

    //�÷��̾� ������ 
    public int maxHp = 100;
    public int currentHp = 100;
    public int level = 1;
    public int[] levelUpExp = new int[30];              //30�������� ����
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
            
        }
    }
}