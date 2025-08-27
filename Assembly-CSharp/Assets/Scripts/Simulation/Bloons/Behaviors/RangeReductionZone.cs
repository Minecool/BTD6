namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class RangeReductionZone : BloonBehavior
{
	public RangeReductionZoneModel rangeReductionModel; //Field offset: 0x70

	public RangeReductionZone() { }

	private void AddDebuff(Tower tower) { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void RemoveDebuff(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private float ZoneRange() { }

}

