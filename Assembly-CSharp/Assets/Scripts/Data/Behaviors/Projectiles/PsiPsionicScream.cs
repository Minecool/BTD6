namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "PsiPsionicScream", menuName = "BTD6/Behaviors/Projectiles/PsiPsionicScream")]
public class PsiPsionicScream : ProjectileBehavior
{
	public PsiEffect psiEffect; //Field offset: 0x30
	public string overlayType; //Field offset: 0x38
	public float psiEffectChance; //Field offset: 0x40
	public float distractDistanceMin; //Field offset: 0x44
	public float distractDistanceMax; //Field offset: 0x48
	public float speedMultiplier; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 356
	}

	public PsiPsionicScream() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

