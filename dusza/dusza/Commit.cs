namespace dusza;

internal class Commit
{
    public static string path;

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

    public static List<string> GetFiles(string currentPath)
    {
        List<string> files = new();

        foreach (string file in Directory.GetFileSystemEntries(currentPath))
        {
            if(Directory.Exists(file))
                GetFiles(file).ForEach(G=> files.Add(G));
            else if (File.Exists(file))
                files.Add(file);
        }

        return files;
    }

    public string GetValtozasok()
    {
        return String.Join('\n', Valtozasok.Select(G =>G.ToString()));
    }

    public override string ToString() => $"Szulo: {SzuloId}\nSzerzo: {SzerzoId}\nDatum: {Datum.ToString()}\nCommit leiras: {CommitLeiras}\nValtozott:\n{GetValtozasok()}";
}
//peti buzi
