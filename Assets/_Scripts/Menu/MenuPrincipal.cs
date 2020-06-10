using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour 
{
	public Button _btnIniciarJogo;
	public Text _text;
	
	public void CarregarJogo()
	{
		_btnIniciarJogo.enabled = false;
		_text.text = "Iniciando...";
		
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
	public void SairJogo()
	{
		Application.Quit();
	}
}
