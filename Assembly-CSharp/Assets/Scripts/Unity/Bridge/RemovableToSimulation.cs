namespace Assets.Scripts.Unity.Bridge;

public class RemovableToSimulation : MapInteractable
{
	public readonly RemoveableModel model; //Field offset: 0x10
	private readonly Removeable removable; //Field offset: 0x18
	private UnityToSimulation sim; //Field offset: 0x20
	public string preFormatedCostTxt; //Field offset: 0x28
	private Action action; //Field offset: 0x30

	public virtual ObjectId id
	{
		 get { } //Length: 26
	}

	public RemovableToSimulation(UnityToSimulation sim, Removeable removable) { }

	public virtual void AttachUpdateTextAction(Action action) { }

	public virtual void DetachUpdateTextAction(Action action) { }

	public virtual ObjectId get_id() { }

	public virtual string GetAnalyticsKey() { }

	public virtual string GetButtonText() { }

	public virtual Vector3 GetDisplayPosition() { }

	public ObjectId GetRemoveableId() { }

	public string GetRemoveableName() { }

	public Removeable GetSimRemovable() { }

	public virtual bool IsConfirmable() { }

	public virtual bool IsDisabled() { }

	public virtual void OnButtonConfirm() { }

	private void OnCashChanged() { }

	public void SellRemovable() { }

}

