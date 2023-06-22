using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[BurstCompile]
public class TurretRotationSystem : ISystem
{
    [BurstCompile]
    public void OnCrate(ref SystemState state)
    {

    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {

    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var rotation = quaternion.RotateY(SystemAPI.Time.DeltaTime * math.PI);
        foreach(var transform in SystemAPI.Query<TransformAspect>())
        {
            transform.RotateWorld(rotation);
        }
    }
}
