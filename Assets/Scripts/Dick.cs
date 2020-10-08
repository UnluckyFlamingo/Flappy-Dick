using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dick : MonoBehaviour
{

    public float jump = 200f;

    private bool isDead = false;
    private Rigidbody2D get2D;
    private Animator getAnim;

    // Asignamos el componente rigidbody2D a la variable "get2d"
    void Start()
    {
        get2D = GetComponent<Rigidbody2D>();
        getAnim = GetComponent<Animator>();
    }

    // Se comprueba si el jugador está muerto a cada frame para aplicar las mecánicas de juego. 
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0)) // Input de ratón, el 0 significa click izquierdo
            {
                get2D.velocity = Vector2.zero; // Se iguala la velocidad a 0 para que siempre se obtenga el mismo valor en el salto 
                get2D.AddForce(new Vector2(0, jump)); // Se aplica la fuerza de la variable "jump" al vector 2, se hace una variable publica para que edite desde el propio unity
                getAnim.SetTrigger("Flap"); // Se activa el trigger "Flap" para la animación
            }
        }
    }

    //La funcion "OnCollisionEnter2D" se ejecuta cada vez que se colisiona.
    private void OnCollisionEnter2D()
    {
        isDead = true; // Cambiamos la variable a true para que no podamos seguir dandole al ratón.
        getAnim.SetTrigger("Die"); //Se activa el trigger "Die" para la animación
    }

}
