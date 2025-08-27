namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CritRollWithDistance), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CritRollWithDistanceModel : CritRollModel
{
	public float bonusPerDistance; //Field offset: 0x48

	public CritRollWithDistanceModel(string name, float damageAdditive, float damageMultiplier, float chance, PrefabReference display, float bonusPerDistance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

