namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(NecroEmissionFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class NecroEmissionFilterModel : WeaponBehaviorModel
{
	public bool isPriceOfDakrnessEmission; //Field offset: 0x30

	public NecroEmissionFilterModel(string name, bool isPriceOfDakrnessEmission) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

