using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
[GenerateAuthoringComponent]
public struct CubeSpawner : IComponentData
{
    public Entity CubePrefab;
    public int SpawnCount;
    public float Spacing;
}
