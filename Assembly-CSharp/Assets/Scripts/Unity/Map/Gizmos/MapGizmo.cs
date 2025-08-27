namespace Assets.Scripts.Unity.Map.Gizmos;

public class MapGizmo : MonoBehaviour
{
	public MapUnityAction[] activateActions; //Field offset: 0x20
	public MapUnityAction[] deactivateActions; //Field offset: 0x28
	public GizmoTimeDisplay timeDisplay; //Field offset: 0x30
	private MapGizmoModel def; //Field offset: 0x38

	public MapGizmoModel Def
	{
		 get { } //Length: 478
	}

	public MapGizmo() { }

	public MapGizmoModel get_Def() { }

	public Vector3 GetCenterPoint(Area area) { }

}

