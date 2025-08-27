namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DepletionToCash), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DepletionToCashModel : ProjectileBehaviorModel
{
	public float minimum; //Field offset: 0x38
	public float maximum; //Field offset: 0x3C
	public float salvage; //Field offset: 0x40

	public DepletionToCashModel(string name, float minimum, float maximum, float salvage) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

