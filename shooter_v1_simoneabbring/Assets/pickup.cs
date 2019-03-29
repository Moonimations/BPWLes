
using UnityEngine;

public class pickup : MonoBehaviour
{
    private bool canPickUp;
   

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Keys");


    }

    // Update is called once per frame
    void Update()
    {
        //press e and it will destroy the key
        if (Input.GetKeyDown("e"))
        {
            Destroy(gameObject);
        }

    }
        //if close by ya can pick it up else not
        private void OnTriggerEnter(Collider other){
            if (other.gameObject.tag == "Player") canPickUp = true;
        }

        private void OnTriggerExit(Collider other){
            if (other.gameObject.tag == "Player") canPickUp = false;
        }

        
    
}

