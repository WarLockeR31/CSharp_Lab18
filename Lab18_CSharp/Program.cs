using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab18
{
	public class Program
	{
		static void Main(string[] args)
		{
			sdgs
			Console.Write("0 => ");
			WriteLineBinaryRanks(0);
			Console.Write("7 => ");
			WriteLineBinaryRanks(7);
			Console.Write("32 => ");
			WriteLineBinaryRanks(32);
			Console.Write("127 => ");
			WriteLineBinaryRanks(127);
		}

		public static LinkedListNode<T> CreateList<T>(params T[] elems)
		{
			if ((elems == null) || (elems.Length == 0))
				return null;
			var l = new LinkedList<T>(elems);
			return l.First;
		}

		public static LinkedList<T> CreateDList<T>(params T[] elems)
		{
			if ((elems == null) || (elems.Length == 0))
				return null;
			var l = new LinkedList<T>(elems);
			return l;
		}

		public static bool IsPalindrome(LinkedList<int> lst)
		{
			if (lst == null || lst.Count == 0 || lst.Count == 1)
				return true;
			return IsPalindromeRecur(lst.First, lst.Last);
		}

		public static bool IsPalindromeRecur(LinkedListNode<int> start, LinkedListNode<int> end)
		{
			if (start.Value != end.Value)
				return false;
			if (start == end || start.Previous == end)
				return true;
			return IsPalindromeRecur(start.Next, end.Previous);
		}

		public static void WriteLineBinaryRanks(int n)
		{
			PrintBinaryRanks(n);
			Console.WriteLine();
		}
		public static void PrintBinaryRanks(int n)
		{
			if (n == 0)
				Console.Write(n);
			else
				PrintBinaryRanksRecur(n);
		}
		public static void PrintBinaryRanksRecur(int n)
		{
			if (n == 0)
			{
				return;
			}
			PrintBinaryRanksRecur(n / 2);
			Console.Write(n % 2);
		}

		public static void SumList(LinkedListNode<int> head, ref int sum)
		{
			if (head == null)
				return;
			sum = 0;
			int sumNext = 0;
			SumList(head.Next, ref sumNext);
			sum = head.Value + sumNext;
		}

		public static int SumFactorials(int n)
		{
			Debug.Assert(n >= 1);
			int sum = 0;
			int S = 0;
			int F = 0;
			PrevSF(n, ref S, ref F);
			return S;
		}

		public static void PrevSF(int n, ref int S, ref int F)
		{
			if (n == 1)
			{
				F = 1;
				S = 1;
				return;
			}

			int SPrev = 0;
			int FPrev = 0;
			PrevSF(--n, ref SPrev, ref FPrev);
			F = FPrev * (n + 1);
			S = SPrev + F;
		}

		public static double PowerN(double X, int N)
		{
			if (N == 0)
				return 1;
			if (N < 0)
				return 1 / PowerN(X, -N);
			if (N % 2 == 0)
			{
				var x = PowerN(X, N / 2);
				return x * x;
			}
			else
				return X * PowerN(X, N - 1);
		}

		public static int CountLocalMax(LinkedListNode<int> lst)
		{
			if (lst == null)
				return 0;
			if ((lst.Previous?.Value ?? int.MinValue) < lst.Value && (lst.Next?.Value ?? int.MinValue) < lst.Value)
				return 1 + CountLocalMax(lst.Next);
			else
				return CountLocalMax(lst.Next);
		}
	}
}
