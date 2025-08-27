namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AttackBloonOnEntrance : TowerBehavior
{
	public AttackBloonOnEntranceModel attackBloonOnEntranceModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	public List<ObjectId> targettedBloons; //Field offset: 0x78

	public AttackBloonOnEntrance() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonEnterTrack(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

