using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test2 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            TestSIngleton.instance.Print();
        }

        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(1);
        }
    }
}
