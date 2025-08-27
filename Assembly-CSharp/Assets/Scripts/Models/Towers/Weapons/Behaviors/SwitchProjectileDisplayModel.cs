namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(SwitchProjectileDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwitchProjectileDisplayModel : WeaponBehaviorModel
{
	public PrefabReference[] sprites; //Field offset: 0x30

	public SwitchProjectileDisplayModel(string name, PrefabReference[] sprites) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

