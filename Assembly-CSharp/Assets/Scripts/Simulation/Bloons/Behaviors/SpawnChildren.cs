namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SpawnChildren : BloonBehavior
{
	private const float distanceAcrossChildren = 26.7; //Field offset: 0x0
	private const float minDistanceBetweenChildren = 8.6; //Field offset: 0x0
	public SpawnChildrenModel spawnChildrenModel; //Field offset: 0x70
	private readonly TransformModel newChildTransformModel; //Field offset: 0x78

	public SpawnChildren() { }

	public void CreatedChildren(DamageResult damageResult, List<Bloon> childernCreatedIn, bool blockSpawnChildren) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

