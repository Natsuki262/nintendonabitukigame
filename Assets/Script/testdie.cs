using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdie : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>本棚のようなもの</summary>
    SphereGenerator.FunctionDead m_functionDead;
    /// <summary>本単体</summary>
    public void SetFunctionDead(SphereGenerator.FunctionDead functionDead)///こっちが受け取る前の単体の本
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
        m_functionDead();//デリゲートで受けっとった関数を実行するつまり、送り先からきた関数の情報を呼び出す
        Destroy(gameObject);
    }
    
}
