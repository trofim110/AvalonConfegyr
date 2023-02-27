using System;
using System.Reactive;
using Microsoft.Win32;
using ReactiveUI;

namespace Test1.ViewModels;

public class MainViewModel:ReactiveObject
{
    public string FilePath { get; set;}
    public MainViewModel()
    {
        StartDiskSelection = ReactiveCommand.Create(Comand);
    }
  public ReactiveCommand<Unit,Unit> StartDiskSelection { get; set;}




  public void Comand()
  {
      // Configure save file dialog box
      Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
      dlg.FileName = "Document"; // Default file name
      dlg.DefaultExt = ".txt"; // Default file extension
      dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

// Show save file dialog box
      Nullable<bool> result = dlg.ShowDialog();

// Process save file dialog box results
      if (result == true)
      {
          // Save document
          string filename = dlg.FileName;
      }
  }
}