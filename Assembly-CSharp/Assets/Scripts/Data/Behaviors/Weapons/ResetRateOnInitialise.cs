namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "ResetRateOnInitialise", menuName = "BTD6/Behaviors/Weapons/ResetRateOnInitialise")]
public class ResetRateOnInitialise : WeaponBehavior
{
	public Weapon weapon; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 137
	}

	public ResetRateOnInitialise() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

