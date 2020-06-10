using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour 
{
	public Vector3 _rotacao = new Vector3(0, 180f, 0);

	// Update is called once per frame
	void FixedUpdate()	
	{
		this.transform.Rotate(_rotacao * Time.deltaTime);
	}
}
