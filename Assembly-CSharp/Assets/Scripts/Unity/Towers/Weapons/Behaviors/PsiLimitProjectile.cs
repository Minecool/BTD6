namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class PsiLimitProjectile : WeaponBehavior
{
	public PsiLimitProjectile parent; //Field offset: 0x90

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public PsiLimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

