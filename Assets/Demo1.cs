using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{
  
    public void DemoBtn()
    {
        TestSIngleton.instance.Print();
    }

}
