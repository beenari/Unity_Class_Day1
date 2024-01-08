using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if(player.transform.position.y < -50.0f)
            {
                player.transform.position = Vector3.zero + new Vector3(0.0f, 1.0f, 0.0f);
                player.transform.rotation = Quaternion.identity;
            }
        }
    }
}
