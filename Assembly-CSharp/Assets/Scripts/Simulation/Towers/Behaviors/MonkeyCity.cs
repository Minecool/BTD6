namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeyCity : TowerBehavior
{
	public MonkeyCityModel cityModel; //Field offset: 0x68
	private int roundCount; //Field offset: 0x70

	public MonkeyCity() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnRoundPassed(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

