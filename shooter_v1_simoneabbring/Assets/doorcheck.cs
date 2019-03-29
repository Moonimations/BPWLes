
using UnityEngine;

public class doorcheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Doors");

    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Keys").Length == 0)
        {
            Destroy(gameObject);
        }
    }
}
