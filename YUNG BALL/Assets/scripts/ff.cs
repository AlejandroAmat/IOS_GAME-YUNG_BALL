using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ff : MonoBehaviour
{
   public Text texto;
    movimiento script; 
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Sphere").GetComponent<movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "" + script.numactual;
        
    }
}
