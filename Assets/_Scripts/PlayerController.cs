using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public AudioClip[] _somPassos =  new AudioClip[2];
	public FinalizarJogo _finalizarJogo;
	
	private Animator _anima;
	private float _velocidade;
	private AudioSource _audio;
	private int _tipoChao = 0;
	
	void Start() 
	{
		_anima = this.GetComponent<Animator>();
		_audio = this.GetComponent<AudioSource>();
	}
	
	void FixedUpdate()
	{
		if (_velocidade > 0 && !_audio.isPlaying)
		{
			_audio.clip = _somPassos[_tipoChao];
			_audio.Play();
		}
	}
	
	void Update()
	{
		if (!_finalizarJogo._terminouJogo)
		{
			_velocidade = Input.GetAxis("Vertical");
		
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.JoystickButton2))
			{
				_velocidade *= 2f;
			}
			
			
			this.transform.Rotate(new Vector3(0, ((90 * Input.GetAxis("Horizontal")) * Time.deltaTime), 0));
			
			_anima.SetFloat("Velocidade", _velocidade);
		}
		
	}
	
	void OnCollisionStay(Collision _col)
	{	
		if (_col.gameObject.CompareTag("Chao"))
		{
			_tipoChao = 1;
		}
		else
		{
			_tipoChao = 0;
		}
	}
}
