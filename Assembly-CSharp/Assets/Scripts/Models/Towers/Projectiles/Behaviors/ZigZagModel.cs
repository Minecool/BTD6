namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ZigZag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ZigZagModel : ProjectileBehaviorModel
{
	public float maxOffset; //Field offset: 0x38
	public float zigZagSpeed; //Field offset: 0x3C

	public ZigZagModel(string name, float maxOffset, float zigZagSpeed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

