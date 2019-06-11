using UnityEngine;

using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour{

    private NavMeshAgent _nav;
    private Transform _player;

    public Animator anim;


    void Start()

    

    {

        anim = GetComponent<Animator>();

        _nav = GetComponent<NavMeshAgent>();



        _player = GameObject.FindGameObjectWithTag("Player").transform;

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.transform == _player)
        {
            _nav.SetDestination(_player.position);

            anim.Play("jog_fwd");
        }


        
    }

}

