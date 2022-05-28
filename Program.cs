using AksonPriceList;
using AksonPriceList.Core;
using AksonPriceList.UI;
using System;
using System.IO;

internal class Program
{
    public static MedicamentFileProvider _medicamentProvider;
    private static Controller _engine;

    static void Main()
    {
        InitializeComponents();
        _engine.Run();
    }

    static void InitializeComponents()
    {
        _medicamentProvider = new MedicamentFileProvider();

        if (!File.Exists(_medicamentProvider.PathToDataFile))
            File.Create(_medicamentProvider.PathToDataFile);

        if (_medicamentProvider.GetAll().Count == 0)
            DefaultList.UploadDefaultData(_medicamentProvider);

        _engine = new Controller();
    }
}