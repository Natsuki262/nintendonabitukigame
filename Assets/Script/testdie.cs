using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdie :BaceGimick
{
    // Start is called before the first frame update

    /// <summary>本棚のようなもの</summary>
    
   

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
       Die();
    }
    
}
