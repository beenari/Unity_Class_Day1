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
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);              //Rat 를 cast한다

            RaycastHit hit;                                                            //Hit 케스트 선언

            if (Physics.Raycast(cast, out hit))                                          //Hit 된 것이 있을 때
            {
                GameObject temp = Instantiate(Temp);
                temp.transform.position = hit.point;


                Debug.Log(hit.collider.gameObject.name);                                //hit된 오브젝트 이름
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                //가상의 Line을 그려준다
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);              //Rat 를 cast한다

            RaycastHit hit;                                                            //Hit 케스트 선언

            if(Physics.Raycast(cast, out hit))                                          //Hit 된 것이 있을 때
            {
                Debug.Log(hit.collider.gameObject.name);                                //hit된 오브젝트 이름
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                //가상의 Line을 그려준다
                
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
