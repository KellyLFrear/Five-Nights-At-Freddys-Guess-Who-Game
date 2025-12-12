using UnityEngine;

public class XButton : MonoBehaviour
{
    [SerializeField] private GameObject X; // So We Can Change The X Based Off Of The Image

    void Start()
    {
        if (X != null)
            X.SetActive(false); // Sets The X To False When Beginning Game
    }

    public void ClickImage() // If The Image Is Clicked
    {

        if (X == null) return; // if X Is Not Assigned, Do Nothing
        X.SetActive(!X.activeSelf); // Toggles The X On And Off

    }
}
