using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJudgeBace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void OnCollisionEnter(Collision collision)
    {
            if(collision.gameObject.tag=="Gimck")
        {
            Destroy(this.gameObject);
        }
    }
}
