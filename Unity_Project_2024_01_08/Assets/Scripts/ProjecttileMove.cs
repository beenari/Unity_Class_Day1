using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class ProjecttileMove : MonoBehaviour
{
    public enum PROFECTILETYPE : int
    {
        PlAYER,
        ENEMY,
    }

    public float lifeTime = 10.0f;
    public float moveSpeed = 20.0f;
    public int damage = 1;

    public GameObject VFX_Fire_B;
    public GameObject VFX_WW_Explosion;

    public PROFECTILETYPE projectileType = PROFECTILETYPE.PlAYER;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ENEMY" && projectileType == PROFECTILETYPE.PlAYER)
        {
            Destroy(this.gameObject);

            Vector3 point = other.ClosestPoint(transform.position);                 //�浹�� �Ͼ ����Ʈ
            GameObject tempVFX = (GameObject)Instantiate(VFX_Fire_B, point, Quaternion.identity);       //�浹�� �Ͼ ����Ʈ�� ����Ʈ �߰�

            other.gameObject.GetComponent<EnemyController>().currentHp -= damage;

            if(other.gameObject.GetComponent<EnemyController>().currentHp <= 0)
            {
                Instantiate(VFX_WW_Explosion, point, Quaternion.identity); //������ �ı��Ǵ� �̺�Ʈ �߰�
                other.gameObject.GetComponent<EnemyController>().DropItems();
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.tag == "Player" && projectileType == PROFECTILETYPE.ENEMY)
        {
            Destroy(this.gameObject);
            Vector3 point = other.ClosestPoint(transform.position);                 //�浹�� �Ͼ ����Ʈ
            GameObject tempVFX = (GameObject)Instantiate(VFX_Fire_B, point, Quaternion.identity);       //�浹�� �Ͼ ����Ʈ�� ����Ʈ �߰�

            GameManager.Instance.currentHp -= damage;

            if (GameManager.Instance.currentHp <= 0)
            {
                Instantiate(VFX_WW_Explosion, point, Quaternion.identity);
                Destroy(other.gameObject);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameStation != GAMESTATION.PLAY) return;

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        lifeTime -= Time.deltaTime;

        if(lifeTime < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
