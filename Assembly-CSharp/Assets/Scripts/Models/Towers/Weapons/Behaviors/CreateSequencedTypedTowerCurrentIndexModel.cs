namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CreateSequencedTypedTowerCurrentIndex), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSequencedTypedTowerCurrentIndexModel : WeaponCreateTowerModel
{
	public bool onlyAllowOneTowerPerType; //Field offset: 0x38
	public PrefabReference[] projectileDisplays; //Field offset: 0x40

	public CreateSequencedTypedTowerCurrentIndexModel(string name, bool onlyAllowOneTowerPerType, TowerModel[] towers, PrefabReference[] projectileDisplays) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

