using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ei : MonoBehaviour
{   int NumeroAmor = 0;
    movimiento script;
   
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Sphere").GetComponent<movimiento>();

    }

    // Update is called once per frame
    void Update()
    {
        NumeroAmor = Random.Range(1, script.numactual);
    }
    private void OnTriggerEnter(Collider other)
    {
        script.numactual = script.numactual + NumeroAmor;
        Destroy(gameObject);
    }
}
