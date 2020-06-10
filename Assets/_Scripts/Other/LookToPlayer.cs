using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToPlayer : MonoBehaviour 
{
	private GameObject _player;
	private float _distance = 0;
	
	public string playerTag = "Player";
	public float _maxDistance = 4f;

	void Start () 
	{
		_player = GameObject.FindGameObjectWithTag(playerTag);
		this.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	void Update () 
	{
		_distance = Vector3.Distance(this.transform.position, _player.transform.position);
	}
	
	void FixedUpdate()
	{
		if (_distance <= _maxDistance)
		{
			this.GetComponent<SpriteRenderer>().enabled = true;
			this.transform.LookAt(_player.transform.position);
		}
		else
		{
			this.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
	
}
