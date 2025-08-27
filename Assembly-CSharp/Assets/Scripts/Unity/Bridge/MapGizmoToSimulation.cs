namespace Assets.Scripts.Unity.Bridge;

public class MapGizmoToSimulation : MapInteractable
{
	private UnityToSimulation sim; //Field offset: 0x10
	private MapGizmo gizmo; //Field offset: 0x18
	private ObjectId Id; //Field offset: 0x20
	private Action action; //Field offset: 0x28

	public virtual ObjectId id
	{
		 get { } //Length: 4
	}

	public MapGizmoToSimulation(UnityToSimulation sim, MapGizmo gizmo) { }

	public virtual void AttachUpdateTextAction(Action action) { }

	public virtual void DetachUpdateTextAction(Action action) { }

	public virtual ObjectId get_id() { }

	public virtual string GetAnalyticsKey() { }

	public virtual string GetButtonText() { }

	public virtual Vector3 GetDisplayPosition() { }

	public virtual bool IsConfirmable() { }

	public virtual bool IsDisabled() { }

	public virtual void OnButtonConfirm() { }

	private void OnCashChanged() { }

}

