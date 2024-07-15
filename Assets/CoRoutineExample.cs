using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class CoRoutineExample : MonoBehaviour
{

    Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody.AddForce(Vector3.forward);
        Test(2);
    }

#if UNITY_ANDROID

    public void AndroidFunction()
    {
        saasasasa
    }

#endif


    public void Test(int i, int j = 0)
    {
        var sum = i + j;
    }

}
