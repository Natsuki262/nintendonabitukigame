using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject spherPrefab;//���̃v���n�u
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
        //�����������������o�ϐ��ɕۑ�
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
