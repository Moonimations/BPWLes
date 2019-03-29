using UnityEngine;

using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour{

    private NavMeshAgent _nav;
    private Transform _player;



    void Start()

    {

        _nav = GetComponent<NavMeshAgent>();



        _player = GameObject.FindGameObjectWithTag("Player").transform;

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.transform == _player)
        {
            _nav.SetDestination(_player.position);
        }
    }

}

