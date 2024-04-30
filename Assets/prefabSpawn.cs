using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabSpawn : MonoBehaviour
{
    public GameObject prefab; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
