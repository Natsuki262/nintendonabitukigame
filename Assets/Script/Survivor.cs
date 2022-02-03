using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivor :PlayerBase
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    public override void  Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            MoveR();
        }
        if(Input.GetKey(KeyCode.D))
        {
            MoveL();
        }
        if(Input.GetKeyDown(KeyCode.Space)&& playerStatus == Status.Ground)
        {
            Junp();

        }
    }
    
}
