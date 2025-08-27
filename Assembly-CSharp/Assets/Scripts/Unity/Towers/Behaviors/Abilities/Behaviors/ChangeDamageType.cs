namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ChangeDamageType : AbilityBehavior
{
	public ChangeDamageType parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool cantBeAbsorbed; //Field offset: 0xA0
	public string expCantBeAbsorbed; //Field offset: 0xA8
	public string damageType; //Field offset: 0xB0
	public string expDamageType; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 215
	}

	public ChangeDamageType() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

