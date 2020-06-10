using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTampaSarcofago : MonoBehaviour
{
	private bool _playerColidindo = false, _pressionou = false;
	
	public GameObject _tampaSarcofago;
	public string _playerTag = "Player";
	
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton0))
		{
			if (!_pressionou && _playerColidindo)
			{
				_pressionou = true;
				_tampaSarcofago.GetComponent<TampaSarcofago>()._abrirTampa = true;
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
