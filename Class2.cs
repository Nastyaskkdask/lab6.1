using System;

public class BoxS : Box
{
    public BoxS(int length, int width, int height) : base(length, width, height) { }

    public BoxS(Box other) : base(other)
    {
    }

    public int GetSBottom() => 2 * (Len + Wid);
    public int GetMax() => Math.Max(Len * Hei, Wid * Hei);
    public bool IsKorob()
    {
        return (Len == Wid) && (Len == Hei) && (Wid == Hei);
    }
}
