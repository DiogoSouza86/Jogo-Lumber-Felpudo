using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barra : MonoBehaviour
{
    float escalaBarra;
    bool comecou;
    bool terminou;
    public GameObject cameraCena;
    // Start is called before the first frame update
    void Start()
    {
        escalaBarra = this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (comecou){
            if(escalaBarra > 0.0f){
                escalaBarra = escalaBarra - 0.15f * Time.deltaTime;
                this.transform.localScale = new Vector2(escalaBarra, 1.0f);
            }else{
                if(!terminou){
                    terminou = true;
                    cameraCena.SendMessage("FimDeJogo");
                }
            } 
        }
    }

    void Comecou(){
        comecou = true;
    }

    void AumentaBarra(){
        escalaBarra = escalaBarra + 0.015f;
        if(escalaBarra > 1.0f){
            escalaBarra = 1.0f;
        }
    }
}
