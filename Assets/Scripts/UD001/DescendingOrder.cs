using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Zona variables globales
    // N�meros que usaremos para el incremento en orden.
    public int NumberOne,
               NumberTwo,
               NumberThree;

    void Start()
    {
        // Llamamos al m�todo.
        GetDescendingOrder();

    }

    // Crearemos un m�todo que incrementar� en orden los n�meros.
    private void GetDescendingOrder()
    {
        // Comprobamos si el primer n�mero es igual o mayor que el segundo.
        // Y tambi�n comprobamos si el segundo es igual o mayor que el tercero.
        if ((NumberOne >= NumberTwo) && (NumberTwo >= NumberThree))
        {
            // Si es as�, mostramos en la consola que el orden es decreciente.
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " orden decreciente.");
        }

        else
        {
            // Si no es as�, mostramos en la consola que el orden no es decreciente.
            Debug.Log("Los n�meros" + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no orden decreciente.");
        }
    }
}