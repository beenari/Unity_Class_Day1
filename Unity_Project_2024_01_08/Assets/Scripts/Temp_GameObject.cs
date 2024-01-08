using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_GameObject : MonoBehaviour
{
    
    public int hp = 30;          //HP 변수 int 선언
    public float moveSpeed = 1.0f;
    public Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        hp = 50;                    //HP 시작시 50으로 설정
        pos = new Vector3(0, -5, 0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();

        if (Input.GetKeyDown(KeyCode.Space))            //GetKeyDown키 값 (키가 내려갔을때)
        {
            moveSpeed += 1;                              //tm
        }

        if (Input.GetKey(KeyCode.UpArrow))            //GetKey키 값 함수 설정 (키가 눌려져 있을때)
        {
            transform.position += new Vector3(0.0f, 1.0f * Time.deltaTime, 0.0f);       //Time.deltatime 프레임사이 시간을 알려주는 변수
        }
    }

    public void MoveCube()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * Time.deltaTime * moveSpeed;

        //if (Input.GetKey(KeyCode.UpArrow))
        //{   //Vector3(X,Y,Z)
        //    transform.position += new Vector3(0.0f, moveSpeed * Time.deltaTime, 0.0f);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position += new Vector3(0.0f, -moveSpeed * Time.deltaTime, 0.0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position += new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        //}
    }
}
