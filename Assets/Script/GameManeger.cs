using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{


    [SerializeField]
    Text m_risultText;

    bool isJurge = false;

    /*public void SetFunctionRisult(PlayerBase.FunctionRisult functionRisult)
    {
        m_risult = functionRisult;
        Debug.Log("zzz");
    }*/
    void Start()
    {
        //ChaserDie();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChaserDie()
    {

        if (isJurge)
        {
            return;
        }
        else
        {
            m_risultText.GetComponent<Text>().text = "ë∫êlÇÃèüÇø";
            isJurge = true;
            StartCoroutine(Wait());
            
            

        }

    }
    public void SurvivorDie()
    {

        if (isJurge)
        {
            return;
        }
        else
        {

            m_risultText.GetComponent<Text>().text = "ãSÇÃèüÇø";
            isJurge = true;
            StartCoroutine(Wait());
           
            
        }
    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Title");

    }
}
