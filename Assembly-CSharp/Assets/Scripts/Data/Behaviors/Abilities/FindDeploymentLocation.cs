namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "FindDeploymentLocation", menuName = "BTD6/Behaviors/Abilities/FindDeploymentLocation")]
public class FindDeploymentLocation : AbilityBehavior
{
	public float searchRadius; //Field offset: 0x30
	public float pointDistance; //Field offset: 0x34
	public Tower tower; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 191
	}

	public FindDeploymentLocation() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

