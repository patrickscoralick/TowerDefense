using UnityEngine;
using System.Collections;

public class movimentoInimigo : MonoBehaviour 
{
	void Update () 
    {
        this.transform.Translate(-Vector2.right * 20f * Time.deltaTime);
	}
}
