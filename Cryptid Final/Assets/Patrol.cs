using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	public float speed;
	private float waitTime;
	public float startwaitTime;
	public Transform[] moveSpots;
	public Flowchart flowy;
	private int randomSpots;
	// Use this for initialization
	void Start ()
	{
		randomSpots = Random.Range(0, moveSpots.Length);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position =
			Vector3.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

		if (Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
		{
			if (waitTime <= 0)
			{
				randomSpots = Random.Range(0, moveSpots.Length);
				waitTime = startwaitTime;
			}
			else
			{
				waitTime = Time.deltaTime;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			speed = 0;

		}
		
	}
	
}
