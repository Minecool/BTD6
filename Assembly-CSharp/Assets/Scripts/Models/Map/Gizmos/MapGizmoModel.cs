namespace Assets.Scripts.Models.Map.Gizmos;

[Implementation(typeof(MapGizmo), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapGizmoModel : Model
{
	public string areaName; //Field offset: 0x30
	public Vector3 position; //Field offset: 0x38
	public MapGizmoBehaviorModel[] behaviors; //Field offset: 0x48
	public MapUnityAction[] activateActions; //Field offset: 0x50
	public MapUnityAction[] deactivateActions; //Field offset: 0x58
	public GizmoTimeDisplay timeDisplay; //Field offset: 0x60

	public MapGizmoModel(string name, string areaName, Vector3 position, MapGizmoBehaviorModel[] behaviors, MapUnityAction[] activateActions, MapUnityAction[] deactivateActions, GizmoTimeDisplay timeDisplay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

