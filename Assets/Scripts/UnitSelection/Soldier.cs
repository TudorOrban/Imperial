using System.Collections.Generic;

public class Soldier
{
    // Constant
    public int movementSpeed;
    public int mountedMovementSpeed;
    public bool isMounted;


    public WeaponType weaponType;
    public float meleeDamage;
    public float meleeRange;
    public float attackSpeed;
    public float armourPiercing; // between 0 and 1
    public float chargingBonusDamage;
    public float chargingStunDuration;

    public float rangedDamage;
    public int rangedAttackSpeed;
    public float rangedAttackRange;
    public float accurracy;
    public float totalAmmunition;

    public float hp;
    public float armor;
    public float stamina;

    // Dynamic
    public float morale;
    public float fatigue;

}