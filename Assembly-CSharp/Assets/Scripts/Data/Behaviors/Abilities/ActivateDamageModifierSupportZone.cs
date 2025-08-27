namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateDamageModifierSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivateDamageModifierSupportZone")]
public class ActivateDamageModifierSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public float range; //Field offset: 0x40
	public float maxNumTowersModified; //Field offset: 0x44
	public bool canAffectThisTower; //Field offset: 0x48
	public DamageModifier damageModifier; //Field offset: 0x50
	public TowerFilter[] filters; //Field offset: 0x58

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 401
	}

	public ActivateDamageModifierSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

