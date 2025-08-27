namespace Assets.Scripts.Data.Gameplay;

public class BloonGroup
{
	public string bloon; //Field offset: 0x10
	public int count; //Field offset: 0x18
	public float start; //Field offset: 0x1C
	public float duration; //Field offset: 0x20

	public float End
	{
		 get { } //Length: 11
	}

	public BloonGroup() { }

	public void CalculateSpawnTiming(out int startFrames, out int offset, out int span) { }

	public float get_End() { }

}

