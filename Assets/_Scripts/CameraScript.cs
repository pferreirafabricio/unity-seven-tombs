using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour 
{
	private const float Y_ANGLE_MIN = -50.00f;
	private const float Y_ANGLE_MAX = 50.00f;
	
	public Transform lookAt;
	public Transform camTransform;
	public float JoySensivity = 3;
	
	private Camera cam;
	
	private float distance = 1.5f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensivityX = 1.0f;
	private float sensivityY = 1.0f;
	

	private void Start() 
	{
		camTransform = transform;
		cam = Camera.main;
	}
	
	private void Update() 
	{
		//AXIS X
		if (Input.GetAxis("Mouse X") != 0)
		{
			currentX += Input.GetAxis("Mouse X");
		}
		else
		{
			currentX += (Input.GetAxis("JoyX") * JoySensivity);
		}
		
		//AXIS Y
		if (Input.GetAxis("Mouse Y") != 0)
		{
			currentY += Input.GetAxis("Mouse Y");
		}
		else
		{
			currentY += (Input.GetAxis("JoyY") * JoySensivity);
		}
		
		currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}
	
	private void LateUpdate()
	{
		Vector3 dir = new Vector3(0, 0, -distance);
		Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		
		camTransform.LookAt(lookAt.position);
	}
}
