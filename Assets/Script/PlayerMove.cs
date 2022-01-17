using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed=1f;
    Vector3 pos;
    public Rigidbody rb;
    void Start()
    {
        pos = transform.position;
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*float rl = Input.GetAxis("Horizontal");
        var forece = new Vector3(rl, 0f, 0f);
        GetComponent<Rigidbody>().AddForce(forece * 2000);*/

        /*if(Input.GetKey("a"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);//‰ñ“]
            transform.position+=transform.forward*speed*Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);//‰ñ“]
            transform.position += transform.forward * speed;
        }*/
        


    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizotal");
        transform.rotation = Quaternion.Euler(0, 90, 0);
        rb.AddForce(x, 0, 0);
    }

}
