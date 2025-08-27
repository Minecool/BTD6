namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MagusPerfectusGraveyardStateManager : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, Boolean> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_DarkPhoenix>b__5_0(Tower x) { }

	}

	internal enum GraveyardManaState
	{
		Consuming = 0,
		Generating = 1,
		DrainingOverTime = 2,
		Invalid = 3,
	}

	private const int roundsBeforeGraveyardDecay = 10; //Field offset: 0x0
	private readonly TSMInfoModel newInfo; //Field offset: 0x68
	private SimNecromancerGraveyardManager simGraveyardManager; //Field offset: 0x70
	private Dictionary<GraveyardManaState, List`1<Attack>> graveyardStateAttacks; //Field offset: 0x78
	private List<Attack> disabledAttacks; //Field offset: 0x80
	private GraveyardManaState graveyardManaState; //Field offset: 0x88
	private int explosionRemainingFrames; //Field offset: 0x8C
	private int drainingBeamToggledAt; //Field offset: 0x90
	public MagusPerfectusGraveyardStateManagerModel stateManagerModel; //Field offset: 0x98
	public PhoenixRebirth phoenixRebirth; //Field offset: 0xA0
	private bool isPhoenixPaused; //Field offset: 0xA8
	private Entity graveyardThresholdEffect; //Field offset: 0xB0
	private bool wasMaxGraveyardBloonsAvailable; //Field offset: 0xB8
	private int registeredNecroIdx; //Field offset: 0xBC

	public int AvailableMana
	{
		 get { } //Length: 192
	}

	public bool CanGenerateMana
	{
		 get { } //Length: 62
	}

	public Tower DarkPhoenix
	{
		 get { } //Length: 296
	}

	public int MaxMana
	{
		 get { } //Length: 29
	}

	private NecroData ParagonNecroData
	{
		private get { } //Length: 81
	}

	public MagusPerfectusGraveyardStateManager() { }

	[CompilerGenerated]
	private void <SyncAttacksToGraveyardState>b__41_0(Attack x) { }

	[CompilerGenerated]
	private void <SyncAttacksToGraveyardState>b__41_1(Attack x) { }

	public void ArcaneMetamorphosisEnded() { }

	public void ArcaneMetamorphosisStarted() { }

	public virtual void Attatched() { }

	public bool CanConsumeMana(int amount) { }

	public bool ConsumeMana(int amount, bool showTextEffect) { }

	public void GenerateMana(int amount, int roundsUntilDecay) { }

	public int get_AvailableMana() { }

	public bool get_CanGenerateMana() { }

	public Tower get_DarkPhoenix() { }

	public int get_MaxMana() { }

	private NecroData get_ParagonNecroData() { }

	public static MagusPerfectusGraveyardStateManager GetOnTower(Tower tower) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsMaxGraveyardBloonsAvailable() { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	private void PauseAttack(Attack attack) { }

	private void PlayStateSound() { }

	private void Process(int elapsed) { }

	private void ResumeAttack(Attack attack) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private GraveyardManaState StringToGraveyardState(string value) { }

	private void SwitchGraveyardManaState(GraveyardManaState newState) { }

	private void SyncAttacksToGraveyardState() { }

	public int TriggerManaExplosion(float duration) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateGraveyardFillThreshold() { }

	private void UpdatePhoenixAttackState() { }

}

