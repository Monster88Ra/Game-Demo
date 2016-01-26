using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
    private Button[] buttons;


    void Awake()
    {
        // Get the buttons
        buttons = this.GetComponentsInChildren<Button>();
        //Debug.Log(buttons.Length.ToString() + "before");

      
        // Disable them
        HideButtons();
        //Debug.Log(buttons.Length.ToString() + "after");
    }

    public void HideButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void ShowButtons()
    {
        Debug.Log("here we go to show buttons");
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ExitToMenu()
    {
        // Reload the level
        Application.LoadLevel("Menu");
    }

    public void RestartGame()
    {
        // Reload the level
        Application.LoadLevel("Main");
    }
}