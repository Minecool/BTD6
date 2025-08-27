namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(LivesLowerThanTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LivesLowerThanTriggerModel : MapTriggerModel
{
	public int lives; //Field offset: 0x38
	public bool usePercent; //Field offset: 0x3C
	public float percent; //Field offset: 0x40

	public LivesLowerThanTriggerModel(string name, int lives, bool usePercent, float percent) { }

}

