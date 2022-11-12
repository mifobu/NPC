using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfHits : MonoBehaviour, IHealth
{
    [SerializeField]
    private int healthInHits = 5;

    [SerializeField]
    private float invulnTimeAfterHit = 5f;

    private int hitsRemaining;
    private bool canTakeDmg = true;

    public event Action<float> OnHPPctChanged = delegate (float f) { };
    public event Action OnDied = delegate { };

    public float CurrentHPPct
    {
        get { return (float)hitsRemaining / (float)healthInHits; }
    }

    private void Start()
    {
        hitsRemaining = healthInHits;
    }

    public void TakeDamage(int amt)
    {
        if (canTakeDmg)
        {
            StartCoroutine(InvulnTimer());
            hitsRemaining--;
            OnHPPctChanged(CurrentHPPct);

            if (hitsRemaining <= 0)
                OnDied();
        }
    }

    private IEnumerator InvulnTimer()
    {
        canTakeDmg = false;
        yield return new WaitForSeconds(invulnTimeAfterHit);
        canTakeDmg = true;
    }
}
