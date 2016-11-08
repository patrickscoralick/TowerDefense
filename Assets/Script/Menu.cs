using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    /// <summary>
    /// Método para trocar de cenas
    /// </summary>
    /// <param name="numero">Recebe numero da posição da cena</param>
    public void trocarCena(int numero)
    {
        Application.LoadLevel(numero);
    }
}
