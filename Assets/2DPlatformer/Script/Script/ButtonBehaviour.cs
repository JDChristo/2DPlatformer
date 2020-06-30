using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{

    /*    // old Scripts
    public Button redButton, yellowButton, greenButton;

    private void Start()
    {
        redButton.onClick.AddListener(OnRedButtonClick);
        yellowButton.onClick.AddListener(OnYellowButtonClick);
        greenButton.onClick.AddListener(OnGreenButtonClick);
    }

    private void OnRedButtonClick()
    {
        SceneManager.LoadScene(1);
    }
    private void OnYellowButtonClick()
    {
        SceneManager.LoadScene(2);
    }
    private void OnGreenButtonClick()
    {
        SceneManager.LoadScene(3);
    }
    */
    public void OnButtonClick(int index)
    {
        SceneManager.LoadScene(index);
    }

}
    
