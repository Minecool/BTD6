namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardEditorPowerPurchaseButton : StandardPowerButton
{

	public StandardEditorPowerPurchaseButton() { }

	public virtual int GetUseCount() { }

	public virtual bool IsAvailable() { }

	protected virtual bool ModeDisabled() { }

	protected virtual bool RoundDisabled() { }

	public virtual void StartDragging() { }

}

