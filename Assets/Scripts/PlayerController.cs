//Castañeda Rivera Oscar David
//GDGS2101

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable que sirve para la velocidad que tiene el vehículo
    public float speed = 5.0f;

    //Variable que sirve para mover el vehículo hacía los lados, izquierda o derecha
    public float turnSpeed;

    //Variable que sirve para controlar el movimiento que hace el vehículo
    public float horizontalInput;
    public float forwardInput;

    void Start()
    {
        
    }
    
    void Update()
    {
        //Se indica que se podrá usar las teclas para el manejo del movimiento.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Se indica que se moverá el vehículo hacia adelante a la velocidad declarada al inicio
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Se indica que el vehículo podrá mover y controlar
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
