using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundPopUp : MonoBehaviour
{
    public GameObject PopObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUpObject()
    {
        Instantiate(PopObject, new Vector3(-18.0f, 0.0f, 0.0f), Quaternion.identity);
    }
}
