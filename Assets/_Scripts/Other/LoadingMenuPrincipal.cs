using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingMenuPrincipal : MonoBehaviour 
{
	public FinalizarJogo _finalizarJogo;
	
	public void ChamarMenu()
	{
		_finalizarJogo._chamarMenu = true;	
	}
	
}
