using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Level1button;
    void Start()
    {
      var root=GetComponent<UIDocument>().rootVisualElement;
      Level1button=root.Q<Button>("level1");
      Level1button.clicked+=ButtonClicked;     
    }

    
    public void ButtonClicked() {
        // Load the scene called "sceneName"
        SceneManager.LoadScene("SampleScene");
    }
}
