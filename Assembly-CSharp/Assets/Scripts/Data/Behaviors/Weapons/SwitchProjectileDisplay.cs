namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SwitchProjectileDisplay", menuName = "BTD6/Behaviors/Weapons/SwitchProjectileDisplay")]
public class SwitchProjectileDisplay : WeaponBehavior
{
	public SpriteGroup spriteGroup; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 119
	}

	public SwitchProjectileDisplay() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

