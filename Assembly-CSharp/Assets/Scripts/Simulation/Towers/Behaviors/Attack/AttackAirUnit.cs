namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack;

public class AttackAirUnit : Attack
{
	public AttackAirUnitModel attackAirUnitModel; //Field offset: 0x110
	private AirUnit airUnit; //Field offset: 0x118
	private DisplayBehavior display; //Field offset: 0x120

	public AttackAirUnit() { }

	public DisplayBehavior Display() { }

	public virtual void Initialise(Entity targetLocal, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

