using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	private Animator _animator;

	void Start() {
		_animator = GetComponent<Animator> ();
		_animator.SetBool ("open", false);
	}

	void OnTriggerEnter(Collider other) {	
		if (other.CompareTag("Player")) {
			_animator.SetBool ("open", true);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player"))	 {
			_animator.SetBool ("open", false);
		}
	}
}
