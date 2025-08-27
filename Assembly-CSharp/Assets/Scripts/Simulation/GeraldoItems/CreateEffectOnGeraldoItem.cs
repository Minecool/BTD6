namespace Assets.Scripts.Simulation.GeraldoItems;

public class CreateEffectOnGeraldoItem : GeraldoItemBehavior
{

	public CreateEffectOnGeraldoItem() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

}

