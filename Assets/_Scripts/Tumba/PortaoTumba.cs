using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaoTumba : MonoBehaviour 
{
	public bool _abrirPortao = false;
	private AudioSource _audio;
	private Animator _anima;
	private bool _portaoAberto = false;

	void Start() 
	{
		_anima = GetComponent<Animator>();
		_audio = this.GetComponent<AudioSource>();
	}
	
	void Update() 
	{
		if (_abrirPortao && !_portaoAberto)
		{
			_anima.SetTrigger("Abrir");
			_portaoAberto = true;
			Destroy(this.GetComponent<PortaoTumba>(), 4);
		}
	}
	
	public void PlayAudio()
	{
		if (_audio != null)
		{
			_audio.Play();
		}
	}
		
}
