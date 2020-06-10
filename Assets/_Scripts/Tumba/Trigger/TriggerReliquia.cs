using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReliquia : MonoBehaviour 
{	
	public GameObject _reliquia;
	public int _indiceReliquia;
	public string _playerTag = "Player";
	
	private bool _playerColidindo = false, _pressionou = false;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton0))
		{
			if (!_pressionou && _playerColidindo)
			{
				_pressionou = true;
				this.GetComponent<AudioSource>().Play();
				GameController._indiceReliquia = _indiceReliquia;
				Destroy(_reliquia.gameObject, 1);
			}
		}
		
	}
	
	void OnTriggerEnter(Collider _col)
	{
		if (_col.CompareTag(_playerTag))
		{
			_playerColidindo = true;
		}
	}
	
	void OnTriggerExit(Collider _col)
	{
		if (_col.CompareTag(_playerTag))
		{
			_playerColidindo = false;
		}
	}
}
