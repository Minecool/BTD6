namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "BrickellFreezeMinesAbilityBuff", menuName = "BTD6/Behaviors/Abilities/BrickellFreezeMinesAbilityBuff")]
public class BrickellFreezeMinesAbilityBuff : AbilityBehavior
{
	public float multiplier; //Field offset: 0x30
	public float projectileSpeedMultiplier; //Field offset: 0x34
	public float duration; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 193
	}

	public BrickellFreezeMinesAbilityBuff() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

