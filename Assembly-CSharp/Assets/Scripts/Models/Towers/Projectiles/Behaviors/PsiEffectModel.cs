namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(PsiEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PsiEffectModel : ProjectileBehaviorWithOverlayModel
{
	internal class PsiBloonMutator : BehaviorMutator
	{
		public PsiBloonBehaviorModel psiBloonBehaviorModel; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78

		public PsiBloonMutator(PsiBloonBehaviorModel psiBloonBehaviorModel, string overlayType) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const int endOfRoundFramesCap = 180; //Field offset: 0x0
	public const string mutatorId = "PsiBloonMutator"; //Field offset: 0x0
	public int damagePerTick; //Field offset: 0x40
	public float tickRate; //Field offset: 0x44
	public PsiBloonBehaviorModel bloonBehavior; //Field offset: 0x48
	public float trembleSpeed; //Field offset: 0x50
	public float trembleDistanceMin; //Field offset: 0x54
	public float trembleDistanceMax; //Field offset: 0x58
	public float trembleTimeThresholdMin; //Field offset: 0x5C
	public float trembleTimeThresholdMax; //Field offset: 0x60
	public ProjectileModel projectileOnBloonDestroyModel; //Field offset: 0x68
	public EffectModel effectOnBloonDestroyModel; //Field offset: 0x70
	public int superCeramicPenalty; //Field offset: 0x78
	[SerializeField]
	private float maxDuration; //Field offset: 0x7C
	public int maxDurationFrames; //Field offset: 0x80
	public EmissionModel emissionOnBloonDestroy; //Field offset: 0x88
	private Dictionary<ObjectId, PsiBloonMutator> mutators; //Field offset: 0x90

	public PsiEffectModel(string name, string overlayType, int damagePerTick, float tickRate, float trembleSpeed, float trembleDistanceMin, float trembleDistanceMax, float trembleTimeThresholdMin, float trembleTimeThresholdMax, ProjectileModel projectileOnBloonDestroyModel, EffectModel effectOnBloonDestroyModel, int superCeramicPenalty, float maxDuration, EmissionModel emissionOnBloonDestroy) { }

	public virtual Model Clone() { }

	public int GetFramesUntilBloonCompletelyPopped(Simulation sim, Bloon bloon) { }

	public PsiBloonMutator GetMutatorForTower(Tower tower) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

