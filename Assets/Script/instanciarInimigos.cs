using UnityEngine;
using System.Collections;

public class instanciarInimigos : MonoBehaviour 
{
    public GameObject[] locais;
    public GameObject[] inimigos;
    private float tempo;

	void Update () 
    {
        tempo += Time.deltaTime;

        if (tempo > 1)
        {
            int local = Random.RandomRange(0, locais.Length);
            
            int inimigo = Random.RandomRange(0, inimigos.Length);

            Instantiate(inimigos[inimigo],new Vector2 (locais[local].transform.position.x,locais[local].transform.position.y),Quaternion.identity);
            tempo = 0;
        }
	}
}
