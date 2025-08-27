namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CashBoost : AbilityBehavior
{
	public CashBoost parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public float range; //Field offset: 0xB0
	public string expRange; //Field offset: 0xB8
	public string filterTower; //Field offset: 0xC0

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public CashBoost() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

