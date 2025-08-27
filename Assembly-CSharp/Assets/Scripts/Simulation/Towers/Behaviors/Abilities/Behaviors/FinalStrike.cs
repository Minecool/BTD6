namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class FinalStrike : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__17_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__17_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <UpdateMissileLaunching>b__17_0(Bloon possibleTarget) { }

		internal float <UpdateMissileLaunching>b__17_1(Bloon possibleTarget) { }

	}

	public FinalStrikeModel finalStrikeModel; //Field offset: 0x68
	private int countingFrom; //Field offset: 0x70
	private int currentMissileIndex; //Field offset: 0x74
	private int lastMissileFiredAt; //Field offset: 0x78
	private Emission emission; //Field offset: 0x80
	private List<ObjectId> targettedBloons; //Field offset: 0x88
	private Entity effectDuringCountdown; //Field offset: 0x90

	public FinalStrike() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void EndCountdown() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private bool IsBloonValid(Bloon bloon) { }

	private void LaunchMissile(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	private void PlayCountDownSound(int limitCounter) { }

	private void PlayLaunchSound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void ShowTextEffect(string text) { }

	private void StartCountdown() { }

	private void UpdateCountdownTextEffect() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateMissileLaunching() { }

}

