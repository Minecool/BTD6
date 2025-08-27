namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class HeatItUpDamageBuff : ProjectileBehavior
{
	public HeatItUpDamageBuffModel heatItUpDamageBuffModel; //Field offset: 0x68

	public HeatItUpDamageBuff() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

