using UnityEngine;
using System.Collections;

public class movimentoPersonagem : MonoBehaviour 
{
	void Update () 
    {
        this.transform.Translate(Vector2.right * 25f * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cenoura" || other.gameObject.tag == "Brocolis" || other.gameObject.tag == "Tomate" || other.gameObject.tag == "Pimentao" || other.gameObject.tag == "Berinjela" || other.gameObject.tag == "Abobora")
        {
            GameManager.saude += 2;
            GameManager.manas += 5;
            //Destroy(other.gameObject);
        }
    }


    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
