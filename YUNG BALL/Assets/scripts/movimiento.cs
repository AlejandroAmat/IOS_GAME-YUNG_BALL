using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public Rigidbody pelota;
    public float speed = 5f;
    public float sppedlado = 1.5f;
    public int numactual;

    void Start()
    {
        numactual = 50;
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 raton = Input.mousePosition;
        Vector3 moovimiento = new Vector3(0f, 0f, 10f);
        pelota.AddForce(moovimiento * speed * Time.deltaTime);
        gameObject.transform.position = new Vector3(raton.x, transform.position.y, transform.position.z);
    }
}
