namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SpawnBloonsAction : BloonBehaviorAction
{
	public SpawnBloonsActionModel modl; //Field offset: 0x78
	private readonly TransformModel blankChildTrans; //Field offset: 0x80
	private int animIndex; //Field offset: 0x88
	private int moabAnimIndex; //Field offset: 0x8C
	private List<Int32> spawnTimes; //Field offset: 0x90
	private BloonModel childModel; //Field offset: 0x98
	private string animationCurveId; //Field offset: 0xA0

	public SpawnBloonsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

	private void SpawnBloon(float distAlongPath) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

