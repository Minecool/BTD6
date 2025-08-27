namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateRopeEffect : ProjectileBehavior
{
	private static TransformModel zeroTransformModel; //Field offset: 0x0
	public CreateRopeEffectModel createRopeEffectModel; //Field offset: 0x68
	public Vector3Boxed scale; //Field offset: 0x70
	public FloatBoxed rotation; //Field offset: 0x78
	public Vector2 origin; //Field offset: 0x80
	public Vector2 direction; //Field offset: 0x88
	private Entity ropeEffect; //Field offset: 0x90
	public Vector2 location; //Field offset: 0x98
	private Entity ropeEnd; //Field offset: 0xA0
	public Vector2 destinationOffset; //Field offset: 0xA8
	public Entity effectAtOrigin; //Field offset: 0xB0

	private static CreateRopeEffect() { }

	public CreateRopeEffect() { }

	public virtual void Attatched() { }

	private void BuildMesh() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void ReBuildLine() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

