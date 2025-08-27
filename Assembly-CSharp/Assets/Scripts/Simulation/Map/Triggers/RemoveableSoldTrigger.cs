namespace Assets.Scripts.Simulation.Map.Triggers;

public class RemoveableSoldTrigger : MapTrigger
{
	public string removableName; //Field offset: 0x80

	public RemoveableSoldTrigger() { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnRemoveableSold(Removeable removable) { }

}

