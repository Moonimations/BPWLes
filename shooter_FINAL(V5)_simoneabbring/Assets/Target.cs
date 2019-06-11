
using UnityEngine;

public class Target : MonoBehaviour
{

    private AudioSource mAudioSrc;



    public float health = 50f;



    public void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();
    }



    public void TakeDamage(float amount)
    {

        health -= amount;

    


        if (health <= 0f)
        {
            
            Die();


        }
    }

    void Die()
    {


        mAudioSrc.Play();

        Destroy(gameObject, 1f);

    }

    
}
