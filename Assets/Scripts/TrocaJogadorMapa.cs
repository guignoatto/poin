using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocaJogadorMapa : MonoBehaviour
{
    private Jogador jogador;
    private Image _spriteRenderer;
    private void Start()
    {
        GameEvents.sInstance.TrocarJogadorEvent += ctx => TrocarSkin(ctx);
        jogador = GetComponent<Jogador>();
        _spriteRenderer = GetComponent<Image>();
    }

    private void TrocarSkin(SJogador j)
    {
        if (jogador._jogador.LaneJogador == j.LaneJogador)
        {
            _spriteRenderer.sprite = j.Foto;
        }
    }
}
