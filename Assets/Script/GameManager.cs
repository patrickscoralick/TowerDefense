using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static int manas;
    public static int saude;
    public Text manasUsuario;
    public Text saudeUsuario;
    public Text tempoUsuario;
    private float contador;


	void Start () 
    {
        manas = 10;
        saude = 0;
        contador = 180;
	}
	
	void Update () 
    {
       contador -= Time.deltaTime;
       tempoUsuario.text = contador.ToString("0");
       manasUsuario.text = manas.ToString();
       saudeUsuario.text = saude.ToString();
	}
}
