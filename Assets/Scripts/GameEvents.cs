using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents sInstance;

    public event Action<SJogador> TrocarJogadorEvent;

    private void Awake()
    {
        if (sInstance == null)
        {
            sInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TrocarJogador(SJogador j)
    {
        TrocarJogadorEvent?.Invoke(j);
    }
}
