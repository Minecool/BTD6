namespace Assets.Scripts.Data.Gameplay;

public interface IRoundSet
{

	public float Scale
	{
		 get { } //Length: 0
	}

	public float get_Scale() { }

	public RoundData GetRound(int idx) { }

}

