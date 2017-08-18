using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMov : MonoBehaviour {
	public int speed = 0;
	Rigidbody rb;
	void Start(){
		rb = gameObject.GetComponent<Rigidbody>() as Rigidbody;
	}
	void Update () {
		Debug.Log(gameObject.tag);
		if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)){
			//gameObject.transform.Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
			//rb.MovePosition(-Vector3.forward*speed*Time.deltaTime);
			rb.AddForce(-25,0,0*speed*Time.deltaTime);
			Debug.Log("a");
		}
		if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)){
			//gameObject.transform.Translate(new Vector3(0,0,1)*speed*Time.deltaTime);
			//rb.MovePosition(Vector3.up*speed*Time.deltaTime);
			rb.AddForce(0,0,25*speed*Time.deltaTime);
			Debug.Log("w");
		}
		if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)){
			//gameObject.transform.Translate(new Vector3(0,0,-1)*speed*Time.deltaTime);
			//rb.MovePosition(-Vector3.up*speed*Time.deltaTime);
			rb.AddForce(0,0,-25*speed*Time.deltaTime);
			Debug.Log("s");
		}
		if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
			//gameObject.transform.Translate(new Vector3(1,0,0)*speed*Time.deltaTime);
			//rb.MovePosition(-Vector3.forward*speed*Time.deltaTime);
			rb.AddForce(25,0,0*speed*Time.deltaTime);
			Debug.Log("d");
		}
		if(gameObject.transform.position.y <= -2){
			SceneManager.LoadScene(0);
		}
		if(Input.GetKey(KeyCode.Escape)){
			Debug.Log("Stop");
		}
	}
}
