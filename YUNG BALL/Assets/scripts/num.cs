using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num : MonoBehaviour
    
{ movimiento script;
     Collider ecoli;

    int elnumerito;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Sphere").GetComponent<movimiento>();
        ecoli = gameObject.GetComponent<Collider>();

        
    }

    // Update is called once per frame
    void Update()
    {

        settrigger();

        elnumerito = Random.Range(script.numactual - (script.numactual -1), script.numactual + (script.numactual / 2));
        print(script.numactual);
        
        
    }

    void settrigger()
    {
        if (elnumerito <= script.numactual)
        {
            ecoli.isTrigger = true;

        }
        else
        {
            ecoli.isTrigger = false;
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        
    
        if (elnumerito <= script.numactual)
        {
            Destroy(gameObject);

            script.numactual = script.numactual - elnumerito;
    
        }
    }
}
