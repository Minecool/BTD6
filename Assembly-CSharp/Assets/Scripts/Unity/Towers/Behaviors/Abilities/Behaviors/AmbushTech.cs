namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class AmbushTech : AbilityBehavior
{
	public AmbushTech parent; //Field offset: 0x88
	public GameObject display; //Field offset: 0x90
	public GameObject expDisplay; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public AmbushTech() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

