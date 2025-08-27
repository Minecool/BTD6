namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(TriggerMapActionsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerMapActionsActionModel : MapActionModel
{
	public MapActionModel[] actions; //Field offset: 0x38
	public MapUnityAction[] unityActions; //Field offset: 0x40

	public TriggerMapActionsActionModel(string name, MapActionModel[] actions, MapUnityAction[] unityActions) { }

}

