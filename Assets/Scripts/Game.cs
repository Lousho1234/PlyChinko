using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    public static bool isGameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Show The Start Screen
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);  
    }

    public void OnStartButtonClicked()
    {
        print("Clicked!");
        
        // Hide Start Screen
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        
        // Remember that the game ahs started
        isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
