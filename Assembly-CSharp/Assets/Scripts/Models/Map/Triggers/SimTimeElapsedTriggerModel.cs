namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(SimTimeElapsedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SimTimeElapsedTriggerModel : MapTriggerModel
{
	[SerializeField]
	private float time; //Field offset: 0x38
	public int timeFrames; //Field offset: 0x3C
	public int rounds; //Field offset: 0x40
	public bool useRoundTime; //Field offset: 0x44

	public SimTimeElapsedTriggerModel(string name, float time, int rounds, bool useRoundTime) { }

}

