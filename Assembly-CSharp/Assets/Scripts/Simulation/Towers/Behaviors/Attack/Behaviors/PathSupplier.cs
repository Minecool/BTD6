namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PathSupplier : TargetCamo
{
	public TargetType targetType; //Field offset: 0x78
	private AirUnit airUnit; //Field offset: 0x90
	private bool checkIfAirUnit; //Field offset: 0x98
	public bool reverse; //Field offset: 0x99
	private int timeOfLastReverse; //Field offset: 0x9C

	public PathSupplier() { }

	[CompilerGenerated]
	private float <GetTargets>b__13_0(Target target) { }

	public override Vector2[] GetPath() { }

	public override float GetPathLength() { }

	public override Vector2 GetPathPosition(float t) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected override bool IsBloonValid(Bloon bloon) { }

	protected override bool IsBloonVisible(Bloon bloon) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public override bool RecalculatePathSpeed() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public override bool UseTowerPosition() { }

}

