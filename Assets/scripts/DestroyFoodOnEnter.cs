using UnityEngine;
using System.Collections;

public class DestroyFoodOnEnter : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Food")
		{
			Destroy(other.gameObject);
		}
		/*
		else if(other.tag == "Player")
		{
			Destroy(gameObject);
		}*/
	}

}
