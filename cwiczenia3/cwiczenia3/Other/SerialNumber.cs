namespace cwiczenia3;

public class SerialNumber
{
    public string NumsFirstLetters { get; set; }
    public string NumsType { get; set; }
    public int Num { get; set; }
    private static int generatedNum = 1;

    public SerialNumber(string numsFirstLetters, string numsType)
    {
        NumsFirstLetters = numsFirstLetters;
        NumsType = numsType;
        Num = generatedNum;
        generatedNum++;
    }

    public string getWholeNum()
    {
        return NumsFirstLetters + "-" + NumsType + "-" + Num;
    }

    public override string ToString()
    {
        return this.getWholeNum();
    }
}