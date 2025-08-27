namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class JungleVineEffect : ProjectileBehavior
{
	private static String[] bloonTypes; //Field offset: 0x0
	private JungleVineEffectModel jungleVineEffectModel; //Field offset: 0x68
	private Entity effect; //Field offset: 0x70
	private DisplayBehavior backEffectDisplayBehavior; //Field offset: 0x78
	private DisplayBehavior bloonEffectDisplayBehavior; //Field offset: 0x80
	private DisplayBehavior frontEffectDisplayBehavior; //Field offset: 0x88
	private int currentDisplayIndex; //Field offset: 0x90
	private int degradeStep; //Field offset: 0x94
	private int stepCount; //Field offset: 0x98
	private bool isCamo; //Field offset: 0x9C
	private bool regrow; //Field offset: 0x9D
	private float duration; //Field offset: 0xA0
	private int effectFrames; //Field offset: 0xA4

	private static JungleVineEffect() { }

	public JungleVineEffect() { }

	public virtual void Collide(Bloon bloon) { }

	private Entity CreateEffect(Vector3 position) { }

	private PrefabReference getNewDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

