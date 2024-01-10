using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }      //static�� ����� Instance ���

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;                        //this�� �ڽ��� class�� return�Ѵ�
            DontDestroyOnLoad(gameObject);          //MonoBehaviour ������ ���� GameObject�� �ҽ��� �ְ� �ı����� �ʰ��ϱ� ���� ����
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
