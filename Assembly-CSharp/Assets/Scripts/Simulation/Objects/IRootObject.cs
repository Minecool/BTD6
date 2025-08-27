namespace Assets.Scripts.Simulation.Objects;

public interface IRootObject
{

	public ObjectId Id
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsDestroyed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsPaused
	{
		 get { } //Length: 0
	}

	public int PauseCount
	{
		 get { } //Length: 0
	}

	public void Cleanup() { }

	public void Create(Simulation sim) { }

	public void Destroy() { }

	public ObjectId get_Id() { }

	public bool get_IsDestroyed() { }

	public bool get_IsPaused() { }

	public int get_PauseCount() { }

	public void set_Id(ObjectId value) { }

	public void set_IsDestroyed(bool value) { }

}

