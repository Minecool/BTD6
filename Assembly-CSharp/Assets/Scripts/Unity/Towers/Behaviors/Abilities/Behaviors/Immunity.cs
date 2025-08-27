namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Immunity : AbilityBehavior
{
	public Turbo parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 216
	}

	public Immunity() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

