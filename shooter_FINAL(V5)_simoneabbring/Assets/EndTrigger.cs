
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public ControlsTutorial gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
