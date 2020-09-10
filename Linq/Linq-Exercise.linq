<Query Kind="Program" />

void Main()
{
	GetCovers().Dump();
}

public IEnumerable<CoverInfo> GetCovers()
{
	//Implement this method. 
	throw new NotImplementedException();
}

public class PositionInfo
{
	public string Account { get; set; }

	public int Amount { get; set; }
}

public IEnumerable<PositionInfo> GetLongs()
{
	yield return new PositionInfo { Account = "A", Amount = 10000 };
	yield return new PositionInfo { Account = "B", Amount = 30000 };
	yield return new PositionInfo { Account = "C", Amount = 20000 };
}

public IEnumerable<PositionInfo> GetShorts()
{
	yield return new PositionInfo { Account = "X", Amount = -12000 };
	yield return new PositionInfo { Account = "Y", Amount = -240000 };
	yield return new PositionInfo { Account = "Z", Amount = -170000 };
}

public class CoverInfo
{
	public PositionInfo ShortPosition { get; set; }
	public List<PositionInfo> Covers { get; set; }
}
