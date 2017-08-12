using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Collections;
public class add_point : MonoBehaviour {	
	public Text Scoreteam1;
	public Text Scoreteam2;
	public float score_team1 = 0;
	public float score_team2 = 0;
	public float waittime = 2;
	public float step = 0.1f;
	public void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "goalcube1") {
			transform.position = GameObject.Find ("ballposition").transform.position;
			score_team1 += 1;
			this.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;

		}

	


		if (other.gameObject.tag == "goalcube2"){
			transform.position = GameObject.Find("ballposition").transform.position;
			score_team2 += 1;
			this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

		}
	}
	public void Start(){
		Scoreteam1 = GameObject.Find ("scoreteam1").GetComponent<Text> ();
		Scoreteam2 = GameObject.Find ("scoreteam2").GetComponent<Text> ();
				
	}
			
	

	public void Update()
	{
		{
			Scoreteam1.text = score_team1.ToString (); 
			Scoreteam2.text = score_team2.ToString ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			score_team1 = 0;
			score_team2 = 0;
		
		}
	}
}



