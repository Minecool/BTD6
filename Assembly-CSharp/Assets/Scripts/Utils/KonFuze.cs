namespace Assets.Scripts.Utils;

[DataContract]
public class KonFuze
{
	internal class KonFuzeConverter : JsonConverter
	{

		public KonFuzeConverter() { }

		public virtual bool CanConvert(Type t) { }

		private double ParseOldFormat(JsonReader reader) { }

		public virtual object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	private static List<Double[]> bufferPool; //Field offset: 0x0
	private const int INITIAL_POOL_SIZE = 10; //Field offset: 0x0
	private const int BUFFER_SIZE = 10; //Field offset: 0x0
	public static bool HackDetected; //Field offset: 0x8
	private SeededRandom rng; //Field offset: 0x10
	private SeededRandom rngEncrypt; //Field offset: 0x18
	private long seedAtLastSet; //Field offset: 0x20
	private double honey; //Field offset: 0x28
	private double pot; //Field offset: 0x30
	private Double[] buffer; //Field offset: 0x38

	public double Value
	{
		 get { } //Length: 20
		 set { } //Length: 49
	}

	public bool ValueBool
	{
		 get { } //Length: 37
	}

	public float ValueFloat
	{
		 get { } //Length: 32
	}

	public int ValueInt
	{
		 get { } //Length: 32
	}

	public long ValueLong
	{
		 get { } //Length: 33
	}

	private static KonFuze() { }

	public KonFuze(double v = 0) { }

	public void Add(double v) { }

	public static Single[] ConvertToFloatArray(KonFuze[] a) { }

	public static Int32[] ConvertToIntArray(KonFuze[] a) { }

	public virtual bool Equals(object obj) { }

	public double get_Value() { }

	public bool get_ValueBool() { }

	public float get_ValueFloat() { }

	public int get_ValueInt() { }

	public long get_ValueLong() { }

	public string GetBufferAsDebugString() { }

	private long GetCurrentIndex() { }

	private int GetEncryptOffset() { }

	public virtual int GetHashCode() { }

	private int GetNextIndex() { }

	private Double[] GetPooledBuffer() { }

	private int GetSystemRandomizedSeed() { }

	public static bool op_Equality(KonFuze x, KonFuze y) { }

	public static KonFuze op_Implicit(bool v) { }

	public static KonFuze op_Implicit(string v) { }

	public static KonFuze op_Implicit(double v) { }

	public static KonFuze op_Implicit(int v) { }

	public static KonFuze op_Implicit(long v) { }

	public static KonFuze op_Implicit(float v) { }

	public static bool op_Inequality(KonFuze x, KonFuze y) { }

	protected override double Read() { }

	protected double ReadValue() { }

	private static void ReplenishPool() { }

	private void ReturnToPool(Double[] b) { }

	public void set_Value(double value) { }

	private void SetHoney(double v) { }

	private Double[] SwapPooledBuffer(Double[] b) { }

	public virtual string ToString() { }

	protected void Write(double v) { }

	private void WriteRemoved(double v) { }

}

