namespace Assets.Scripts.Unity.Bridge;

public class RemoveablePropToSimulation : MapInteractable
{
	private UnityToSimulation sim; //Field offset: 0x10
	private Prop prop; //Field offset: 0x18
	private ObjectId Id; //Field offset: 0x20
	private Action action; //Field offset: 0x28
	public Action OnDestroyed; //Field offset: 0x30
	public Action OnSelectionDisabled; //Field offset: 0x38

	public virtual ObjectId id
	{
		 get { } //Length: 4
	}

	public double RemoveableCost
	{
		 get { } //Length: 29
	}

	public RemoveablePropToSimulation(UnityToSimulation sim, Prop prop) { }

	public virtual void AttachUpdateTextAction(Action action) { }

	public void Destroy() { }

	public virtual void DetachUpdateTextAction(Action action) { }

	public virtual ObjectId get_id() { }

	public double get_RemoveableCost() { }

	public virtual string GetAnalyticsKey() { }

	public virtual string GetButtonText() { }

	public virtual Vector3 GetDisplayPosition() { }

	public Prop GetSimProp() { }

	public virtual bool IsConfirmable() { }

	public virtual bool IsDisabled() { }

	public virtual void OnButtonConfirm() { }

	private void OnCashChanged() { }

	public void SelectableDisabled() { }

}

