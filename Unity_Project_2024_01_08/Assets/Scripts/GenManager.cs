using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManager : MonoBehaviour
{
    public Camera viewCamera;                       //���� ī�޶� �޾ƿ��� Camera ������Ʈ
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            //ȭ�鿡�� ->���� 3D���� ��ǥ�� ��ȯ�ؼ� Vector3�� �ִ´�
            Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, viewCamera.transform.position.y));

            GameObject temp = (GameObject)Instantiate(Enemy, mousePos, Quaternion.identity);
            temp.transform.position += new Vector3(0.0f, 1.0f, 0.0f);
        }

    }
}
