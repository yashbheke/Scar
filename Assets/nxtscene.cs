using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxtscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(S());
        
    }

    IEnumerator S()
    {
        yield return new WaitForSeconds(36);
        SceneManager.LoadScene(2);
    }
}
