namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class FindDeploymentLocation : AbilityBehavior
{
	public DamageUp parent; //Field offset: 0x88
	public float searchRadius; //Field offset: 0x90
	public string expSearchRadius; //Field offset: 0x98
	public float pointDistance; //Field offset: 0xA0
	public string expPointDistance; //Field offset: 0xA8
	public Tower tower; //Field offset: 0xB0
	public Tower expTower; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 187
	}

	public FindDeploymentLocation() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

