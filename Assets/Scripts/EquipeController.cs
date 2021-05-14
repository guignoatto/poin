using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipeController : MonoBehaviour
{
    [SerializeField] private ClickerController _poinButton;
    public List<SJogador> barca;

    private void Start()
    {
    }


    public void TrocarJogador(SJogador jogador)
    {
        GameEvents.sInstance.TrocarJogador(jogador);
        AtualizarListaJogadores(jogador);
    }

    private void AtualizarListaJogadores(SJogador jogador)
    {
        List<SJogador> newListBarca = new List<SJogador>(barca);

        foreach (SJogador j in barca)
        {
            if (j.LaneJogador == jogador.LaneJogador)
            {
                newListBarca.Remove(j);
                newListBarca.Add(jogador);

                _poinButton.AddMultiplier(-j.Multiplicador);
                continue;
            }
        }

        barca = newListBarca;
    }
}
