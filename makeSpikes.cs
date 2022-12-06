using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeSpikes : MonoBehaviour
{
    public GameObject spike;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	manageTimer();
    }

    void manageTimer()
    {
	timer+=Time.deltaTime;
	if (timer>=0.9)
	{
		addSpike();
		timer = 0;
	}
    }

    void addSpike()
    {
	Vector3 playerPos = GameObject.Find("player").GetComponent<playermovement>().initialPosition;
	GameObject t1;
	t1 = (GameObject) (GameObject.Instantiate(spike, playerPos + Vector3.right*20, Quaternion.identity));
    }

}
