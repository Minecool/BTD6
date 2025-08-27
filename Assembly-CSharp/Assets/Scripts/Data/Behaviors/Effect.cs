namespace Assets.Scripts.Data.Behaviors;

[CreateAssetMenu(fileName = "Effect", menuName = "BTD6/Behaviors/Effect")]
public class Effect : EntityBehavior<EffectModel>
{
	public PrefabReference display; //Field offset: 0x28
	public float scale; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public Fullscreen fullscreen; //Field offset: 0x38
	public bool useCenterPosition; //Field offset: 0x3C
	public bool useTransformPosition; //Field offset: 0x3D
	public bool useTransfromRotation; //Field offset: 0x3E
	public bool destroyOnTransformDestroy; //Field offset: 0x3F
	public bool alwaysUseAge; //Field offset: 0x40
	public bool useRoundTime; //Field offset: 0x41

	public virtual EffectModel Def
	{
		 get { } //Length: 266
	}

	public Effect() { }

	public virtual EffectModel get_Def() { }

}

