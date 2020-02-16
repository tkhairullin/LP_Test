using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayConfetti : MonoBehaviour
{
    public GameObject ConfettiParticle;

    public void PlVictory()
    {
        GameObject obj = Instantiate(ConfettiParticle);
        Destroy(obj, 2.5f);
    }
}
