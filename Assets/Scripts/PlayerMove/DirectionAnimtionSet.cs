using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DirectionAnimtionSet ", menuName = "GathererTopDownRPG/DirectionAnimtionSet ")]

public class DirectionAnimtionSet : ScriptableObject
{
    [field: SerializeField] public AnimationClip Up { get; private set; }
    [field: SerializeField] public AnimationClip Down { get; private set; }
    [field: SerializeField] public AnimationClip Left { get; private set; }
    [field: SerializeField] public AnimationClip Right { get; private set; }
}
