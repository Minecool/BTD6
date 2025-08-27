namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(JungleVineEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class JungleVineEffectModel : ProjectileBehaviorModel
{
	public PrefabReference displayFrontAssetId; //Field offset: 0x38
	public PrefabReference displayBackAssetId; //Field offset: 0x40
	public Fullscreen fullscreen; //Field offset: 0x48
	public float destroyAfterPopTime; //Field offset: 0x4C
	public SoundModel sound1; //Field offset: 0x50
	public SoundModel sound2; //Field offset: 0x58
	public SoundModel sound3; //Field offset: 0x60
	public SoundModel sound4; //Field offset: 0x68
	public AgeingDestroyModel ageingDestroyModel; //Field offset: 0x70
	public DisplayModel backEffectDisplayModel; //Field offset: 0x78
	public DisplayModel bloonEffectDisplayModel; //Field offset: 0x80
	public DisplayModel frontEffectDisplayModel; //Field offset: 0x88

	public JungleVineEffectModel(string name, PrefabReference displayFrontAssetId, PrefabReference displayBackAssetId, Fullscreen fullscreen, float destroyAfterPopTime, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

