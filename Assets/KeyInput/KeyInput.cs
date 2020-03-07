using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
	private static KeyInput _instance;
	private static KeyInput instance
	{
		get
		{
			if (_instance == null) _instance = new GameObject("KeyInput").AddComponent<KeyInput>();
			return _instance;
		}
	}
	// priv[] previousState, currentState;
	private int activePlayers = 4;

    public static void SetActivePlayerCount(int players)
	{
		instance.activePlayers = players;
	}

    // Update is called once per frame
	void Update()
    {
		Debug.Log("In keyinput");
    }

}
