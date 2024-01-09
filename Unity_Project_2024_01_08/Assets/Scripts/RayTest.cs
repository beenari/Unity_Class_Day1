using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{

    public GameObject Temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);              //Rat �� cast�Ѵ�

            RaycastHit hit;                                                            //Hit �ɽ�Ʈ ����

            if (Physics.Raycast(cast, out hit))                                          //Hit �� ���� ���� ��
            {
                GameObject temp = Instantiate(Temp);
                temp.transform.position = hit.point;


                Debug.Log(hit.collider.gameObject.name);                                //hit�� ������Ʈ �̸�
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                //������ Line�� �׷��ش�
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);              //Rat �� cast�Ѵ�

            RaycastHit hit;                                                            //Hit �ɽ�Ʈ ����

            if(Physics.Raycast(cast, out hit))                                          //Hit �� ���� ���� ��
            {
                Debug.Log(hit.collider.gameObject.name);                                //hit�� ������Ʈ �̸�
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                //������ Line�� �׷��ش�
                
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
