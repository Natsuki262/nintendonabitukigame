using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 1f;

    Rigidbody rb;

   protected Status playerStatus = Status.Ground;
    [SerializeField]
    float junpSpeed;

    public GameObject risultGameobj;


    void Start()
    {
        Debug.Log(playerStatus);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   
    public virtual void Update()
    {


        if (Input.GetKey(KeyCode.A))
        {
           
        }
        if (Input.GetKey("d"))
        {
            

        }


        if (Input.GetKeyDown(KeyCode.Space) && playerStatus == Status.Ground)
        {
           
        }

    }
    protected void Junp()
    {
        rb.AddForce(Vector3.up * junpSpeed,ForceMode.VelocityChange);
        playerStatus = Status.Junp;
        Debug.Log(playerStatus);
    }
    protected void MoveR()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);//âÒì]
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);//worldç¿ïWånÇ≈à⁄ìÆ
    }
    protected void MoveL()
    {
        transform.rotation = Quaternion.Euler(0, -90, 0);//âÒì]
        transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);//worldç¿ïWånÇ≈à⁄ìÆ
    }


    //ê⁄ínÇ©Ç«Ç§Ç©
   private void OnGroundEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            playerStatus = Status.Ground;
        Debug.Log("collisionenter");
    }
    private void OnCollisionEnter(Collision collision)
    {
        OnGroundEnter(collision);
        OnGimickEnter(collision);
        OnChaserEnter(collision);
    }
  private void OnGimickEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gimck")
        {
             risultGameobj = collision.gameObject;
            Debug.Log(risultGameobj);
            Destroy(this.gameObject);
        }
    }
    private void OnChaserEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Chaser")
        {
           
            Destroy(gameObject);
        }
    }
        
   
}
