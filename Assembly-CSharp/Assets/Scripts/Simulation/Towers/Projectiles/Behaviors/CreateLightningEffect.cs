namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateLightningEffect : ProjectileBehavior
{
	private CreateLightningEffectModel createLightModel; //Field offset: 0x68
	private readonly float smallLength; //Field offset: 0x70
	private readonly float mediumLength; //Field offset: 0x74

	public CreateLightningEffect() { }

	public void CreateEffect(Vector3 startPosition, Vector3 endPosition) { }

	private void GenerateEffectGivenDistanceBetween(float distance, out PrefabReference assetId, out float assetLength) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

