namespace dusza;

internal class Commit
{
    public int SzuloId { get; private set; }
    public int SzerzoId { get; private set; }
    public DateTime Datum { get; private set; }
    public string CommitLeiras { get; private set; }
    public Valtozas[] Valtozasok { get; private set; }

    public Commit(int szuloId, int szerzoId, DateTime datum, string commitLeiras, Valtozas[] valtozasok)
    {
        SzuloId = szuloId;
        SzerzoId = szerzoId;
        Datum = datum;
        CommitLeiras = commitLeiras;
        Valtozasok = valtozasok;
    }

    public void LetrehozCommit()
    {

    }
    /*
    public string GetValtozasok()
    {
        return String.Join('\n', Valtozasok.Select(G=>));
    }*/

   // public override string ToString() => $"Szulo: {SzuloId}\nSzerzo: {SzerzoId}\nDatum: {Datum.ToString()}\nCommit leiras: {CommitLeiras}\nValtozott:\n{GetValtozasok()}";
}
//peti buzi