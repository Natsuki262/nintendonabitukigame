using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    GameObject gimickObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GimmickGenerator();
    }
    void GimmickGenerator()
    {
        Instantiate(gimickObject);
    }
}
