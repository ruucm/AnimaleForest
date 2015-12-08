﻿using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {
	public Transform camPos;
	public Transform FarCamPos;
	public Transform NearCamPos;

	int posNum ;


	// Use this for initialization
	void Start () {
	
		posNum = 0;
		camPos = FarCamPos;

	} 
	
	// Update is called once per frame
	void Update () {
//		transform.position = camPos.position;
		transform.position = Vector3.Lerp (transform.position, camPos.position, 0.5f * Time.deltaTime);
		transform.forward = Vector3.Lerp (transform.forward, camPos.forward, 0.5f * Time.deltaTime);



		if (Input.GetMouseButtonDown (1)) {

			Debug.Log("GetMouseButtonDown (1)");
		
			if(posNum ==0){
				camPos = NearCamPos;
				posNum = 1; 
			}
			else
			{
				camPos = FarCamPos;
				posNum = 0; 
			}


		

//			this.GetComponent<FollowCam>().camPos = (Transform)GameObject.FindWithTag("CamPosNear").transform;  

//			GameObject.FindWithTag ("Player").transform;
			
		}



	}
}
