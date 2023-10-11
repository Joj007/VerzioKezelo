namespace dusza;

internal class Valtozas
{
    /// <summary>
    /// 0 => törölt
    /// 1 => új
    /// 2 => változott
    /// </summary>
    public byte Allapot { get; private set; }
    public string FajlNev { get; private set; }
    public DateTime UtolsoMentes { get; private set; }

    public Valtozas(byte allapot, string fajlNev, DateTime utolsoMentes)
    {
        Allapot = allapot;
        FajlNev = fajlNev;
        UtolsoMentes = utolsoMentes;
    }
}