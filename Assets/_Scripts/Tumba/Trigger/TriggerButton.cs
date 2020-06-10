using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
	public string _playerTag = "Player";
	
	private bool _playerColidindo = false, _pressionou = false;
	public GameObject _botao;
	
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton0))
		{
			if (!_pressionou && _playerColidindo)
			{
				_pressionou = true;
				_botao.GetComponent<Botao>()._abrirPortao = true;	
				Destroy(this.gameObject);
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
