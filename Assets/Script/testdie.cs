using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdie : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>�{�I�̂悤�Ȃ���</summary>
    SphereGenerator.FunctionDead m_functionDead;
    /// <summary>�{�P��</summary>
    public void SetFunctionDead(SphereGenerator.FunctionDead functionDead)///���������󂯎��O�̒P�̖̂{
    {
        m_functionDead= functionDead;
    }

    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        m_functionDead();//�f���Q�[�g�Ŏ󂯂��Ƃ����֐������s����܂�A����悩�炫���֐��̏����Ăяo��
        Destroy(gameObject);
    }
    
}
