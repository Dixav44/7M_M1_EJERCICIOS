using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathLogic : MonoBehaviour
{
  public int[] numeros = { 1, 2, 3, 4, 5 };
  public TextMeshProUGUI opciones;
  public TextMeshProUGUI resultadoText;
  public TMP_InputField numero1Input;
  public TMP_InputField numero2Input;
  public TextMeshProUGUI signal;
  private bool esSuma = true;

  // Start is called before the first frame update
  void Start()
  {
    //llenado del texto de las opciones
    opciones.text = ArrayToString(numeros);
    //elegir dos numeros de forma aleatoria
    int num1 = numeros[Random.Range(0, numeros.Length)];
    int num2 = numeros[Random.Range(0, numeros.Length)];

    //elegir calculo de suma o resta
    esSuma = calculaSigno();

    if (esSuma)
    {
      resultadoText.text = (num1 + num2).ToString();
    }
     else
    {
      resultadoText.text = (num1 - num2).ToString();
    }
  }

  public void Verificar()
  {
    int num1 = int.Parse(numero1Input.text);
    int num2 = int.Parse(numero2Input.text);
    int resultado = int.Parse(resultadoText.text);

    if (esSuma)
    {
      if (num1 + num2 == resultado)
      {
        Debug.Log("Respuesta Correcta");
      }
      else
      {
        Debug.Log("Respuesta Incorrecta");
      }
    }
    else
    {
      if (num1 - num2 == resultado)
      {
        Debug.Log("Respuesta Correcta");
      }
      else
      {
        Debug.Log("Respuesta Incorrecta");
      }
    }
  }

  private bool calculaSigno()
  {
    bool result = true;
    if (Random.Range(0f, 1f) > 0.5f)
    {
      result = false;
      signal.text = "-";
    }else{
      signal.text = "+";
    }

    return result;
  }

  private string ArrayToString(int[] array)
  {
    string result = "";
    foreach (int i in array)
    {
      result += i.ToString() + ", ";
    }
    return result;
  }

}