using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class SystemManager : MonoBehaviour
{
    public enum ROUNDTYPE : int
    {
        NORMAL,
        BOSS
    }

    public ROUNDTYPE roundtype = ROUNDTYPE.NORMAL;

    public int roundindex = 1;
    public float roundTime = 0.0f;
    public float roundEndTime = 30.0f;

    public float spawnTime = 0.0f;
    public float nextspawnTime = 2.0f;

    public GameObject[] EnemyObjects;
    public Transform[] spawntransform;

    public GameObject EnemyBossObjects;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameStation != GAMESTATION.PLAY) return;

        if (player != null)
        {
            if(roundtype == ROUNDTYPE.NORMAL)
            {
                spawnTime += Time.deltaTime;
                roundTime += Time.deltaTime;
            }
            //else if(roundtype == ROUNDTYPE.BOSS)
            //{
            //    if(EnemyBossCheck == null)
            //    {
            //        roundtype = ROUNDTYPE.NORMAL;
            //    }
            //}

            //if(roundEndTime <= roundTime)
            //{
            //    int SpawntransformCount = spawntransform.Length;
            //    int RandSpawntransformNumber = Random.Range(0, SpawntransformCount);

            //    GameObject temp = (GameObject)Instantiate(
            //        EnemyBossObjects[roundindex])
            //}

            if (nextspawnTime <= spawnTime)
            {
                spawnTime = 0.0f;
                nextspawnTime = Random.Range(0.5f, 2.0f);   //�������� ���� ���� �ð��� �����Ѵ�. 

                int EnemyObjectsCount = EnemyObjects.Length;            //����� �� ��ü�� ���ڸ� �����´�.
                int SpawntransformCount = spawntransform.Length;        //����� ���� ����Ʈ�� ������ �����´�.

                int RandEnemyObjectNumer = Random.Range(0, EnemyObjectsCount);      //������ ���ڸ� �ִ�� ���� ���� ���ڸ� ���� 
                int RandSpawntransformNumer = Random.Range(0, SpawntransformCount); //������ ���ڸ� �ִ�� ���� ���� ���ڸ� ���� 

                //�ش� ���� ���ڸ� ������� ��ϵ� ���� �迭 ��ȣ�� ���� ����Ʈ ��ȣ�� ��ġ�� ���� ���� ��Ų��. 
                GameObject temp = (GameObject)Instantiate(
                    EnemyObjects[RandEnemyObjectNumer], spawntransform[RandSpawntransformNumer].position, Quaternion.identity);

            }


            if (player.transform.position.y < -50.0f)
            {
                player.transform.position = Vector3.zero + new Vector3(0.0f, 1.0f, 0.0f);
                player.transform.rotation = Quaternion.identity;

                int EnemyObjectsCount = EnemyObjects.Length;
                int spawntransformCount = EnemyObjects.Length;

                int RandEnemyObjectNumber = Random.Range(0,EnemyObjectsCount);
                int RandSpawntransformNumber = Random.Range(0, spawntransformCount);

                GameObject temp = (GameObject)Instantiate(
                    EnemyObjects[RandEnemyObjectNumber], spawntransform[RandSpawntransformNumber].position, Quaternion.identity);
            }
        }
    }
}
