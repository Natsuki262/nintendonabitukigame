using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : PlayerBase
{
    // Start is called before the first frame update
    

    // Update is called once per frame
  public override void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {

            MoveL();
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            MoveR();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)&& playerStatus == Status.Ground)
        {
            Junp();
        }

    }
}
