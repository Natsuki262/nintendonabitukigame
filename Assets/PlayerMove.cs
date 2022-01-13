using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    float speed=1f;
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*float rl = Input.GetAxis("Horizontal");
        var forece = new Vector3(rl, 0f, 0f);
        GetComponent<Rigidbody>().AddForce(forece * 2000);*/

        if(Input.GetKey("a"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position-=transform.right * speed * Time.deltaTime;   
        }


    }
    
}
