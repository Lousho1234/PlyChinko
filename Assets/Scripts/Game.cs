using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private bool isGameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Show The Start Screen
        CanvasGroupDisplayer.Show(CanvasGroup);  
    }

    public void OnStartButtonClicked()
    {
        print("Clicked!");
        
        // Hide Start Screen
        CanvasGroupDisplayer.Hide(CanvasGroup);
        
        // Remember that the game ahs started
        isGameStarted = true;
    }
}
