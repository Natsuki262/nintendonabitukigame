using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject spherPrefab;//球のプレハブ
    GameObject instantiatedSpher;
    void Start()
    {
        SpherInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
       

        IsDied();
    }
    void SpherInstantiate()
    {

        instantiatedSpher = Instantiate(spherPrefab, transform.position, transform.rotation);
        //生成した球をメンバ変数に保存
    }
    bool IsDied()
    {

        if (instantiatedSpher == null)
        {
            return true;

        }
        return false;
    }

}
