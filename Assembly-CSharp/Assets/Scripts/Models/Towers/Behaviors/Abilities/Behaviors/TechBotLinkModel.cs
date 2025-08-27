namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(TechBotLink), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TechBotLinkModel : AbilityBehaviorModel
{
	public static readonly String[] towerBanList; //Field offset: 0x0
	public static readonly String[] abilityBanList; //Field offset: 0x8
	public PrefabReference selectionObjectPath; //Field offset: 0x30
	public PrefabReference isSelectableGameObject; //Field offset: 0x38
	public AudioClipReference activateSound; //Field offset: 0x40
	public AudioClipReference confirmSound; //Field offset: 0x48
	public EffectModel activatedTowerAbilityEffectModel; //Field offset: 0x50
	public PrefabReference lineDisplayPath; //Field offset: 0x58
	public float lineDotOffset; //Field offset: 0x60
	public float lineDotSpacing; //Field offset: 0x64
	public int activateAnimationState; //Field offset: 0x68
	public int linkAnimationState; //Field offset: 0x6C
	public int idleAnimationState; //Field offset: 0x70
	public EffectModel travelEffectModel; //Field offset: 0x78
	public float travelEffectSpeed; //Field offset: 0x80
	public bool ambushTechActive; //Field offset: 0x84

	private static TechBotLinkModel() { }

	public TechBotLinkModel(string name, PrefabReference selectionObjectPath, PrefabReference isSelectableGameObject, AudioClipReference activateSound, AudioClipReference confirmSound, EffectModel activatedTowerAbilityEffectModel, PrefabReference lineDisplayPath, float lineDotOffset, float lineDotSpacing, int activateAnimationState, int linkAnimationState, int idleAnimationState, EffectModel travelEffectModel, float travelEffectSpeed, bool ambushTechActive) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

