namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BonusProjectileAfterInterval), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BonusProjectileAfterIntervalModel : WeaponBehaviorModel
{
	public int interval; //Field offset: 0x30
	public string expInterval; //Field offset: 0x38
	public ProjectileModel projectileModel; //Field offset: 0x40
	public EmissionModel emissionModel; //Field offset: 0x48
	public bool useTowerPosition; //Field offset: 0x50
	[SerializeField]
	private float cooldown; //Field offset: 0x54
	public int cooldownFrames; //Field offset: 0x58

	public BonusProjectileAfterIntervalModel(string name, int interval, ProjectileModel projectileModel, EmissionModel emissionModel, bool useTowerPosition, float cooldown) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

