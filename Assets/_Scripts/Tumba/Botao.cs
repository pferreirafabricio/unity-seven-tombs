using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour 
{

	public bool _abrirPortao = false;
	public GameObject _portao;
	public GameObject _help;
	
	private AudioSource _audio;
	private Animator _anima;
	private bool _portaAberta = false;

	void Start() 
	{
		_anima = GetComponent<Animator>();
		_audio = this.GetComponent<AudioSource>();
	}
	
	void Update() 
	{
		if (_abrirPortao && !_portaAberta)
		{
			_anima.SetTrigger("Abrir");
			_portaAberta = true;
			
			if (_audio != null)
			{
				_audio.Play();
			}
			
			Destroy(_help.gameObject);
			Destroy(this.gameObject.GetComponent<Botao>(), 3);
		}
	}
	
	public void AbrirPortao()
	{
		_portao.GetComponent<PortaoTumba>()._abrirPortao = true;
		this.GetComponent<Animator>().enabled = false;
	}

}
