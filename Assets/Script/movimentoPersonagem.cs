using UnityEngine;
using System.Collections;

public class movimentoPersonagem : MonoBehaviour 
{
	void Update () 
    {
        this.transform.Translate(Vector2.right * 25f * Time.deltaTime);
	}
}
