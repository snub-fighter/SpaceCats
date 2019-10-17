using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	public override void OnStartServer()
	{
		Debug.Log("Starting Server"  + isLocalPlayer);
	}

	public override void OnStartClient()
	{
		Debug.Log("Starting Client"  + isLocalPlayer);
	}

	void Awake()
	{
		Debug.Log("Awaking Player " + isLocalPlayer);
	}

	// Use this for initialization
	void Start () 
	{
		if(isLocalPlayer)
		{
			GetComponent<PlayerController>().enabled = true;
		}
		else
		{
			GetComponent<PlayerController>().enabled = false;
		}
		Debug.Log("Starting Player " + isLocalPlayer);
	}


}
