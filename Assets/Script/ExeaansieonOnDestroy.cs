using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExpandOnDestroy : MonoBehaviour
{
    [SerializeField]
    private UnityEvent m_defultEvent = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDestroy()
    {
        m_defultEvent.Invoke();

    }

}
