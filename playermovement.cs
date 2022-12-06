using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playermovement : MonoBehaviour
{

	private Rigidbody2D rb;
	public float jump;
	public Vector3 initialPosition;

	void Start() 
        {
		rb = GetComponent<Rigidbody2D>();
		initialPosition = transform.position;
	}
	
	void Update() 
        {	


		//jump with space bar
        	if (Input.GetButton("Jump"))
        	{
			rb.AddForce(new Vector2(rb.velocity.x, jump));

		}

		
	}
        void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "spike") SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
