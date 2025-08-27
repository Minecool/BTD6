namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class GroundZeroBombBuff : AbilityBehavior
{
	public GroundZeroBombBuff parent; //Field offset: 0x88
	public int damageIncrease; //Field offset: 0x90
	public string expDamageIncrease; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 137
	}

	public GroundZeroBombBuff() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

