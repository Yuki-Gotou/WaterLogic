using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    public Transform thisobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(thisobject.position.x>=17.65)
        {
            thisobject.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
        else
        {
            thisobject.position = new Vector3(thisobject.position.x + 0.01f, 0.0f, 0.0f);
        }
    }
}
