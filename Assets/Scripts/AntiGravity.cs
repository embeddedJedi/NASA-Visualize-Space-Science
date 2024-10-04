using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravity : MonoBehaviour
{
  
    public Vector3 gravity = new Vector3(0, -0.5f, 0); // Sıfıra yakın bir yer çekimi kuvveti
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Unity'nin yer çekimi etkisini devre dışı bırakıyoruz
    }

    void FixedUpdate()
    {
        rb.AddForce(gravity * rb.mass); // Düşük yer çekimi kuvveti uyguluyoruz
    }
}
