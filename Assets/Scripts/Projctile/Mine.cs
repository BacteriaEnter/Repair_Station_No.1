using UnityEngine;

public class Mine:Projectile
{
   
   public override void Init(Vector3 dir, float damage)
   {
      base.Init(dir, damage);
      _moveState = ProjectileMoveState.Freeze;
   }


}