namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateRangeSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivateRangeSupportZone")]
public class ActivateRangeSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public bool isUnique; //Field offset: 0x38
	public float multiplier; //Field offset: 0x3C
	public float additive; //Field offset: 0x40
	public float range; //Field offset: 0x44
	public float maxNumTowersModified; //Field offset: 0x48
	public bool canAffectThisTower; //Field offset: 0x4C
	public float lifespan; //Field offset: 0x50
	public TowerFilter[] filters; //Field offset: 0x58

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 298
	}

	public ActivateRangeSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

