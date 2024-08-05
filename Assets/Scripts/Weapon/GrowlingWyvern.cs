using System;
using DG.Tweening;
using UnityEngine;

public class GrowlingWyvern:Weapon
{
    [SerializeField] private SpriteRenderer _spear;
    [SerializeField] private float _stayTime;
    [SerializeField] private float _fadeTime;
    [SerializeField] private string _fxID;
    private bool _isAttacking;
    private Sequence _sequence;

    private void OnEnable()
    {
    }

    public override void Engage(Vector3 mousePosWorld)
    {
        if (_isAttacking)
        {
            return;
        }
        var go=PoolManager.Release(_fxID, transform.position, Quaternion.identity);
        go.transform.up = transform.up;
        _spear.color=Color.white;
        _spear.gameObject.SetActive(true);
        _isAttacking = true;
        _sequence = DOTween.Sequence();
        _sequence.AppendInterval(_stayTime);
        _sequence.Append(_spear.DOFade(0, _fadeTime));
        _sequence.OnComplete(() =>
        {
            _isAttacking = false;
        });
        _sequence.Play();
    }

}