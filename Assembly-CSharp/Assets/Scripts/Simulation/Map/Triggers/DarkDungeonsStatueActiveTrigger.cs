namespace Assets.Scripts.Simulation.Map.Triggers;

public class DarkDungeonsStatueActiveTrigger : MapTrigger
{
	private DarkDungeonsStatueActiveTriggerModel statueActiveTriggerModel; //Field offset: 0x80

	public DarkDungeonsStatueActiveTrigger() { }

	public virtual void DeInit() { }

	private void FireTrigger(object sender, EventArgs e) { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

