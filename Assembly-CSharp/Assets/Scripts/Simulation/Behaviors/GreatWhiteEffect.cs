namespace Assets.Scripts.Simulation.Behaviors;

public class GreatWhiteEffect : RootBehavior
{
	private const int sameFrameAnimationBuffer = 4; //Field offset: 0x0
	public GreatWhiteEffectModel greatWhiteEffectModel; //Field offset: 0x58
	public int createdAt; //Field offset: 0x60
	private DisplayBehavior sharkDisplayBehavior; //Field offset: 0x68
	private Entity bloonDisplayEntity; //Field offset: 0x70
	private DisplayBehavior bloonDisplayBehavior; //Field offset: 0x78
	private BloonModel grabbedBloonModel; //Field offset: 0x80
	private int totalFramesToPopBloon; //Field offset: 0x88
	private Tower parentTower; //Field offset: 0x90
	private GreatWhiteLimitProjectile limitProjectile; //Field offset: 0x98
	private Vector2 createdAtPosition; //Field offset: 0xA0
	private Vector2 dragToPosition; //Field offset: 0xA8
	private bool hasExitAnimationPlayed; //Field offset: 0xB0
	private int timeOfLastThrashProjectileEmit; //Field offset: 0xB4
	private Emission emission; //Field offset: 0xB8
	private int blockedRound; //Field offset: 0xC0
	private int thrashingProjectileRateFrames; //Field offset: 0xC4

	public GreatWhiteEffect() { }

	private void FinishPoppingBloon() { }

	public bool HasEnded() { }

	public bool HasFinishedPoppingBloon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnLost() { }

	private void OnRoundEnd(int round) { }

	private void Process(int elapsed) { }

	public void SetGrabbedBloon(Tower parentTower, Bloon grabbedBloon, GreatWhiteLimitProjectile limitProjectile) { }

	private void UpdateBloonVisual() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdatePosition() { }

	private void UpdateRetreatEffect() { }

	private void UpdateThrashingProjectile() { }

}

