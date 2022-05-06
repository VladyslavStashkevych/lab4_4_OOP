// Real.cs
namespace lab4_4 {
	public class Real : Number {
		public double Value { get => value; set => this.value = value; }

		public override Real Add(Number number) => this + number;
		public override Real Substaction(Number number) => this - number;
		public override Real Multiplication(Number number) => this * number;
		public override Real Division(Number number) => this / number;

		public static Real operator +(Real n1, Number n2) {
			Real result = new Real();
			result.Value = n1.Value + ((Real)n2).Value;
			return result;
		}
		public static Real operator -(Real n1, Number n2) {
			Real result = new Real();
			result.Value = n1.Value - ((Real)n2).Value;
			return result;
		}
		public static Real operator *(Real n1, Number n2) {
			Real result = new Real();
			result.Value = n1.Value * ((Real)n2).Value;
			return result;
		}
		public static Real operator /(Real n1, Number n2) {
			Real result = new Real();
			result.Value = n1.Value / ((Real)n2).Value;
			return result;
		}
	}
}
