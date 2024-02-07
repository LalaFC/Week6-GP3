using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityFXManger : MonoBehaviour
{
    public static AbilityFXManger Instance { get; private set; }
    public List<ParticleSystem> AttackFX = new();
    public List<ParticleSystem> SkillFX = new();
    public List<ParticleSystem> UltFX = new();

    public void Awake()
    {
        Instance = this;
    }

}
