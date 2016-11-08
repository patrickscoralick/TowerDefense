using UnityEngine;
using System.Collections;

public class pontos : MonoBehaviour 
{

    public  int pontosInimigo;
	void Start () 
    {
        pontosInimigo = 10;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(pontosInimigo <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
