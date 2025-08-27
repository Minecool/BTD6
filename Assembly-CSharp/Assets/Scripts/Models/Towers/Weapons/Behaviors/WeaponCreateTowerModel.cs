namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

public class WeaponCreateTowerModel : WeaponBehaviorModel
{
	public TowerModel[] towers; //Field offset: 0x30

	public WeaponCreateTowerModel(string name, TowerModel[] towers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

