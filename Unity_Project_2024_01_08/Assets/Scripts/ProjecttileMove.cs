using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecttileMove : MonoBehaviour
{
    public float lifeTime = 10.0f;
    public float moveSpeed = 20.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        lifeTime -= Time.deltaTime;

        if(lifeTime < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
