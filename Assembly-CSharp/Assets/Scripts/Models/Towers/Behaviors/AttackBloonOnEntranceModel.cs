namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AttackBloonOnEntrance), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AttackBloonOnEntranceModel : TowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public float throwOffsetX; //Field offset: 0x40
	public float throwOffsetY; //Field offset: 0x44
	public float throwOffsetZ; //Field offset: 0x48
	public EffectModel ejectEffectModel; //Field offset: 0x50
	public int animationState; //Field offset: 0x58
	public string bloonTags; //Field offset: 0x60
	public String[] bloonTagsList; //Field offset: 0x68

	public AttackBloonOnEntranceModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float throwOffsetX, float throwOffsetY, float throwOffsetZ, EffectModel ejectEffectModel, int animationState, string bloonTags) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

