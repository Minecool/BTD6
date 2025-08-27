namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "DetectCamoOnAbility", menuName = "BTD6/Behaviors/Abilities/DetectCamoOnAbility")]
public class DetectCamoOnAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public DetectCamoOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

