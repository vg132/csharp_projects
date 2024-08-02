using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
	public class Program
	{
		private static int[] _field = new int[81];
		private static Dictionary<int, List<int>> _candidates = new Dictionary<int, List<int>>();

		static void Main(string[] args)
		{
			LoadPuzzle();
			DisplayField();
			SolvePuzzle();
			DisplayField();
			Console.WriteLine();
			Console.WriteLine("Not found: {0}", _field.Where(item => item == 0).Count());
			Console.ReadLine();
		}

		private static void SolvePuzzle()
		{
			for (int loop = 0; loop < 100; loop++)
			{
				_candidates.Clear();
				for (int pass = 0; pass < 3; pass++)
				{
					if (!RunPass(pass))
					{
						break;
					}
				}
			}
		}

		private static bool RunPass(int pass)
		{
			for (int i = 0; i < _field.Length; i++)
			{
				if (_field[i] == 0)
				{
					switch (pass)
					{
						case 0:
							_candidates[i] = FindCandidatesFirstPass(i);
							break;
						case 2:
							_candidates[i] = FindUniqueCandidat(i);
							break;
					}
					if (_candidates[i].Count == 1)
					{
						_field[i] = _candidates[i].First();
						_candidates.Remove(i);
						return false;
					}
				}
				else
				{
					_candidates.Remove(i);
				}
			}
			if (pass == 1)
			{
				for (int i = 0; i < _field.Count(); i++)
				{
					FindNakedSubsetColumn(i);
				}
				for (int i = 0; i < _field.Count(); i++)
				{
					FindNakedSubsetRow(i);
				}
			}
			return true;
		}

		private static List<int> FindCandidatesFirstPass(int pos)
		{
			int line = pos / 9;
			int column = pos - (line * 9);
			int blockLine = (line > 0 ? line / 3 : 0) * 3;
			int blockColumn = (column / 3) * 3;

			var candidates = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

			for (int currentBlockLine = blockLine; currentBlockLine < blockLine + 3; currentBlockLine++)
			{
				for (int i = blockColumn; i < blockColumn + 3; i++)
				{
					candidates.Remove(_field[(currentBlockLine * 9) + i]);
				}
			}
			for (int i = 0; i < 9; i++)
			{
				candidates.Remove(_field[(line * 9) + i]);
				candidates.Remove(_field[(i * 9) + column]);
			}
			return candidates;
		}

		private static List<int> FindUniqueCandidat(int pos)
		{
			int row = pos / 9;
			int column = pos - (row * 9);
			int blockRow = (row > 0 ? row / 3 : 0) * 3;
			int blockColumn = (column / 3) * 3;

			var candidates = _candidates[pos];
			if (candidates != null && candidates.Count > 1)
			{
				foreach (var candidate in _candidates[pos])
				{
					var newCandidates = FindBlockUnique(candidate, pos, blockRow, blockColumn) ??
						FindRowUnique(candidate, pos, row) ??
						FindColumnUnique(candidate, pos, column);
					if (newCandidates != null)
					{
						return newCandidates;
					}
				}
			}
			return _candidates[pos];
		}

		private static bool IsUnique(int pos, int comparePos, int candidate)
		{
			if (comparePos != pos && _candidates.ContainsKey(comparePos))
			{
				return !_candidates[comparePos].Contains(candidate);
			}
			return true;
		}

		private static List<int> FindBlockUnique(int candidate, int pos, int blockLine, int blockColumn)
		{
			var alone = true;
			for (int currentBlockLine = blockLine; currentBlockLine < blockLine + 3; currentBlockLine++)
			{
				for (int i = blockColumn; i < blockColumn + 3; i++)
				{
					alone = IsUnique(pos, (currentBlockLine * 9) + i, candidate) && alone;
				}
			}
			if (alone)
			{
				return new List<int>(new[] { candidate });
			}
			return null;
		}

		private static List<int> FindRowUnique(int candidate, int pos, int row)
		{
			var alone = true;
			for (int i = 0; i < 9; i++)
			{
				alone = IsUnique(pos, (row * 9) + i, candidate) && alone;
			}
			if (alone)
			{
				return new List<int>(new[] { candidate });
			}
			return null;
		}

		private static List<int> FindColumnUnique(int candidate, int pos, int column)
		{
			var alone = true;
			for (int i = 0; i < 9; i++)
			{
				alone = IsUnique(pos, (i * 9) + column, candidate) && alone;
			}
			if (alone)
			{
				return new List<int>(new[] { candidate });
			}
			return null;
		}

		private static void FindNakedSubsetColumn(int pos)
		{
			int row = pos / 9;
			int column = pos - (row * 9);
			if (!_candidates.ContainsKey(pos))
			{
				return;
			}
			var candidate = _candidates[pos];
			var found = new List<int>();
			found.Add(pos);
			//Column
			for (int i = 0; i < 9; i++)
			{
				var currentPos = (row * 9) + i;
				if (currentPos != pos && _candidates.ContainsKey(currentPos))
				{
					if (_candidates[currentPos].All(item => candidate.Contains(item)))
					{
						found.Add(currentPos);
					}
				}
			}
			if (found.Count == candidate.Count)
			{
				for (int i = 0; i < 9; i++)
				{
					var currentPos = (row * 9) + i;
					if (currentPos != pos && _candidates.ContainsKey(currentPos) && !found.Contains(currentPos))
					{
						_candidates[currentPos].RemoveAll(item => candidate.Contains(item));
					}
				}
			}
		}

		private static void FindNakedSubsetRow(int pos)
		{
			int row = pos / 9;
			int column = pos - (row * 9);
			if (!_candidates.ContainsKey(pos))
			{
				return;
			}
			var candidate = _candidates[pos];
			var found = new List<int>();
			found.Add(pos);
			for (int i = 0; i < 9; i++)
			{
				var currentPos = (i * 9) + column;
				if (currentPos != pos && _candidates.ContainsKey(currentPos))
				{
					if (_candidates[currentPos].All(item => candidate.Contains(item)))
					{
						found.Add(currentPos);
					}
				}
			}
			if (found.Count == candidate.Count)
			{
				for (int i = 0; i < 9; i++)
				{
					var currentPos = (i * 9) + column;
					if (currentPos != pos && _candidates.ContainsKey(currentPos) && !found.Contains(currentPos))
					{
						_candidates[currentPos].RemoveAll(item => candidate.Contains(item));
					}
				}
			}
		}

		private static void DisplayField()
		{
			Console.WriteLine();
			Console.WriteLine("===================");
			Console.WriteLine("====== Field ======");
			Console.WriteLine();
			for (int line = 0; line < 9; line++)
			{
				Console.Write("\n|");
				DrawLine(line);
			}
		}

		private static void DrawLine(int line)
		{
			for (int i = 0; i < 9; i++)
			{
				Console.Write("{0}|", _field[(line * 9) + i]);
			}
		}

		private static void LoadPuzzle()
		{
			//var field = "670002004000700806089050700900103070007080300030205009006090280701008000800600097"; //Normal
			var field = "001093006023610070000000020900000000005361700000000004080000000090086350100450800"; //Hard
			//var field = "700849030928135006400267089642783951397451628815692300204516093100008060500004010";
			for (int i = 0; i < field.Length; i++)
			{
				_field[i] = int.Parse(field.Substring(i, 1));
			}
		}
	}
}
