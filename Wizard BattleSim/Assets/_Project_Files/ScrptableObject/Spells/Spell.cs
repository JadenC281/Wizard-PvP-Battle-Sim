using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Spell")]
public class Spell : ScriptableObject {
    public float Spell_Speed; // Spell Travel Speed
    public float Spell_Damage; // Spell's Damage
    public GameObject Spell_Prefab;
    public float CooldownDuration; // Cooldown duration in seconds
    public float LifeTime;

    public enum SpellType { // The Types Of Spells
        Spawnable_Spell,
        Castable_Spell,
        ExsplosionSpell,
        TrapSpell
    };
    public SpellType Spell_Type;

    public void SpellHit(GameObject other, GameObject self)
    {
        if (other.GetComponent<IHittable_inherited>() || other.GetComponentInChildren<IHittable_inherited>())
        { 
           other.GetComponent<IHittable_inherited>().GotHit(self);
        }
    }
}
