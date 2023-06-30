using System;
using System.Numerics;
using UnityEngine.Serialization;
using Vector2 = UnityEngine.Vector2;

[Serializable]
public struct EnemyBehaviorData
{
    
    public bool HasSetPath;
    [FormerlySerializedAs("RadiusFromTarget")] public float HowCloseCanIGetToTarget;
    public Vector2 TargetPosition;
    public Vector2 StartingPosition;
    
    public EnemyBehaviorData (bool has_set_path )
    {
        HasSetPath = has_set_path;
        HowCloseCanIGetToTarget = 1.0f;
        TargetPosition = Vector2.zero;
        StartingPosition = Vector2.one;
    }


}
