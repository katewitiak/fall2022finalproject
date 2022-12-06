using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.Translate (Vector2.left * 7*Time.deltaTime);
	if (transform.position.y<-5) Destroy (gameObject);
    }
}
