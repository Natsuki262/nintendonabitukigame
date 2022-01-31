using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    GameObject gimickObject;

    [SerializeField]
    float waitTime;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WaitGeneretor());
    }

    // Update is called once per frame
    void Update()
    {
    }
    void GimmickGenerator()
    {
        Instantiate(gimickObject);
    }
    IEnumerator WaitGeneretor()
    {
        {
            GimmickGenerator();
            yield return new WaitForSeconds(waitTime);
        }
    }
}
