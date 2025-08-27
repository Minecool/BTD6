namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AbilityCooldownZone : BloonBehavior
{
	public AbilityCooldownZoneModel abilityCooldownZoneModel; //Field offset: 0x70

	public AbilityCooldownZone() { }

	private void AddDebuff(Tower tower) { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void RemoveDebuff(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private float ZoneRange() { }

}

