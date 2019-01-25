using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	private Animator _animator;
	private AudioSource[] sounds;

	void Start() {
		sounds = GetComponents<AudioSource> ();
		_animator = GetComponent<Animator> ();
		_animator.SetBool ("open", false);
	}

	void OnTriggerEnter(Collider other) {	
		if (other.CompareTag("Player")) {
			_animator.SetBool ("open", true);
			sounds [0].Play ();
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player"))	 {
			_animator.SetBool ("open", false);
			sounds [1].Play ();
		}
	}
}
