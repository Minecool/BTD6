namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class PsiPsionicScream : ProjectileBehavior
{
	public PsiPsionicScream parent; //Field offset: 0x88
	public PsiEffect psiEffect; //Field offset: 0x90
	public PsiEffect expPsiEffect; //Field offset: 0x98
	public string overlayType; //Field offset: 0xA0
	public string expOverlayType; //Field offset: 0xA8
	public float psiEffectChance; //Field offset: 0xB0
	public string expPsiEffectChance; //Field offset: 0xB8
	public float distractDistanceMin; //Field offset: 0xC0
	public string expDistractDistanceMin; //Field offset: 0xC8
	public float distractDistanceMax; //Field offset: 0xD0
	public string expDistractDistanceMax; //Field offset: 0xD8
	public float speedMultiplier; //Field offset: 0xE0
	public string expSpeedMultiplier; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 374
	}

	public PsiPsionicScream() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

