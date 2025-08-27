namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(SwitchDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwitchDisplayModel : AbilityBehaviorModel
{
	public PrefabReference display; //Field offset: 0x30
	public bool excludeSubTowers; //Field offset: 0x38
	public EffectModel createEffectOnSwitchBackModel; //Field offset: 0x40
	public bool resetOnDefeatScreen; //Field offset: 0x48
	public int animationStateOnActivate; //Field offset: 0x4C
	[SerializeField]
	private float lifespan; //Field offset: 0x50
	public int lifespanFrames; //Field offset: 0x54

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public SwitchDisplayModel(string name, float lifespan, bool excludeSubTowers, PrefabReference display, EffectModel createEffectOnSwitchBackModel, bool resetOnDefeatScreen, int animationStateOnActivate) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

