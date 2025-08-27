namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageBasedAttackSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageBasedAttackSpeedModel : TowerBehaviorModel
{
	public float damageThreshold; //Field offset: 0x30
	public float increasePerThreshold; //Field offset: 0x34
	public int maxStacks; //Field offset: 0x38
	public int maxTimeInFramesWithoutDamage; //Field offset: 0x3C

	public DamageBasedAttackSpeedModel(string name, float damageThreshold, int maxTimeInFramesWithoutDamage, float increasePerThreshold, int maxStacks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

