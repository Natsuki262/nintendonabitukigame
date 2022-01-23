using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 1f;
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
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*float rl = Input.GetAxis("Horizontal");
        var forece = new Vector3(rl, 0f, 0f);
        GetComponent<Rigidbody>().AddForce(forece * 2000);*/

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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("hit");
            Junp = true;
            Debug.Log(Junp);
        }
        else
        {
            Junp = false;
        }



    }

    public void FixedUpdate()
    {

        Vector3 newVec = Vector3.zero;

        switch (playerStatus)
        {
            //ê⁄ínéû
            case Status.GROUND:
                if (Junp)
                {
                    playerStatus = Status.UP;
                    Debug.Log(playerStatus);
                }
                break;
            //è„è∏
            case Status.UP:
                timer += Time.deltaTime;//éûä‘åvë™
                if (Junp && rb.velocity.y >= 0f)
                {
                    newVec.y = junpFirstSpeed;
                    newVec.y -= (gravity * timer);

                }
                else
                {
                    playerStatus=Status.DOWN;
                    timer = 0f;
                }
                break;
            case Status.DOWN:
                timer += Time.deltaTime;

                newVec.y = 0f;
                newVec.y=-(gravity * timer);
                break;
            default:
                break;
        }
        rb.velocity = newVec;   
    }
    //ê⁄ínÇ©Ç«Ç§Ç©
    private void OnCollisionEnter(Collision collision)
    {
        if (playerStatus==Status.DOWN&&collision.gameObject.name.Contains("Ground"))
        {
            playerStatus = Status.GROUND;
            timer = 0f;
        }
    }
}
