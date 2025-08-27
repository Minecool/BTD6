namespace Assets.Scripts.Simulation.Display;

public interface IDisplayNode
{

	public UnityDisplayNode Graphic
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public PrefabReference ObjectId
	{
		 get { } //Length: 0
	}

	public DisplayNodeState State
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public UnityDisplayNode get_Graphic() { }

	public PrefabReference get_ObjectId() { }

	public DisplayNodeState get_State() { }

	public void set_Graphic(UnityDisplayNode value) { }

	public void set_State(DisplayNodeState value) { }

}

