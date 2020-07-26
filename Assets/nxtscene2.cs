using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxtscene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(S2());
        
    }

    IEnumerator S2()
    {
        yield return new WaitForSeconds(24);
        Application.Quit();
    }
}
