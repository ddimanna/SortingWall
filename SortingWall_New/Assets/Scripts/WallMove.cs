using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WallMove : MonoBehaviour 
{

	public int Speed;

	public GameObject player;
	public GameObject spawnManager;

	public ColorAndShapeShift propertyChecker;
	public SpawnManager collisionCounter;
	//public int totalNumberOfCollisions;

	//public int numberOfCollisions;

	private Rigidbody rb;


	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
		rb.velocity = new Vector3 (0, 0, -Speed * Time.deltaTime);
		propertyChecker = player.GetComponent<ColorAndShapeShift>();

		player = GameObject.Find("CharacterPrefab");
		propertyChecker = player.GetComponent<ColorAndShapeShift>();

		spawnManager = GameObject.Find("SpawnManager");
		collisionCounter = spawnManager.GetComponent<SpawnManager>();

		//numberOfCollisions = 0;
		//propertyChecker = GameObject.Find("CharacterPrefab");
	}

	void Update(){
//		if(numberOfCollisions > 10){
//
//			//timeManipulator.waitTime -= 0.5f; //decreases time between waves in spawn manager script
//		}


	}

	void OnTriggerEnter(Collider col){

		if(col.gameObject.name == "CharacterPrefab"){



			if(this.gameObject.tag == "BasicWall"){
				
				SceneManager.LoadScene("TestChamber");
			}





			if(this.gameObject.tag == "BlueCircle"){

				if((propertyChecker.activeShape.name != "Sphere") || (propertyChecker.activeMaterial.name != "BLUE")){

					SceneManager.LoadScene("TestChamber");
				}
				else{

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "BlueSquare"){

				if((propertyChecker.activeShape.name != "Cube") || (propertyChecker.activeMaterial.name != "BLUE")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "BlueTriangle"){

				if((propertyChecker.activeShape.name != "Pyramid") || (propertyChecker.activeMaterial.name != "BLUE")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}






			if(this.gameObject.tag == "RedCircle"){

				if((propertyChecker.activeShape.name != "Sphere") || (propertyChecker.activeMaterial.name != "RED")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "RedSquare"){

				if((propertyChecker.activeShape.name != "Cube") || (propertyChecker.activeMaterial.name != "RED")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "RedTriangle"){

				if((propertyChecker.activeShape.name != "Pyramid") || (propertyChecker.activeMaterial.name != "RED")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}







			if(this.gameObject.tag == "GreenCircle"){

				if((propertyChecker.activeShape.name != "Sphere") || (propertyChecker.activeMaterial.name != "GREEN")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "GreenSquare"){

				if((propertyChecker.activeShape.name != "Cube") || (propertyChecker.activeMaterial.name != "GREEN")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "GreenTriangle"){

				if((propertyChecker.activeShape.name != "Pyramid") || (propertyChecker.activeMaterial.name != "GREEN")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}




			if(this.gameObject.tag == "YellowCircle"){

				if((propertyChecker.activeShape.name != "Sphere") || (propertyChecker.activeMaterial.name != "YELLOW")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "YellowSquare"){

				if((propertyChecker.activeShape.name != "Cube") || (propertyChecker.activeMaterial.name != "YELLOW")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}

			if(this.gameObject.tag == "YellowTriangle"){

				if((propertyChecker.activeShape.name != "Pyramid") || (propertyChecker.activeMaterial.name != "YELLOW")){

					SceneManager.LoadScene("TestChamber");
				}
				else {

					collisionCounter.collisionIncrement++;
					collisionCounter.totalCollisions++;
				}
			}


		}

	}



}