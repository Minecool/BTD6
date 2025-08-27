namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivateRangeSupportZone : AbilityBehavior
{
	public ActivateRangeSupportZone parent; //Field offset: 0x88
	public string mutatorId; //Field offset: 0x90
	public string expMutatorId; //Field offset: 0x98
	public bool isUnique; //Field offset: 0xA0
	public string expIsUnique; //Field offset: 0xA8
	public float multiplier; //Field offset: 0xB0
	public string expMultiplier; //Field offset: 0xB8
	public float additive; //Field offset: 0xC0
	public string expAdditive; //Field offset: 0xC8
	public float range; //Field offset: 0xD0
	public string expRange; //Field offset: 0xD8
	public float maxNumTowersModified; //Field offset: 0xE0
	public string expMaxNumTowersModified; //Field offset: 0xE8
	public bool canAffectThisTower; //Field offset: 0xF0
	public string expCanAffectThisTower; //Field offset: 0xF8
	public float lifespan; //Field offset: 0x100
	public string expLifespan; //Field offset: 0x108

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 366
	}

	public ActivateRangeSupportZone() { }

	public TowerFilterModel[] GatherFilters() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

