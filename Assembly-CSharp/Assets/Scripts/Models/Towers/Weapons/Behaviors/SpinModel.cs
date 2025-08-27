namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(Spin), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpinModel : WeaponBehaviorModel
{
	[SerializeField]
	private float rotationPerSecond; //Field offset: 0x30
	public float rotationPerFrame; //Field offset: 0x34

	public SpinModel(string name, float rotationPerSecond) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void Recalculate() { }

}

