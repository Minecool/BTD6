namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnPlace : TowerBehavior
{
	public CreateEffectOnPlaceModel createEffectOnPlace; //Field offset: 0x68

	public CreateEffectOnPlace() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

