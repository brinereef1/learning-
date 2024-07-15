using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject fire;
    public bool isfire;

    public float delayOnFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delayOnFire += Time.deltaTime;
        

        if (isfire && delayOnFire > 0.6)
        {
            Firing();
            delayOnFire = 0;
        }
    }

    public void Firing()
    {
            var obj = Instantiate(fire, transform.position, transform.rotation); 
    }
}
