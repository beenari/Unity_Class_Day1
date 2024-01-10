using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerricContainerSample : MonoBehaviour
{
    private GenericContainer<int> intContaianer;            //제너릭 int로 선언
    private GenericContainer<string> stringContaianer;      //제너릭 string으로 선언
    //private GenericContainer<PlayerController> playerController;

    // Start is called before the first frame update
    void Start()
    {
        intContaianer = new GenericContainer<int>(5);
        stringContaianer = new GenericContainer<string>(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            intContaianer.Add(Random.Range(0, 100));
            DisplayContainerItems(intContaianer);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            string randomString = "item" + Random.Range(0, 100);
            stringContaianer.Add(randomString);
            DisplayContainerItems(intContaianer);
        }
    }

    private void DisplayContainerItems<T>(GenericContainer<T> container)
    {
        T[] items = container.GetItems();
        string temp = "";
        for(int i = 0; i < items.Length; i++)
        {
            if (items[i] != null) temp += items[i].ToString() + " - ";
            else temp += "Empty - ";
        }
        Debug.Log(temp);
    }
}
