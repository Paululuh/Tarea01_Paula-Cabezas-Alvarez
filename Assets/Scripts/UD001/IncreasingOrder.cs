using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Zona variables globales
    // N�meros que usaremos para el incremento en orden.
    public int NumberOne,
               NumberTwo,
               NumberThree;

    void Start()
    {
        // Llamamos al m�todo.
        GetIncreasingOrder();

    }

    // Crearemos un m�todo que incrementar� en orden los n�meros.
    private void GetIncreasingOrder()
    {
        // Comprobamos si el primer n�mero es igual o menos que el segundo.
        // Y tambi�n comprobamos si el segundo es igual o menor que el tercero.
        if ((NumberOne <= NumberTwo) && (NumberTwo <= NumberThree))
        {
            // Si es as�, mostramos en la consola que el orden es creciente.
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " orden creciente.");
        }

        else
        {
            // Si no es as�, mostramos en la consola que el orden no es creciente.
            Debug.Log("Los n�meros" + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no orden creciente.");
        }
    }
}