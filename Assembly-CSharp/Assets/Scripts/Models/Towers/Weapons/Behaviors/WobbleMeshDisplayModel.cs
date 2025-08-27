namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(WobbleMeshDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WobbleMeshDisplayModel : WeaponBehaviorModel
{
	public float min; //Field offset: 0x30
	public float max; //Field offset: 0x34
	public float time; //Field offset: 0x38

	public WobbleMeshDisplayModel(string name, float min, float max, float time) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

