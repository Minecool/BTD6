namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PreEmptiveStrikeLauncher), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PreEmptiveStrikeLauncherModel : TowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public float throwOffsetX; //Field offset: 0x40
	public float throwOffsetY; //Field offset: 0x44
	public float throwOffsetZ; //Field offset: 0x48
	public float throwOffsetSecondX; //Field offset: 0x4C
	public float throwOffsetSecondY; //Field offset: 0x50
	public float throwOffsetSecondZ; //Field offset: 0x54
	public EffectModel ejectEffectModel; //Field offset: 0x58
	public int animationState; //Field offset: 0x60
	public int animationStateSecond; //Field offset: 0x64
	public bool isStunned; //Field offset: 0x68

	public PreEmptiveStrikeLauncherModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float throwOffsetX, float throwOffsetY, float throwOffsetZ, float throwOffsetSecondX, float throwOffsetSecondY, float throwOffsetSecondZ, EffectModel ejectEffectModel, int animationState, int animationStateSecond, bool isStunned) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

