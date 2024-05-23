using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashAinm : MonoBehaviour
{
    private ParticleSystem ps;

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (ps && !ps.IsAlive())
        {
            DestroySeft();
        }
    }
    public void DestroySeft()
    {
        Destroy(gameObject);
    }
}
