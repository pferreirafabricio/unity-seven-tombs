using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour 
{
	private bool _estadoPause = false;
	public GameObject _canvasPause;
	public FinalizarJogo _finalizarJogo;
	

	// Update is called once per frame
	void Update () 
	{
		if (_finalizarJogo._terminouJogo == false)
		{
			if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.JoystickButton8))
			{
				_estadoPause = !_estadoPause;
				_canvasPause.SetActive(_estadoPause);
				
				if (_estadoPause)
				{
					Time.timeScale = 0f;
				}
				else
				{
					Time.timeScale = 1f;
				}
			}
		}
		
		
	}
	
	public void Retomar()
	{
		_estadoPause = false; 
		_canvasPause.SetActive(_estadoPause);
		Time.timeScale = 1f;
	}
	
	public void Sair()
	{
		Application.Quit();
	}	
}
