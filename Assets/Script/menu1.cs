using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menu1 : MonoBehaviour 
{
    public GameObject local;
    public GameObject[] personagens;
    private int manas;

	
    void Start () 
    {
        manas = 10;
	}
	

    /// <summary>
    /// Método para instanciar personagens pelos botões
    /// </summary>
    /// <param name="personagem">Recebe um número para utilizar  como posição dos personagens</param>
    public void instanciarPersonagens(int personagem)
    {
        if (GameManager.manas >= 5)
        {
            Instantiate(personagens[personagem], new Vector2(local.transform.position.x, local.transform.position.y), Quaternion.identity);
            GameManager.manas -= 5;
        }
        else
        {
            Debug.Log("eta");
        }
    }
}
