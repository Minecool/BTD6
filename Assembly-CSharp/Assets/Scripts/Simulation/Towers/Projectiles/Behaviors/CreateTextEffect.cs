namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateTextEffect : ProjectileBehavior
{
	public const float TOP_BOARDER_WIDTH = -50; //Field offset: 0x0
	public const float LEFT_AND_RIGHT_BOARDER_WIDTH = -20; //Field offset: 0x0
	public CreateTextEffectModel createTextEffectModel; //Field offset: 0x68

	public CreateTextEffect() { }

	public void CreateText(string content) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

