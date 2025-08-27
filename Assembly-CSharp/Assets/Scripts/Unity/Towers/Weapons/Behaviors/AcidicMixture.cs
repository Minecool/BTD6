namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class AcidicMixture : WeaponBehavior
{
	public AcidicMixture parent; //Field offset: 0x90
	public ProjectileBehavior primaryBehavior; //Field offset: 0x98
	public ProjectileBehavior expPrimaryBehavior; //Field offset: 0xA0
	public ProjectileBehavior secondaryBehavior; //Field offset: 0xA8
	public ProjectileBehavior expSecondaryBehavior; //Field offset: 0xB0
	public ProjectileBehavior tertiaryBehavior; //Field offset: 0xB8
	public ProjectileBehavior expTertiaryBehavior; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public AcidicMixture() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

