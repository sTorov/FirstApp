class Drive
{
    public string DiskName { get; }
    public long TotalSpace { get; }
    public long FreeSpace { get; }

    public Drive(string diskName, long totalSpace, long freeSpace)
    {
        DiskName = diskName;
        TotalSpace = totalSpace;
        FreeSpace = freeSpace;
    }

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
}
public class Folder
{
    public List<string> Files { get; set; } = new List<string>();
}