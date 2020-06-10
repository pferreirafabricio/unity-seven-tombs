using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TampaSarcofago : MonoBehaviour 
{
	public bool _abrirTampa = false;
	public GameObject _reliquia;
	
	private Animator _anima;
	private Rigidbody _rigid;
	private bool _tampaFoiAberta = false;
	
	public GameObject _help;
	
	private AudioSource _audio;

	void Start() 
	{
		_anima = GetComponent<Animator>();
		_rigid = GetComponent<Rigidbody>();
		_audio = GetComponent<AudioSource>();
	}
	
	void Update() 
	{
		if (_abrirTampa && !_tampaFoiAberta)
		{
			_anima.SetTrigger("Abrir");
			_abrirTampa = false;
			
			if (_audio != null)
			{
				_audio.Play();
			}
			
			_reliquia.SetActive(true);
			Destroy(_help.gameObject);
			Destroy(this.gameObject.GetComponent<TampaSarcofago>(), 3);
		}
	}
	
	public void AtivarRigid()
	{
		Destroy(this.GetComponent<Animator>());
		_rigid.useGravity = true;
	}
}