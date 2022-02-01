using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject spherPrefab;//球のプレハブ
  
    
    public delegate void FunctionDead();//死んだときに呼びだされる関数のデリゲート

    void Start()
    {
        SpherInstantiate();
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    void SpherInstantiate()
    {

     GameObject go=Instantiate(spherPrefab, transform.position, transform.rotation);
        go.GetComponent<testdie>().SetFunctionDead(Respwan);
      
        //生成した球をメンバ変数に保存
    }
  
    void Respwan()
    {
        SpherInstantiate();
    }

}
