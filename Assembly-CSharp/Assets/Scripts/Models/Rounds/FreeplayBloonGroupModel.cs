namespace Assets.Scripts.Models.Rounds;

public class FreeplayBloonGroupModel : Model
{
	internal struct Bounds : IEquatable<Bounds>
	{
		public int lowerBounds; //Field offset: 0x0
		public int upperBounds; //Field offset: 0x4

		public override bool Equals(Bounds other) { }

	}

	private BloonEmissionModel[] bloonEmissions_; //Field offset: 0x30
	public float score; //Field offset: 0x38
	public Bounds[] bounds; //Field offset: 0x40
	[SerializeField]
	private BloonGroupModel group; //Field offset: 0x48

	public BloonEmissionModel[] bloonEmissions
	{
		 get { } //Length: 49
	}

	public FreeplayBloonGroupModel(string name, float score, Bounds[] bounds, BloonGroupModel group) { }

	public float CalculateScore(GameModel model) { }

	public virtual Model Clone() { }

	public BloonEmissionModel[] get_bloonEmissions() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

