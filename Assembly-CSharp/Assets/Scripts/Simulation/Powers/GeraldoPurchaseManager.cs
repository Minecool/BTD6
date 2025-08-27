namespace Assets.Scripts.Simulation.Powers;

public class GeraldoPurchaseManager : RootBehavior
{
	private GeraldoItem currentlyPlacingItem; //Field offset: 0x58

	public GeraldoPurchaseManager() { }

	public void Activate(Vector2 location, ref GeraldoItemModel geraldoItemModel, int inputId, Simulation sim) { }

	public void Cancel() { }

	public bool CanPurchase(GeraldoItemModel geraldoItemModel, int inputId, Simulation sim) { }

	public bool CheckLocation(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	private GeraldoItem GetInstance(GeraldoItemModel geraldoItemModel) { }

	public void StartPlacing(GeraldoItemModel geraldoItemModel) { }

	public void StopPlacing() { }

}

