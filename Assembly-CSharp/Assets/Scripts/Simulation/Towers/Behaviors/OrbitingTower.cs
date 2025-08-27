namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class OrbitingTower : TowerBehavior
{
	public OrbitingTowerModel orbitingTowerModel; //Field offset: 0x68
	private Vector2 currentDirection; //Field offset: 0x70
	private Tower parentTower; //Field offset: 0x78
	private TransformBehavior parentTransform; //Field offset: 0x80

	public OrbitingTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

