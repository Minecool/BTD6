namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "VineRupture", menuName = "BTD6/Behaviors/Abilities/VineRupture")]
public class VineRupture : AbilityBehavior
{
	public Effect effect; //Field offset: 0x30
	public float interval; //Field offset: 0x38
	public Projectile projectile; //Field offset: 0x40
	public Sound sound1; //Field offset: 0x48
	public Sound sound2; //Field offset: 0x50
	public Sound sound3; //Field offset: 0x58
	public Sound sound4; //Field offset: 0x60

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 616
	}

	public VineRupture() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

