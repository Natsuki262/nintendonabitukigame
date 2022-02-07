using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaceGimick : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>本棚のようなもの</summary>
  protected  SphereGenerator.FunctionDead m_functionDead;

    /// <summary>本単体</summary>
    public void SetFunctionDead(SphereGenerator.FunctionDead functionDead)///こっちが受け取る前の単体の本
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
        m_functionDead();//デリゲートで受けっとった関数を実行するつまり、送り先からきた関数の情報を呼び出す
        Destroy(gameObject);

        //この関数呼び出してね
        //鬼が村人に当たったらの処理スクリプトベースで残す　自分が思う方法でデリゲートなどをかみしないで書く。
    }
}
