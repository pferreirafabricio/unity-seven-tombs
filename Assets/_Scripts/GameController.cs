using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public Image[] _imagensReliquias = new Image[7];
	public static int _indiceReliquia = -1;
	
	public int _totalItensColetados = 0;

	void Start() 
	{
		OcultarItens();
		//_totalItensColetados = 7;
	}

	void FixedUpdate() 
	{
		if (_indiceReliquia > -1)
		{
			_totalItensColetados++;
			_imagensReliquias[_indiceReliquia].enabled = true;
			_indiceReliquia = -1;
		}
	}
	
	void OcultarItens()
	{
		for(int i = 0; i < _imagensReliquias.Length; i++)
		{
			_imagensReliquias[i].enabled = false;
		}
	}
}
