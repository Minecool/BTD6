namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "GroundZeroBombBuff", menuName = "BTD6/Behaviors/Abilities/GroundZeroBombBuff")]
public class GroundZeroBombBuff : AbilityBehavior
{
	public int damageIncrease; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 131
	}

	public GroundZeroBombBuff() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

