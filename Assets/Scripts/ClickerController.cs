using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerController : MonoBehaviour
{
    public float multiplier = 1;

    [SerializeField] private UIController _UIController;
    [SerializeField] private LojaJogadores _lojaJogadores;

    private Animator _animator;

    public void OnClickPoin()
    {
        _lojaJogadores.dinheiros += 1 * multiplier;
        _animator.SetTrigger("Click");
        _UIController.AtualizarDinheiros(_lojaJogadores.dinheiros);
    }

    public void AddMultiplier(float m)
    {
        multiplier += m;
    }

    private void Start()    
    {
        Initialize();
    }

    private void Initialize()
    {
        GameEvents.sInstance.TrocarJogadorEvent += ctx => TrocarJogador(ctx);
        _animator = GetComponent<Animator>();
        _UIController.InicializarDinheiros(_lojaJogadores.dinheiros);
    }

    private void TrocarJogador(SJogador j)
    {
        AddMultiplier(j.Multiplicador);
    }
}
