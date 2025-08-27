namespace Assets.Scripts.Unity.Bridge;

public class RegenRemovableToSimulation : MapInteractable
{
	private readonly RegenRemovable regenRemovable; //Field offset: 0x10
	private readonly UnityToSimulation sim; //Field offset: 0x18
	private readonly FormulaicCost formulaicCost; //Field offset: 0x20
	public readonly RegenRemovableModel model; //Field offset: 0x28
	private Action action; //Field offset: 0x30

	public virtual ObjectId id
	{
		 get { } //Length: 26
	}

	public RegenRemovableToSimulation(UnityToSimulation sim, RegenRemovable regenRemovable) { }

	public virtual void AttachUpdateTextAction(Action action) { }

	public virtual void DetachUpdateTextAction(Action action) { }

	public virtual ObjectId get_id() { }

	public virtual string GetAnalyticsKey() { }

	public virtual string GetButtonText() { }

	public virtual Vector3 GetDisplayPosition() { }

	public ObjectId GetRegenRemovableId() { }

	public string GetRegenRemovableName() { }

	private float GetRemovalCost() { }

	public RegenRemovable GetSimRegenRemovable() { }

	public virtual bool IsConfirmable() { }

	public virtual bool IsDisabled() { }

	public virtual void OnButtonConfirm() { }

	private void OnCashChanged() { }

	private void OnTowersUnsuspended() { }

	public void SellRegenRemovable() { }

}

