using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject spherPrefab;//���̃v���n�u
    GameObject instantiatedSpher;
    
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

        instantiatedSpher = Instantiate(spherPrefab, transform.position, transform.rotation);
        //�����������������o�ϐ��ɕۑ�
    }
  
    void Respwan()
    {
       
    }

}
