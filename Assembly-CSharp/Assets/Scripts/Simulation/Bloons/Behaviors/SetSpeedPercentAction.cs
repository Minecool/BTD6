namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SetSpeedPercentAction : BloonBehaviorAction
{
	public SetSpeedPercentActionModel setSpeedPercentActionModel; //Field offset: 0x78
	public bool isSpeedChanged; //Field offset: 0x80

	public SetSpeedPercentAction() { }

	private void ChangeSpeed() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

