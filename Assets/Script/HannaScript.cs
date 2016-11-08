using UnityEngine;
using System.Collections;

public class HannaScript : MonoBehaviour 
{

	void Start () 
    {
	
	}
	
	void Update () 
    {
	
	}

    /// <summary>
    /// Método de colisão com objetos
    /// VIA TRIGGER!!!!!!!!!
    /// </summary>
    /// <param name="Coll"></param>
    void OnTriggerStay2D(Collider2D Coll)
    {
        if (Coll.gameObject.tag == "InimigoAbobora")
        {
                
        }

        if (Coll.gameObject.tag == "Teste")
        {

        }

        if (Coll.gameObject.tag == "Outro")
        {

        }

        if (Coll.gameObject.tag == "Outro")
        {

        }

        if (Coll.gameObject.tag == "Teste")
        {

        }
    }
}
