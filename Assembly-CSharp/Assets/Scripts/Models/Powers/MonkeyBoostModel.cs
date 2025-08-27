namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(MonkeyBoost), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyBoostModel : PowerBehaviorModel
{
	public float rateScale; //Field offset: 0x30
	[SerializeField]
	private float duration; //Field offset: 0x34
	public int durationFrames; //Field offset: 0x38

	public float Duration
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public MonkeyBoostModel(string name, float rateScale, float duration) { }

	public virtual Model Clone() { }

	public float get_Duration() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Duration(float value) { }

}

