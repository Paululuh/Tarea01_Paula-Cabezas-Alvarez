using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Variable globales dentro de la clase

    //N�mero introducido
    public int numberIntroducted;

    void Start()
    {
        //Llamamos al m�todo y le a�adimos el par�metro
        numberAddiction(numberIntroducted);
    }
    private void numberAddiction(int number)
    {
        //N�mero a a�adir
        int numberAdd = 0;

        //Nos aseguramos de que el n�mero que se coloque pueda ser sumado
        if (number >= 0)
        {
            //Se crea un bucle de suma de valores
            for (int i = 1; i <= number; i++)
            {
                //A�adimos el n�mero
                numberAdd += i;
            }
            //Mostramos en consola el mensaje
            Debug.Log("La suma de los n�meros entre 1 y el n�mero " + number + " es " + numberAdd + ".");
        }
        else
        {
            //Mostramos en consola un mensaje de que ponga un n�mero que pueda sumarse
            Debug.Log("El n�mero " + number + " no puede sumarse.");
        }
    }

}
