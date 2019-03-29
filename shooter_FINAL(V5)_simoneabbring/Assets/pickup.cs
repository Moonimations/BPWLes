
using UnityEngine;

public class pickup : MonoBehaviour
{
    private bool canPickUp;
   

    // Start is called before the first frame update
    void Start()
    {
        

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
      
        
    
}

