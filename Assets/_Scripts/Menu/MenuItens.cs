using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItens : MonoBehaviour 
{
	public GameObject _reliquias;
	public float _tempoExibição = 5f;
	
	private Animator _anima;
	private bool _estadoMenu = false, _abriuMenu = false;
	private float _tempo = 0f;

	void Start () 
	{
		_anima = _reliquias.GetComponent<Animator>();
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.JoystickButton1))
		{
			_estadoMenu = true;
		}
		
		if (_estadoMenu)
			{
				if (!_abriuMenu)
				{
					_anima.SetTrigger("Abrir");
					_abriuMenu = true;
				}
				
				_tempo += (1 * Time.deltaTime);
				
				if (_tempo >= _tempoExibição)
				{
					_estadoMenu = false;
					_abriuMenu = false;
					_anima.SetTrigger("Fechar");
					_tempo = 0f;
				}
			}
	}
}
