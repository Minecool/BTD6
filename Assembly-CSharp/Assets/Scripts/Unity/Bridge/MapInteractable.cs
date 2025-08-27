namespace Assets.Scripts.Unity.Bridge;

public abstract class MapInteractable : Selectable
{

	protected MapInteractable() { }

	public override void AttachUpdateTextAction(Action action) { }

	public override void DetachUpdateTextAction(Action action) { }

	public abstract string GetAnalyticsKey() { }

	public override string GetButtonText() { }

	public override Vector3 GetDisplayPosition() { }

	public override bool IsConfirmable() { }

	public override bool IsDisabled() { }

	public override void OnButtonConfirm() { }

}

