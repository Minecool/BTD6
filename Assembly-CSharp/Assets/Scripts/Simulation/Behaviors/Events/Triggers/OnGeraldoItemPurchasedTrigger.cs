namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnGeraldoItemPurchasedTrigger : EntityTrigger
{
	public OnGeraldoItemPurchasedTriggerModel behaviorModel; //Field offset: 0x70

	public OnGeraldoItemPurchasedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(GeraldoItemModel geraldoItemModel, Vector2 position, int inputId) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

