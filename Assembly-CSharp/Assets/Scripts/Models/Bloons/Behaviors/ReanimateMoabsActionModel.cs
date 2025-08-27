namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(ReanimateMoabsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ReanimateMoabsActionModel : BloonBehaviorActionModel
{
	internal class PauseMovementMutator : BehaviorMutator
	{
		private readonly bool makeInvulnerable; //Field offset: 0x70

		public PauseMovementMutator(bool makeInvulnerable) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string reanimatedBloonTag = "Reanimated"; //Field offset: 0x0
	public float radius; //Field offset: 0x38
	[SerializeField]
	private float maxTimeSince; //Field offset: 0x3C
	public int maxTimeSinceFrames; //Field offset: 0x40
	public int maxRbe; //Field offset: 0x44
	public PrefabReference reanimationEffect; //Field offset: 0x48
	public float pauseMovementDuration; //Field offset: 0x50
	public float speedMultiplier; //Field offset: 0x54
	public float healthMultiplier; //Field offset: 0x58
	[SerializeField]
	private float timeUntilBloonsMove; //Field offset: 0x5C
	public int timeUntilBloonsMoveFrames; //Field offset: 0x60
	public String[] reanimationActionIds; //Field offset: 0x68
	public String[] postPopActionIds; //Field offset: 0x70
	public string bossName; //Field offset: 0x78
	public string miniMeModelId; //Field offset: 0x80
	public int minTimeUntilPostActionsFrames; //Field offset: 0x88
	private PauseMovementMutator pauseMutator; //Field offset: 0x90
	private PauseMovementMutator pauseAndInvulnerableMutator; //Field offset: 0x98

	public PauseMovementMutator PauseAndInvulnerableMutator
	{
		 get { } //Length: 103
	}

	public PauseMovementMutator PauseMutator
	{
		 get { } //Length: 103
	}

	public ReanimateMoabsActionModel() { }

	public ReanimateMoabsActionModel(string name, string actionId, float radius, float maxTimeSince, int maxRbe, PrefabReference reanimationEffect, float pauseMovementDuration, float speedMultiplier, float healthMultiplier, float timeUntilBloonsMove, String[] reanimationActionIds, String[] postPopActionIds, string bossName, string miniMeModelId, int minTimeUntilPostActionsFrames) { }

	public virtual Model Clone() { }

	public PauseMovementMutator get_PauseAndInvulnerableMutator() { }

	public PauseMovementMutator get_PauseMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

