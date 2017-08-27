using UnityEngine;
using System.Collections;

public class SpaceShipEngine : MonoBehaviour {
	public float enginePitch;
	private float smooth = 0.02f;
	public float maxPitch;
	public float minPitch;
	public bool EngineStarted;
	private AudioSource engineAS;
	// Use this for initialization
	void Start () {
		engineAS = this.GetComponent<AudioSource>();
		enginePitch = 1;
	}	
	// Update is called once per frame
	void Update () {
		if(EngineStarted){
		if(Input.GetAxis("Throttle")>0){
			enginePitch = Mathf.Lerp(enginePitch, maxPitch, smooth);
		}
		if(Input.GetAxis("Throttle")<0){
			enginePitch = Mathf.Lerp(enginePitch, minPitch, smooth);
		}
		engineAS.pitch = enginePitch;
		}
		else{
			engineAS.pitch = 0;
		}
	}
}
