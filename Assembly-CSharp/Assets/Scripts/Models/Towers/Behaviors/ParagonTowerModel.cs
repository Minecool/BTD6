namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ParagonTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParagonTowerModel : TowerBehaviorModel
{
	internal class PowerDegreeMutator : BehaviorMutator
	{
		public readonly int degree; //Field offset: 0x70
		public readonly float attackCooldownReductionPercent; //Field offset: 0x74
		public readonly float percentPierceUp; //Field offset: 0x78
		public readonly float additionalPierceUp; //Field offset: 0x7C
		public readonly float percentDamageUp; //Field offset: 0x80
		public readonly float additionalDamageUp; //Field offset: 0x84
		public readonly int displayDegreeIndex; //Field offset: 0x88
		public readonly AssetPathModel displayDegree; //Field offset: 0x90
		public readonly bool changeAttackDisplay; //Field offset: 0x98
		public readonly bool changeAirUnitDisplay; //Field offset: 0x99
		public readonly float bonusBossDamagePercent; //Field offset: 0x9C

		public PowerDegreeMutator(int degree, float attackCooldownReductionPercent, float percentPierceUp, float additionalPierceUp, float percentDamageUp, float additionalDamageUp, int displayDegreeIndex, AssetPathModel displayDegree, bool changeAttackDisplay, bool changeAirUnitDisplay, float bonusBossDamagePercent) { }

		private bool CanApplyAssetSwap(ParagonAssetSwapModel paragonAssetSwapModel) { }

		private bool CanApplyAssetSwap(ParagonOverlaySwapModel paragonOverlaySwapModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

		private void MutateTower(TowerModel tower) { }

	}

	public static readonly string mutatorId; //Field offset: 0x0
	public AssetPathModel[] displayDegreePaths; //Field offset: 0x30
	public EffectModel effectDuringModel; //Field offset: 0x38
	public EffectModel endEffectModel; //Field offset: 0x40
	public EffectModel investmentEffectModel; //Field offset: 0x48
	public EffectModel investmentEffectTier5Model; //Field offset: 0x50
	public float effectMinScale; //Field offset: 0x58
	public float effectMaxScale; //Field offset: 0x5C
	public float investStartScale; //Field offset: 0x60
	public float investEndScale; //Field offset: 0x64
	[SerializeField]
	private float inactiveDuration; //Field offset: 0x68
	public int inactiveDurationFrames; //Field offset: 0x6C
	public int endAnimationState; //Field offset: 0x70
	[SerializeField]
	private float effectsStartMovingAt; //Field offset: 0x74
	public int effectsStartMovingAtFrame; //Field offset: 0x78
	[SerializeField]
	private float effectsDontStartMovingAt; //Field offset: 0x7C
	public int effectsDontStartMovingAtFrame; //Field offset: 0x80
	public float investmentEffectHeight; //Field offset: 0x84
	public float investmentEffectDestYOffset; //Field offset: 0x88
	public PrefabReference degreeTextEffectId; //Field offset: 0x90
	public float degreeTextEffectLifespan; //Field offset: 0x98
	public bool changeAttackDisplay; //Field offset: 0x9C
	public bool changeAirUnitDisplay; //Field offset: 0x9D
	[SerializeField]
	private float effectScaleDownTime; //Field offset: 0xA0
	public int effectScaleDownTimeFrames; //Field offset: 0xA4
	public float investmentEffectExponent; //Field offset: 0xA8
	public bool repositionStackedTowers; //Field offset: 0xAC
	public SoundModel sound; //Field offset: 0xB0
	public SoundModel altSound; //Field offset: 0xB8

	private static ParagonTowerModel() { }

	public ParagonTowerModel(string name, AssetPathModel[] displayDegreePaths, EffectModel effectDuringModel, EffectModel endEffectModel, EffectModel investmentEffectModel, EffectModel investmentEffectTier5Model, float effectMinScale, float effectMaxScale, float investStartScale, float investEndScale, float inactiveDuration, int endAnimationState, float effectsStartMovingAt, float effectsDontStartMovingAt, float investmentEffectHeight, float investmentEffectDestYOffset, PrefabReference degreeTextEffectId, float degreeTextEffectLifespan, bool changeAttackDisplay, bool changeAirUnitDisplay, float effectScaleDownTime, float investmentEffectExponent, bool repositionStackedTowers, SoundModel sound, SoundModel altSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

