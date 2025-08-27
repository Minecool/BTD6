namespace Assets.Scripts.Models.Map.Gizmos;

public class FireActivatedEventArgs : EventArgs
{
	public DarkDungeonsFire fire; //Field offset: 0x10
	public float duration; //Field offset: 0x14

	public FireActivatedEventArgs(DarkDungeonsFire fire, float duration) { }

}

