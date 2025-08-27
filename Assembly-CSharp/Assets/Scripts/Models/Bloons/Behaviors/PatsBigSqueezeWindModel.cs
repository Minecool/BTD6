namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PatsBigSqueezeWind), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PatsBigSqueezeWindModel : BloonBehaviorModel
{
	public Vector3 startLocation; //Field offset: 0x30
	public int framesToWait; //Field offset: 0x3C
	public string mutatorId; //Field offset: 0x40

	public PatsBigSqueezeWindModel() { }

	public PatsBigSqueezeWindModel(string name, Vector3 startLocation, int framesToWait, string mutatorId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

