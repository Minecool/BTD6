namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ParagonOverlaySwap : TowerBehavior
{
	public ParagonOverlaySwapModel paragonOverlaySwapModel; //Field offset: 0x68

	public ParagonOverlaySwap() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

