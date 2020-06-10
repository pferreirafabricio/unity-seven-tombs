using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomAmbiente : MonoBehaviour 
{
	public bool _entrarTumba;
	public AudioSource _audio;
	private string 	_playerTag = "Player";
	//private bool _playerColidindo;
	
	
	void OnTriggerEnter(Collider _col)
	{
		if (_col.CompareTag(_playerTag) && _entrarTumba)
		{
			if (_audio.isPlaying == false)
			{
				_audio.enabled = true;
				_audio.Play();
				//_playerColidindo = true;
			}
			
		}
	}
	
	void OnTriggerExit(Collider _col)
	{
		if (_col.CompareTag(_playerTag) && !_entrarTumba)
		{
			_audio.enabled = false;
			_audio.Stop();
			//_playerColidindo = false;
		}
	}
}
