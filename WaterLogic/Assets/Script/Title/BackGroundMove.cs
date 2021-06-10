using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    public Transform thisobject;
    public float MoveSpeed;
    public BackGroundPopUp BackGroundPopUp;
    private bool PopUpFlg;
    
    // Start is called before the first frame update
    void Start()
    {
        PopUpFlg = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(thisobject.position.x>=35.5)
        {
            Destroy(this.gameObject);
        }
        else if(thisobject.position.x>=17.5f&& PopUpFlg==true)
        {
            BackGroundPopUp.PopUpObject();
            PopUpFlg = false;
            Debug.Log("ê∂ê¨");
        }
        else
        {
            thisobject.position = new Vector3(thisobject.position.x + MoveSpeed, 0.0f, 0.0f);
        }
    }
}
