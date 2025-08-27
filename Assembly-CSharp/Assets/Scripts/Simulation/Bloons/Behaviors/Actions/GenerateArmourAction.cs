namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class GenerateArmourAction : BloonBehaviorAction
{
	public GenerateArmourActionModel generateArmourActionModel; //Field offset: 0x78

	public GenerateArmourAction() { }

	private void AddArmour() { }

	private void Bloon_OnArmourBroken(Bloon obj) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSpawn() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

