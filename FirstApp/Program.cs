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
}