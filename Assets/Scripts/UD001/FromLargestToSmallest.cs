using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    void Start()
    {
        // Llamamos al m�todo.
        DescendingNumber();
    }

    // Creamos el m�todo para mostrar de forma ordenada el mayor n�mero hasta el menor.
    // Mostrar lista ordenada por consola
    private void DescendingNumber()
    {
        // Creamos un m�todo para comparar n�meros del m�s grande al m�s pequ��o.
        // Zona de variables locales
        int numberSmallest = 0;
        int numberMiddle = 0;
        int numberLargest = 0;

        // Comprobamos si el primer n�mero es menor que el segundo y el tercero.
        // "Number1" < "Number2" y "Number1 < "Number3"
        if (NumberOne < NumberTwo && NumberOne < NumberThree)
        {
            // Si es as�, lo almacenamos como n�mero m�s peque�o.
            numberSmallest = NumberOne;

            // Comprobamos si el segundo es m�s peque�o que el tercero.
            // "Number1" < "Number2" < "Number3"
            if (NumberTwo < NumberThree)
            {
                // Si es as�, lo almacenamos el segundo como el n�mero intermedio  y el tercero como el m�s grande.
                numberMiddle = NumberTwo;
                numberLargest = NumberThree;

            }

            // Si no, el tercero es el intermedio y el segundo el m�s grande.
            // "Number1" < "Number3" < "Number2"
            else
            {
                numberMiddle = NumberThree;
                numberLargest = NumberTwo;
            }
        }

        // Comprobamos si el segundo n�mero es el m�s peque�o que los dem�s.
        // "Number2" < "Number1 y "Number2 < "Number3"  
        else if (NumberTwo < NumberOne && NumberTwo < NumberThree)
        {
            // Si es as�, lo almacenamos como el m�s peque�o.
            numberSmallest = NumberTwo;

            // Comprobamos si el primero es m�s peque�o que el tercero.
            // "Number2 < "Number1" < "Number3"
            if (NumberOne < NumberThree)
            {
                // Si es as�, almacenamos el primero como el intermedio y el tercero como el m�s grande.
                numberMiddle = NumberOne;
                numberLargest = NumberThree;

                // Comrpobamos si el tercero es m�s peque�o que el primero.
                // "Number2" < "Number3" < "Number1"
                if (NumberThree < NumberOne)
                {
                    // Si es as�, almacenamos el segundo como el intermedio y el primero como el m�s grande.
                    numberMiddle = NumberTwo;
                    numberLargest = NumberOne;
                }

                // Si no, el primer n�mero ser� el intermedio y el segundo el m�s grande.
                // "Number3" < "Number1" > "Number2"
                else
                {
                    numberMiddle = NumberOne;
                    numberLargest = NumberTwo;
                }
            }

            // Mostrar en la consola.
            Debug.Log("Orden descendente de los n�meros es: '" + numberLargest + "' , '" + numberMiddle + "' , '" + numberSmallest + "' .");
        }
    }
}
