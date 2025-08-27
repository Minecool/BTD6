namespace Assets.Scripts.Simulation.GeraldoItems;

public class GeraldoItemBehavior
{
	public GeraldoItemBehaviorModel model; //Field offset: 0x10
	public Simulation sim; //Field offset: 0x18

	public GeraldoItemBehavior() { }

	public override void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public override bool CheckLocation(Vector2 location, int inputId) { }

	public Tower GetGeraldo(int inputId) { }

	public override void Initialise(GeraldoItemBehaviorModel model, Simulation sim) { }

	public override void OnDestroy() { }

}

