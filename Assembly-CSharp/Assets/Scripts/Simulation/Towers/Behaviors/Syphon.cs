namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Syphon : TowerBehavior
{
	public SyphonModel syphonModel; //Field offset: 0x68
	private SyphonFunding syphonFunding; //Field offset: 0x70

	public Syphon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonCreate(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

