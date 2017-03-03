using UnityEngine;
using System.Collections;

public class SidewaysMovement : MonoBehaviour {


	private Vector3 moveDirection = Vector3.zero;
	//public float gravity = 20f;
	//private CharacterController controller;
	//private Animator anim;

	private bool isChangingLane = false;
	private bool canMoveRight;
	private bool canMoveLeft;
	private Vector3 locationAfterChangingLane;
	private Vector3 sidewaysMovementDistance = Vector3.right * 2.5f;

	public bool canMove;
	public float waitTime;

	public float sidewaysSpeed = 5.0f;

	public Transform characterPrefab;



	// Use this for initialization
	void Start () {
		canMove = true;
//		moveDirection = transform.forward;
		moveDirection = transform.TransformDirection(moveDirection);
		canMoveLeft = true;
		canMoveRight = true;
		//moveDirection *= speed;
		//anim = characterPrefab.GetComponent<Animator>
	
	}

	private void DetectInput(){

		//float inputDirection = Input.GetAxis("Horizontal");


		if((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D))){
			isChangingLane = true;


			//Debug.Log("Input detected");

			if(canMove){

				if(Input.GetKeyDown(KeyCode.A)){
					if(canMoveLeft){
						Debug.Log("Left Input");
						locationAfterChangingLane = transform.position - sidewaysMovementDistance;
						moveDirection.x = -sidewaysSpeed;

						StartCoroutine(MoveWait());
					}

				}
				else if(Input.GetKeyDown(KeyCode.D)){

					if(canMoveRight){
						Debug.Log("Right Input");
						locationAfterChangingLane = transform.position + sidewaysMovementDistance;
						moveDirection.x = sidewaysSpeed;

						StartCoroutine(MoveWait());

					}	

				}


			}


		}
	}
	
	// Update is called once per frame
	void Update () {

		DetectInput();

		if(isChangingLane){

			if(Mathf.Abs(transform.position.x - locationAfterChangingLane.x) < 0.1f){

				isChangingLane = false;
				moveDirection.x = 0;

			}
		}

		transform.Translate(moveDirection * Time.deltaTime);
	
	}

	void OnTriggerStay(Collider col){

		if(col.gameObject.tag == "RightLane"){

			Debug.Log("Border collision detected");

			canMoveRight = false;
//			isChangingLane = false;
//			moveDirection.x = 0;
		}

		if(col.gameObject.tag == "LeftLane"){

			Debug.Log("Border collision detected");

			canMoveLeft = false;
			//			isChangingLane = false;
			//			moveDirection.x = 0;
		}
		if(col.gameObject.tag == "CenterLane"){

			Debug.Log("Border collision detected");

			canMoveLeft = true;
			canMoveRight = true;
			//			isChangingLane = false;
			//			moveDirection.x = 0;
		}
	}

	public IEnumerator MoveWait(){

		canMove = false;

		yield return new WaitForSeconds(waitTime);

		canMove = true;
	}
}
