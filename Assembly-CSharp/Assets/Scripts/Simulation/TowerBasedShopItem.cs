namespace Assets.Scripts.Simulation;

public class TowerBasedShopItem
{
	public Simulation sim; //Field offset: 0x10

	public TowerBasedShopItem() { }

	public override void Activate(Vector2 location, int inputId) { }

	public override bool CheckLocation(Vector2 location, int inputId) { }

	public override void Destroy() { }

	public override void Initialise(Model model, Simulation sim) { }

}

