using System;
using System.Collections.Generic;
using System.Text;

namespace RanFlashBoot.ServisesDisks
{
    public class DriveServis
    {
        public List<string> SearchDrives()
        {
            var drives = DriveInfo.GetDrives();
            var RemovebleDrives = new List<string>();
            foreach (var drive in drives)
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    RemovebleDrives.Add(drive.Name);
                }
            }
            return RemovebleDrives;
        }
    }
}
