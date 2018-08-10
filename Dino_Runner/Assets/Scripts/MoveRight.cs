using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class MoveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	private bool isActive = false;
	public float movementCap = 10.0f;
	private float moveCounter = 0.0f;
	public GameObject Left;
	private Vector3 pos;
	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		pos = player.transform.position;
		if(isActive) {
			if(moveCounter < movementCap) {
				pos.x -= Time.deltaTime * 5;
				Left.GetComponent<MoveLeft>().AddToCap(Time.deltaTime);
				moveCounter += Time.deltaTime;
			}
			player.transform.position = pos;
		}
		if(moveCounter <= 0) {
			moveCounter = 0;
		}
	}

	public virtual void OnPointerDown(PointerEventData ped) {
		SetisActive(true);
	}

	public virtual void OnPointerUp(PointerEventData ped) {
		SetisActive(false);
		
	}

	public void SetisActive(bool activate) {
		isActive = activate;		
	}

	public void AddToCap(float addCap) {
		movementCap += addCap;
	}

	public float GetCap() {
		return movementCap;
	}
}
