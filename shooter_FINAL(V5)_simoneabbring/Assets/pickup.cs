
using UnityEngine;

public class pickup : MonoBehaviour
{
    private bool canPickUp;
    private AudioSource mAudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();

    }

  

    // Update is called once per frame
    void Update()
    {
        //press e and it will destroy the key
        if (Input.GetKeyDown("e"))
        {
            mAudioSrc.Play();

            Destroy(gameObject, 1f);
        }

    }
        //if close by ya can pick it up else not
      
        
    
}

