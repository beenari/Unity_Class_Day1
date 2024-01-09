using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public GameObject pivot;
    public Camera viewCamera;                       //메인 카메라를 받아오는 Camera 오브젝트
    public Vector3 velocity;                        //이동 값
    public Rigidbody body;                          //물리효과

    public int maxHp;
    public int currentHp;
    public int currentExp;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 1000;
        currentHp = 1000;

        viewCamera = Camera.main;                   //스트립트가 시작될떄 카메라를 받아온다
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;

        //화면에서 ->게임 3D공간 좌표를 변환해서 Vector3에 넣는다
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, viewCamera.transform.position.y));

        //공간좌표가 캐릭터보다 위에 있을경우 위를 쳐다보기 때문에 같은 y축 값을 맞춰준다
        Vector3 targetPosition = new Vector3(mousePos.x, pivot.transform.position.y,mousePos.z);

        //피봇이 해당 타겟을 바라보게 한다
        pivot.transform.LookAt(targetPosition, Vector3.up);
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + velocity * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER ENTER : " + other.gameObject.name);

        if(other.gameObject.tag == "ITEM")
        {
            if(other.gameObject.GetComponent<ItemController>().itemtype == ItemController.ITEMTYPE.HP_ITEM)
            {
                currentHp += other.gameObject.GetComponent<ItemController>().amount;
                if(currentHp > maxHp)
                {
                    currentHp = maxHp;
                }
            }

            if (other.gameObject.GetComponent<ItemController>().itemtype == ItemController.ITEMTYPE.EXP_ITEM)
            {
                currentExp += other.gameObject.GetComponent<ItemController>().amount;
            }

            Destroy(other.gameObject);
        }
    }
}
