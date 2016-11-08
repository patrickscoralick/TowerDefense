using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static int manas;
    public static int vida;
    //public Text manasUsuario;
    //public Text saudeUsuario;
   // public Text tempoUsuario;


	void Start () 
    {
        manas = 10;
        vida = 10;
	}
	
	void Update () 
    {
       // manasUsuario.text = manas.ToString();
	}
}
