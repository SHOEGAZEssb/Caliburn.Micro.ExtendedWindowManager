namespace Caliburn.Micro.ExtendedWindowManager
{
  /// <summary>
  /// Interface for an OpenFileDialog.
  /// </summary>
  public interface IOpenFileDialog : IFileDialog
  {
    /// <summary>
    /// If multiple files can be selected.
    /// </summary>
    bool Multiselect { get; set; }

    /// <summary>
    /// The selected files.
    /// </summary>
    string[] FileNames { get; }
  }
}