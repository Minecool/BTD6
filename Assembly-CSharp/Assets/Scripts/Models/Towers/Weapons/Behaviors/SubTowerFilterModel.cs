namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(SubTowerFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SubTowerFilterModel : WeaponBehaviorModel
{
	public string baseSubTowerId; //Field offset: 0x30
	public String[] baseSubTowerIds; //Field offset: 0x38
	public float maxNumberOfSubTowers; //Field offset: 0x40
	public bool checkForPreExisting; //Field offset: 0x44

	public SubTowerFilterModel(string name, string baseSubTowerId, float maxNumberOfSubTowers, bool checkForPreExisting) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

