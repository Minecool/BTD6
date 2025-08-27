namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ParagonAssetSwap : TowerBehavior
{
	public ParagonAssetSwapModel paragonAssetSwapModel; //Field offset: 0x68

	public ParagonAssetSwap() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

