using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed=1f;
    Vector3 pos;
    Rigidbody rb;

    Status playerStatus = Status.GROUND;
    [SerializeField]
    float junpFirstSpeed;
    [SerializeField]
    float gravity;

    float timer = 0f;
    bool Junp = false;
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

        if(Input.GetKey("a"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);//âÒì]
            transform.Translate(speed*Time.deltaTime, 0, 0,Space.World);//worldç¿ïWånÇ≈à⁄ìÆ
        }
        if (Input.GetKey("d"))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);//âÒì]
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);//worldç¿ïWånÇ≈à⁄ìÆ

        }
        if (Input.GetKey(KeyCode.Space)
        {
            Junp=true
        }
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    /*void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
        float x = Input.GetAxis("Horizontal");
        rb.AddForce(speed, 0, 0);
    }*/

}
