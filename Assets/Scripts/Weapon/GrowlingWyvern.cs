using DG.Tweening;
using UnityEngine;

public class GrowlingWyvern:Weapon
{
    [SerializeField] private SpriteRenderer _spear;
    private float _stayTime;
    private float _fadeTime;
    private bool _isAttacking;
    private Sequence _sequence;
    public override void Engage(Vector3 mousePosWorld)
    {
        if (_isAttacking)
        {
            return;
        }
        _spear.color=Color.white;
        _spear.gameObject.SetActive(true);
        _isAttacking = true;
        _sequence.AppendInterval(_stayTime);
        _sequence.Append(_spear.DOFade(0, _fadeTime));
    }

}