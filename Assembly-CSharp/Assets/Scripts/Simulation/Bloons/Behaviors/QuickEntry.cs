namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class QuickEntry : BloonBehavior
{
	public QuickEntryModel quickEntryModel; //Field offset: 0x70
	private bool hasRemovedSpeedBoost; //Field offset: 0x78

	public QuickEntry() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSpawn() { }

	private void Process(int elasped) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

