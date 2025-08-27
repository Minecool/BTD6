namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AcidicMixture", menuName = "BTD6/Behaviors/Weapons/AcidicMixture")]
public class AcidicMixture : WeaponBehavior
{
	public ProjectileBehavior primaryBehavior; //Field offset: 0x30
	public ProjectileBehavior secondaryBehavior; //Field offset: 0x38
	public ProjectileBehavior tertiaryBehavior; //Field offset: 0x40

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public AcidicMixture() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

