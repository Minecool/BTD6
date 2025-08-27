namespace Assets.Scripts.Simulation.SMath;

[DefaultMember("Item")]
public class TriDiagonalMatrixF
{
	public Single[] A; //Field offset: 0x10
	public Single[] B; //Field offset: 0x18
	public Single[] C; //Field offset: 0x20

	public float Item
	{
		 get { } //Length: 90
		 set { } //Length: 164
	}

	public int N
	{
		 get { } //Length: 18
	}

	public TriDiagonalMatrixF(int n) { }

	public float get_Item(int row, int col) { }

	public int get_N() { }

	public void set_Item(int row, int col, float value) { }

	public Single[] Solve(Single[] d) { }

}

