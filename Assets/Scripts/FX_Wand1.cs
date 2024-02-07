using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX_Wand1 : WeaponAbilities
{
    private ParticleSystem attack, skill, ultimate;
    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Ultimate()
    {
        ultimate = AbilityFXManger.Instance.UltFX[0];
        Instantiate(ultimate, player.transform);    //SOLVE MO UNG EFFECT POSITION!
        ultimate.Play();
    }
    public override void Skill()
    {
        skill = AbilityFXManger.Instance.SkillFX[0]; //Change index depending on unity editor index
        Instantiate(skill, player.transform);
        skill.Play();
    }
    public override void Attack()
    {
        attack = AbilityFXManger.Instance.AttackFX[0];
        Instantiate(attack, player.transform);
        attack.Play();
    }

}
