namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "AmbushTech", menuName = "BTD6/Behaviors/Abilities/AmbushTech")]
public class AmbushTech : AbilityBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public float radius; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public AmbushTech() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

