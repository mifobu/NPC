
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCParticles : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem deathParticlePrefab;
    void Start()
    {
        GetComponentInChildren<IHealth>().OnDied += HandleNPCDied; 
    }

    
    private void HandleNPCDied()
    {
        var deathparticle = Instantiate(deathParticlePrefab, transform.position, transform.rotation);
        Destroy(deathparticle, 4f);
    }
}
