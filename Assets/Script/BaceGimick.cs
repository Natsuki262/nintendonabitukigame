using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaceGimick : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>�{�I�̂悤�Ȃ���</summary>
  protected  SphereGenerator.FunctionDead m_functionDead;

    /// <summary>�{�P��</summary>
    public void SetFunctionDead(SphereGenerator.FunctionDead functionDead)///���������󂯎��O�̒P�̖̂{
    {
        m_functionDead = functionDead;
        Debug.Log("aaa");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   protected void Die()
    {
        m_functionDead();//�f���Q�[�g�Ŏ󂯂��Ƃ����֐������s����܂�A����悩�炫���֐��̏����Ăяo��
        Destroy(gameObject);

        //���̊֐��Ăяo���Ă�
        //�S�����l�ɓ���������̏����X�N���v�g�x�[�X�Ŏc���@�������v�����@�Ńf���Q�[�g�Ȃǂ����݂��Ȃ��ŏ����B
    }
}
