namespace Assets.Scripts.Simulation.GeraldoItems;

public class GeraldoItem : TowerBasedShopItem
{
	public GeraldoItemModel geraldoItemModel; //Field offset: 0x18
	public List<GeraldoItemBehavior> behaviors; //Field offset: 0x20

	public GeraldoItem() { }

	public virtual void Activate(Vector2 location, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	public virtual void Destroy() { }

	public virtual void Initialise(Model model, Simulation sim) { }

}

