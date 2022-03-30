using InterfaceMethodKullanimi;

IDatabase db = new SqlDatabase()
{
    Company = "Microsoft",
    DatabaseName = "Microsoft SQL Server"
    
};
db.Read();
db.Delete();
db.Create();
db.Update();

Console.WriteLine(db.DatabaseName);