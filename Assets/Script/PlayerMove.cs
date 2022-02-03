using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 1f;

    Rigidbody rb;

    Status playerStatus = Status.Ground;
    [SerializeField]
    float junpSpeed;


    void Start()
    {
        Debug.Log(playerStatus);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("a"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);//âÒì]
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);//worldç¿ïWånÇ≈à⁄ìÆ
        }
        if (Input.GetKey("d"))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);//âÒì]
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);//worldç¿ïWånÇ≈à⁄ìÆ

        }


        if (Input.GetKeyDown(KeyCode.Space) && playerStatus == Status.Ground)
        {
            Junp();
        }

    }
    private void Junp()
    {
        rb.AddForce(Vector3.up * junpSpeed,ForceMode.VelocityChange);
        playerStatus = Status.Junp;
        Debug.Log(playerStatus);
    }


    //ê⁄ínÇ©Ç«Ç§Ç©
    void OnGroundEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            playerStatus = Status.Ground;
        Debug.Log("collisionenter");
    }
    private void OnCollisionEnter(Collision collision)
    {
        OnGroundEnter(collision);
        OnGimickEnter(collision);
    }
   void OnGimickEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gimck")
        {
            Destroy(this.gameObject);
        }
    }
   
}
