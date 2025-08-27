namespace Assets.Scripts.Models.Profile;

public abstract class CreatorModelWrapper : ICreatorModelWrapper
{

	public override string CreationId
	{
		 get { } //Length: 95
	}

	public override CustomMapModel CustomMapModel
	{
		 get { } //Length: 220
	}

	public abstract T Model
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public override string Name
	{
		 get { } //Length: 95
	}

	public override string SharedId
	{
		 get { } //Length: 92
	}

	protected CreatorModelWrapper`1() { }

	public abstract void Delete() { }

	public override string get_CreationId() { }

	public override CustomMapModel get_CustomMapModel() { }

	public abstract T get_Model() { }

	public override string get_Name() { }

	public override string get_SharedId() { }

	public abstract Task LoadAsync() { }

	public abstract Task SaveAsync() { }

	public abstract void set_Model(T value) { }

}

