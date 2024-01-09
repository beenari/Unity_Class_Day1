using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public GameObject pivot;
    public Camera viewCamera;                       //���� ī�޶� �޾ƿ��� Camera ������Ʈ
    public Vector3 velocity;                        //�̵� ��
    public Rigidbody body;                          //����ȿ��

    public int maxHp;
    public int currentHp;
    public int currentExp;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 1000;
        currentHp = 1000;

        viewCamera = Camera.main;                   //��Ʈ��Ʈ�� ���۵ɋ� ī�޶� �޾ƿ´�
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;

        //ȭ�鿡�� ->���� 3D���� ��ǥ�� ��ȯ�ؼ� Vector3�� �ִ´�
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, viewCamera.transform.position.y));

        //������ǥ�� ĳ���ͺ��� ���� ������� ���� �Ĵٺ��� ������ ���� y�� ���� �����ش�
        Vector3 targetPosition = new Vector3(mousePos.x, pivot.transform.position.y,mousePos.z);

        //�Ǻ��� �ش� Ÿ���� �ٶ󺸰� �Ѵ�
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
