namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(ChangeSimTimeElapsedTriggerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeSimTimeElapsedTriggerActionModel : MapActionModel
{
	public string mapEventName; //Field offset: 0x38
	[SerializeField]
	private float timeReduction; //Field offset: 0x40
	public int timeReductionFrames; //Field offset: 0x44

	public ChangeSimTimeElapsedTriggerActionModel(string name, string mapEventName, float timeReduction) { }

}

