using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = player.transform.position;
        transform.position = Pos + new Vector3(0.0f, 20.0f, 0.0f);
    }
}
