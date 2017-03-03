using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject [] SpawnPoint; //chooses which spawn point is chosen to instantiate the shape wall



	public bool CanSpawn;

	public float waitTime;


	public int shapeSpawnIndex;

	public SpawnPoint MidSpawnPoint;
	public SpawnPoint LeftSpawnPoint;
	public SpawnPoint RightSpawnPoint;

	public Text score;


	public int collisionIncrement;
	public int totalCollisions;


	void Start(){

		//waitTime = 3f;

		CanSpawn = true;
		collisionIncrement = 0;
		totalCollisions = 0;

	}

	public void Update ()
	{
		if(collisionIncrement >= 10){

			waitTime -= 0.5f;
			collisionIncrement = 0;
		}


		if (CanSpawn == true)
			Spawn ();

		score.text = totalCollisions.ToString();

		if(Input.GetKeyDown(KeyCode.Escape)){

			SceneManager.LoadScene("Menu");
		}
			
	}


	public void Spawn(){


		CanSpawn = false;

		shapeSpawnIndex = (Random.Range (0, 3));	//which spawner spawn the shape wall

		SpawnPoint [shapeSpawnIndex].GetComponent<SpawnPoint>().canSpawnShapes = true;

		MidSpawnPoint.Spawner ();
		LeftSpawnPoint.Spawner ();
		RightSpawnPoint.Spawner ();

		SpawnPoint [shapeSpawnIndex].GetComponent<SpawnPoint>().canSpawnShapes = false;

		StartCoroutine(WaveWait());

		return;

	}

	public IEnumerator WaveWait (){

		yield return new WaitForSeconds(waitTime);

		CanSpawn = true;


	}

}
