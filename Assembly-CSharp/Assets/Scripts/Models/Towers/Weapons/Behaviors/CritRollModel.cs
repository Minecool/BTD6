namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CritRoll), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CritRollModel : WeaponBehaviorModel
{
	public float damageAdditive; //Field offset: 0x30
	public float damageMultiplier; //Field offset: 0x34
	public float chance; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public CritRollModel(string name, float damageAdditive, float damageMultiplier, float chance, PrefabReference display) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

