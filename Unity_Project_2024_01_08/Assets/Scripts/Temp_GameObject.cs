using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_GameObject : MonoBehaviour
{

    public int hp = 30;          //HP ���� int ����

    // Start is called before the first frame update
    void Start()
    {
        hp = 50;                    //HP ���۽� 50���� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))            //GetKeyDownŰ �� 
        {
            hp -= 1;                //hp = hp - 1
        }
    }
}
