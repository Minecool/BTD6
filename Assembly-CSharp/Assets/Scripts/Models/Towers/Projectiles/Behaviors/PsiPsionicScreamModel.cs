namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(PsiPsionicScream), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PsiPsionicScreamModel : ProjectileBehaviorWithOverlayModel
{
	public PsiEffectModel psiEffectModel; //Field offset: 0x40
	public float psiEffectChance; //Field offset: 0x48
	public float distractDistanceMin; //Field offset: 0x4C
	public float distractDistanceMax; //Field offset: 0x50
	public float speedMultiplier; //Field offset: 0x54
	private Dictionary<ObjectId, AddBehaviorToBloonMutator> windMutators; //Field offset: 0x58
	private Dictionary<ObjectId, PsiBloonMutator> psiEffectMutators; //Field offset: 0x60

	public PsiPsionicScreamModel(string name, PsiEffectModel psiEffectModel, string overlayType, float psiEffectChance, float distractDistanceMin, float distractDistanceMax, float speedMultiplier) { }

	public virtual Model Clone() { }

	public PsiBloonMutator GetPsiEffectMutatorForTower(Tower tower) { }

	public AddBehaviorToBloonMutator GetWindMutatorForTower(Tower tower) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

