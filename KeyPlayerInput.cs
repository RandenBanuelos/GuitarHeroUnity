using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[System.Serializable]
public class KeyPlayerInput
{
	// public int deviceId;
	// public Device device;
	public bool[] fred = new bool[5];
	public bool strumPressed;
	public bool startPressed;
	public bool starPressed;
	public float tilt, whammy;

	private KeyCode[] keyCodes = {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5,
		KeyCode.A,
		KeyCode.D
    };
	// public Input input;

	public enum Device
	{
		Keyboard
	}
	// public void KeyPlayerInput(bool dummy)
	// {
	// 	Debug.Log("New player input??");
	// 	// device = _device;
	// 	// deviceId = _deviceId;
	// 	fred = new bool[5];
	// }

	public void Update()
	{
		// if (Input.GetKeyDown(keyCodes[0])){
		// 	fred[0] = true;
		// 	Debug.Log(fred[0].ToString());
		// 	Debug.Log("1 has been pressed");
		// } else {
		// 	fred[0] = false;
		// }

		fred[0] = Input.GetKey(keyCodes[0]);
		if (fred[0]){
			Debug.Log("1 has been pressed");
		}
		fred[1] = Input.GetKey(keyCodes[1]);
		if (fred[1]){
			Debug.Log("2 has been pressed");
		}
		fred[2] = Input.GetKey(keyCodes[2]);
		if (fred[2]){
			Debug.Log("3 has been pressed");
		}
		fred[3] = Input.GetKey(keyCodes[3]);
		fred[4] = Input.GetKey(keyCodes[4]);
		startPressed = Input.GetKeyDown(KeyCode.A);
		starPressed = Input.GetKeyDown(KeyCode.D);
		strumPressed = Input.GetKeyDown(KeyCode.Space);
        // tilt = 1.24F; //Input.GetKeyDown("W");
        // whammy = 4.34F; //Input.GetKeyDown("S");

        if (Input.GetKeyDown(KeyCode.A))
        {
            NextScene();
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("EndCutscene");
    }
}

