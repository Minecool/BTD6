namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class DetectCamoOnAbility : AbilityBehavior
{
	public DetectCamoOnAbility parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public string mutatorId; //Field offset: 0xA0
	public string expMutatorId; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 135
	}

	public DetectCamoOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

