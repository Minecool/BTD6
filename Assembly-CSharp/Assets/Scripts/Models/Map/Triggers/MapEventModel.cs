namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(MapEvent), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapEventModel : Model
{
	public string saveId; //Field offset: 0x30
	public bool oneTimeEvent; //Field offset: 0x38
	public bool allTriggersRequired; //Field offset: 0x39
	public bool inactiveByDefault; //Field offset: 0x3A
	public bool trackArrowsOnTrigger; //Field offset: 0x3B
	public float trackArrowDistanceOverride; //Field offset: 0x3C
	public int trackArrowAmountOverride; //Field offset: 0x40
	public MapTriggerModel[] triggers; //Field offset: 0x48
	public MapActionModel[] actions; //Field offset: 0x50
	public MapUnityAction[] unityActions; //Field offset: 0x58

	public MapEventModel(string name, bool oneTimeEvent, bool allTriggersRequired, bool inactiveByDefault, MapTriggerModel[] triggers, MapActionModel[] actions, MapUnityAction[] unityActions, bool trackArrowsOnTrigger = false, float trackArrowDistanceOverride = 0, int trackArrowAmountOverride = 0) { }

	public virtual Model Clone() { }

	public override void GotoPostActions() { }

	public override void GotoPreActions(bool mapEventActive) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public override void PerformActions() { }

}

