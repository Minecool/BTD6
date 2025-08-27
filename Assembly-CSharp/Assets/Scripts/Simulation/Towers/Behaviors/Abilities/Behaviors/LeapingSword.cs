namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class LeapingSword : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__14_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <GetTarget>b__14_1(Bloon bloon) { }

	}

	public LeapingSwordModel leapingSwordModel; //Field offset: 0x68
	private int landAt; //Field offset: 0x70
	private int createFinishingEffectAt; //Field offset: 0x74
	private int finishAt; //Field offset: 0x78
	private Bloon jumpingAtBloon; //Field offset: 0x80
	private Vector3 jumpingAtPosition; //Field offset: 0x88
	private List<Attack> pausedAttacks; //Field offset: 0x98
	private Emission emission; //Field offset: 0xA0
	private Entity landingEffect; //Field offset: 0xA8
	private bool isPendingStart; //Field offset: 0xB0
	private Vector3 pendingPosition; //Field offset: 0xB4
	private List<Projectile> projectiles; //Field offset: 0xC0

	public LeapingSword() { }

	[CompilerGenerated]
	private bool <GetTarget>b__14_0(Bloon bloon) { }

	[CompilerGenerated]
	private bool <GetTarget>b__14_2(Bloon bloon) { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void CreateFinishingEffect() { }

	private void Finish() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private Bloon GetTarget() { }

	private void HideTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private void Land() { }

	private void PlayLandingSound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartJumpTo(Vector3 to, Bloon bloon = null) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

