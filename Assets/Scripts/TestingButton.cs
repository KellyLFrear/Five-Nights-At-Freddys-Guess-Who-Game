using UnityEngine;
using UnityEngine.SceneManagement;

public class TestingButton : MonoBehaviour
{
    // FUNCTION TO LOAD SCENE BY NAME
    public void LadScenebyName(string name)
    {
        SceneManager.LoadScene(name);
    }

    // FUNCTION TO TEST BUTTONS
    public void TestButton(string buttonName)
    {
        Debug.Log("Button Pressed: " + buttonName);
    }
}
