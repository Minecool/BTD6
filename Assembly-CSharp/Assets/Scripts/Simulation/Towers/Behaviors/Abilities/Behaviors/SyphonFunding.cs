namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class SyphonFunding : AbilityBehavior
{
	public SyphonFundingModel syphonFundingModel; //Field offset: 0x68
	public int lastActive; //Field offset: 0x70
	public bool active; //Field offset: 0x74

	public SyphonFunding() { }

	public virtual void Activate() { }

	public void Deactivate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

