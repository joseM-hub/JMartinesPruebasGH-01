using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajes : MonoBehaviour
{
    public void Mensaje1()
    {
        print("Hola, este es el mensaje1");
    }

    public void Mensaje2()
    {
        print("Hola, este es el mensaje2");
    }

    public void Mensaje3(string nombre)
    {
        print("Hola" + nombre+", como estas");
    }
}
