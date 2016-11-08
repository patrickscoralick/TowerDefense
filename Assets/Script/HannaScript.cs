using UnityEngine;
using System.Collections;

public class HannaScript : MonoBehaviour 
{
    private float tempoCombate;

	void Start () 
    {
        tempoCombate = 0f;
	}
	
	void Update () 
    {
        tempoCombate += Time.deltaTime;
	}

    /// <summary>
    /// Método de colisão com objetos
    /// </summary>
    /// <param name="Coll"></param>
    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag != "Abobora" || Coll.gameObject.tag != "Tomate")
        {
            int pontosDoInimigo = Coll.gameObject.GetComponent<pontos>().pontosInimigo;
                if(tempoCombate >= 1)
                {
                    while (pontosDoInimigo > 0)
                    {
                        pontosDoInimigo -= 1;
                    }
                    
                }
                tempoCombate = 0;
        }

        if (Coll.gameObject.tag == "Abobora" || Coll.gameObject.tag == "Tomate")
        {

        }
    }
}
