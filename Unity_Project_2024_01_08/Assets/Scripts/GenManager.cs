using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManager : MonoBehaviour
{
    public Camera viewCamera;                       //메인 카메라를 받아오는 Camera 오브젝트
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
            //화면에서 ->게임 3D공간 좌표를 변환해서 Vector3에 넣는다
            Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, viewCamera.transform.position.y));

            GameObject temp = (GameObject)Instantiate(Enemy, mousePos, Quaternion.identity);
            temp.transform.position += new Vector3(0.0f, 1.0f, 0.0f);
        }

    }
}
