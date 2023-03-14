using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    //Arreglo para guardar los Sprites (imagenes del pokemons) 4 references
    public Sprite[] memoImageArray;
    //Arreglo para guardar el componente imagen perteneciente a los elementos de UI 4 references
    public Image[] memoPositionArray;
    //Sprite que pertenece al reverso de la carta
    public Sprite reverso;
    //Nombre de la primer carta seleccionada
    private string card1;
    //posicion en el arreglo de la carta seleccionada
    private int indexCard1;
    //Nombre de la segunda carta seleccionada
    private string card2;
    //Posicion en el arreglo de la segunda carta seleccionada
    private int indexCard2;


    public void FlipCard(int index)
    {
    //Pregunta si ya tenemos una primera seleccion

    if (card1 == null)
    {
        //Si no ten mos ninguna carta seleccionada guarda los datos de la carta que se acaba de seleccionar 
        card1 = memoImageArray[index].name;
        memoPositionArray[index]. sprite = memoImageArray[index];
        indexCard1 = index;
    }
    //En caso de tener una primer carta, verificamos si hay una segunda carta ya seleccionada  
    else if (card2 == null)
    {
        card2 = memoImageArray[index].name;
        memoPositionArray[index]. sprite = memoImageArray[index];
        indexCard2 = index;
    }
    else
    {
        //En caso de que ya se selecciono la primera y segunda carta 
        Debug.Log("seleccion realizada, hay que verificar");
    }
}

    public void CheckSeleccion()
    {
        //si los nombresde las dos cartas son iguales
        if (card1 == card2)
        {
            //mandamos un mensaje de exito y volver a reiniciar los datos de las cartas para poder volver a seleccionar mas
            Debug.Log("Exito, Carta encontrada");
            card1 = null;
            card2 = null;
            indexCard1 = 0;
            indexCard2 = 0;
        }
        else
        //si las cartasno se llaman igual entonces hay un error
        {
            Debug.Log("Las cartas eran erroneas");
            //mandamos un mensaj de exito y volver a reiniciar los datos de las cartas para poder volver a seleccionar mas
            memoPositionArray[indexCard1].sprite = reverso;
            memoPositionArray[indexCard2].sprite = reverso;
            card1 = null;
            card2 = null;
            indexCard1 = 0;
            indexCard2 = 0;
        }
    }
}