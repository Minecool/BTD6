namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class BrickellFreezeOtherMines : ProjectileBehavior
{
	public BrickellFreezeOtherMinesModel brickellFreezeOtherMinesModel; //Field offset: 0x68
	public int startCollidingAtFrame; //Field offset: 0x70
	private bool initialised; //Field offset: 0x74

	public BrickellFreezeOtherMines() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostAttached() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

