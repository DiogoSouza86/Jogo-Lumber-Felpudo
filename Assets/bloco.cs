using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bloco : MonoBehaviour
{
    void BateDireita(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 2);
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().AddTorque(100.0f);
        Invoke("ApagaBlocos", 2.0f);
    }

    void BateEsquerda(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(10, 2);
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().AddTorque(-100.0f);
        Invoke("ApagaBlocos", 2.0f);
    }

    void ApagaBlocos(){
        Destroy(this.gameObject);
    }
}
