using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIFunctions : MonoBehaviour {


	public GameObject credits;
	public GameObject menuButton;
	// Use this for initialization
	void Start () {
		
		credits.SetActive(false);
		menuButton.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Escape)){

			Application.Quit();
		}

		if(credits.activeInHierarchy == true){

			menuButton.SetActive(true);
		}else{

			menuButton.SetActive(false);
		}
	}

	public void StartGame(){
		if(credits.activeInHierarchy == false){
			
			SceneManager.LoadScene("TestChamber");

		}

	}

	public void Enablecredits(){
		if(credits.activeInHierarchy == false){

			credits.SetActive(true);

		}
	}

	public void DisableCredits(){

		credits.SetActive(false);
	}

}
