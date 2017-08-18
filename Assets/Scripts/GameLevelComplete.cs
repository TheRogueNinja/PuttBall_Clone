using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelComplete : MonoBehaviour {
	public PlayerMov mov;
    void OnTriggerEnter(Collider col){
		//if(col.collider.tag == "Finish"){
			//Debug.Log("On to Level 2");
            if(col.tag == "Player"){
				mov.enabled = false;
				Invoke("SceneChange",1f);
			}
			
		}
	void SceneChange(){
		if(SceneManager.GetActiveScene().buildIndex <= 2){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
		else{
			SceneManager.LoadScene("WelcomeScene");
		}
		Debug.Log(SceneManager.GetActiveScene());
	}
}
