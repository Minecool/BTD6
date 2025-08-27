namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "BonusProjectileAfterInterval", menuName = "BTD6/Behaviors/Weapons/BonusProjectileAfterInterval")]
public class BonusProjectileAfterInterval : WeaponBehavior
{
	public int interval; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40
	public bool useTowerPosition; //Field offset: 0x48
	public float cooldown; //Field offset: 0x4C

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 247
	}

	public BonusProjectileAfterInterval() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

