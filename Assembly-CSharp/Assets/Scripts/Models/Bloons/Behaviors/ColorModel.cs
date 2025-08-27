namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(Color), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ColorModel : BloonBehaviorModel
{
	public float red; //Field offset: 0x30
	public float green; //Field offset: 0x34
	public float blue; //Field offset: 0x38
	public float alpha; //Field offset: 0x3C

	public ColorModel() { }

	public ColorModel(string name, float red, float green, float blue, float alpha) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

