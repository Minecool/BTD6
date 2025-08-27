namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SwitchProjectileDisplay : WeaponBehavior
{
	public SwitchProjectileDisplay parent; //Field offset: 0x90
	public SpriteGroup spriteGroup; //Field offset: 0x98
	public SpriteGroup expSpriteGroup; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public SwitchProjectileDisplay() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

