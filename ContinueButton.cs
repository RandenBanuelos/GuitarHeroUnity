using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    float lengthOfTime = 3 * 60.0f;


    GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("FinalSceneButton");
        ButtonHidden();
        Invoke("ButtonRevealed", lengthOfTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ButtonHidden()
    {
        button.SetActive(false);
    }

    void ButtonRevealed()
    {
        button.SetActive(true);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("EndCutscene");
    }
}
