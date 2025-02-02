using UnityEngine;

public abstract class Effect :ScriptableObject
{
    [Header("效果的数值大小")]
    public int value;

    [Header("效果的释放类型")]

    public EffectTargetType targetType;

    [Header("效果的释放音效")]

    public AudioClip soumdVFX;


    public abstract void Excute(CharacterBase from , CharacterBase Target);
}
