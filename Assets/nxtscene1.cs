using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxtscene1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(S1());
        
    }

    IEnumerator S1()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(3);
    }
}
