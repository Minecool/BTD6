namespace Assets.Scripts.Models.Behaviors;

[Implementation(typeof(AgeingDestroy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AgeingDestroyModel : Model
{
	public float time; //Field offset: 0x30
	public int timeFrames; //Field offset: 0x34
	public bool useRoundTime; //Field offset: 0x38

	public float Time
	{
		 set { } //Length: 21
	}

	public AgeingDestroyModel(string name, float time, bool useRoundTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Time(float value) { }

}

