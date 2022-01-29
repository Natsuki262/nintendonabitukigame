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
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine((IEnumerator)waitGeneretor());
    }
    void GimmickGenerator()
    {
        Instantiate(gimickObject);
    }
    IEnumerator waitGeneretor()
    {
        {
            GimmickGenerator();
            yield return new WaitForSeconds(waitTime);
        }
    }
}