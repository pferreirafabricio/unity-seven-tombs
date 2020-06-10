using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarJogo : MonoBehaviour 
{
	public bool _terminouJogo = false;
	
	//0 - Main Camera ~~~~ 1 - CameraCreditos
	public GameObject[] _cameras = new GameObject[2];
	public GameController _gameController;
	
	//0 - Reliquias ~~~~ 1 - Creditos
	public GameObject[] _canvas = new GameObject[2];
	public bool _chamarMenu = false;
	public GameObject _staticAndreca;
	
	private bool _playerColidindo = false;
	private string _playerTag = "Player";
	private AsyncOperation asyncLoad;

	void Update () 
	{
		if (!_terminouJogo)
		{
			if (_playerColidindo && _gameController._totalItensColetados == 7)
			{
				_cameras[0].SetActive(false);
				_cameras[1].SetActive(true);
				
				_canvas[0].SetActive(false);
				_canvas[1].SetActive(true);
				
				GameObject.FindGameObjectWithTag(_playerTag).SetActive(false);
				_staticAndreca.SetActive(true);
				
				_terminouJogo = true;
				
				StartCoroutine(CarregarMenuPrincipal());
			}
		}
		
	}
	
	IEnumerator CarregarMenuPrincipal()
	{
		asyncLoad = SceneManager.LoadSceneAsync("Menu");
		asyncLoad.allowSceneActivation = false;
		
		while(!asyncLoad.isDone)
		{
			if (asyncLoad.progress >= 0.9f && _chamarMenu)
			{
				asyncLoad.allowSceneActivation = true;
			}
			yield return null;
		}
	}
	
	// void OnCollisionEnter(Collision _col)
	// {	
		// if (_col.gameObject.CompareTag(_playerTag))
		// {
			// _playerColidindo = true;
			// Debug.Log("Colidi");
		// }
		
	// }
	
	void OnTriggerEnter(Collider _col)
	{	
		if (_col.gameObject.CompareTag(_playerTag))
		{
			_playerColidindo = true;
			//Debug.Log("Colidi");
		}
		
	}
	
	void OnTriggerExit(Collider _col)
	{	
		if (_col.gameObject.CompareTag(_playerTag))
		{
			_playerColidindo = false;

		}
		
	}

}
