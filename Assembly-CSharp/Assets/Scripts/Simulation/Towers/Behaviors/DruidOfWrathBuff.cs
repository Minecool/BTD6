namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class DruidOfWrathBuff : TowerBehavior
{
	public DruidOfWrathBuffModel druidOfWrathBuffModel; //Field offset: 0x68

	public DruidOfWrathBuff() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundStart(int roundNo) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

