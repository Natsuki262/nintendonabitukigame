using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject spherPrefab;//���̃v���n�u
  
    
    public delegate void FunctionDead();//���񂾂Ƃ��ɌĂт������֐��̃f���Q�[�g

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
      
        //�����������������o�ϐ��ɕۑ�
    }
  
    void Respwan()
    {
        SpherInstantiate();
    }

}
