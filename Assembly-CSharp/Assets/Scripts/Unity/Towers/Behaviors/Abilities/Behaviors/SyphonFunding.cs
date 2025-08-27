namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class SyphonFunding : AbilityBehavior
{
	public SyphonFunding parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public SyphonFunding() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

