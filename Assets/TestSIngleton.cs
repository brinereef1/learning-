using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSIngleton : MonoBehaviour
{
    public int i = 0;
    public static TestSIngleton instance;


    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(instance);

        DontDestroyOnLoad(this);

    }


    public void Print()
    {
        i++;
        Debug.Log("Incrimented to "+ i);
    }
}
