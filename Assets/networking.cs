using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networking : MonoBehaviour {
	GameObject spawn;
	GameObject player = GameObject.Find("BlueSuitFree01");
	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings ("test");
		spawn = GameObject.Find ("spawnpoint");


	}
	
	// Update is called once per frame
	void OnJoinedLobby () {
		Debug.Log ("OnJoinedLobby");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed(){
		Debug.Log ("OnPhotonRandomJoinFailed");
		RoomOptions roomoptions = new RoomOptions (){ isVisible = true,maxPlayers = 22};
		int randomnumber = 1;
		PhotonNetwork.CreateRoom (randomnumber.ToString(),roomoptions,TypedLobby.Default);
	}
	void OnJoinedRoom(){
		Debug.Log ("JoinedRoom");

	}
}
