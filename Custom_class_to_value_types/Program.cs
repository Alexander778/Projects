using System;

namespace ConsoleApplication2
{

	/// Class that implements IConvertible
	class Complex : IConvertible
	{
		double real;
		double imaginary;

		public Complex(double real, double imaginary)
		{
            this.real = real;
            this.imaginary = imaginary;
		}

		public TypeCode GetTypeCode()
		{
			return TypeCode.Object;
		}

        //Ненужная часть. Зачем её нужно прописывать, если она не нужна? Это же неудобно
        public bool ToBoolean(IFormatProvider provide)
        {
            throw new InvalidCastException();
        }
        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }
        public char ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public sbyte ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
        public short ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public int ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public long ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public ushort ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public uint ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public ulong ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public float ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public decimal ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		public Object ToType(Type conversionType, IFormatProvider provider)
		{
			throw new InvalidCastException();
		}
		// Ненужная часть

        //Рабочая!
        public double ToDouble(IFormatProvider provider)
        {
            return this.real;
        }
        public string ToString(IFormatProvider provider)
        {
            return this.real.ToString() + (this.imaginary >= 0 ? "+" : "") + this.imaginary.ToString() + "i";
        }
        //!
	}

	
	class Class1
	{
		static void Main(string[] args)
		{
            Complex c = new Complex(10, -3);
            Console.WriteLine("Conversion to string {0}", Convert.ToString(c));
            Console.WriteLine("Conversion to double {0}", Convert.ToDouble(c));

            c = new Complex(43, 3);
			Console.WriteLine("Conversion to string {0}", Convert.ToString(c));
			Console.WriteLine("Conversion to double {0}", Convert.ToDouble(c));
            Console.ReadKey();
			

		}

		
			}
		}
	
