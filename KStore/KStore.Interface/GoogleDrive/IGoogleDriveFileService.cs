using System.Collections.Generic;
using Google.Apis.Drive.v3;

namespace KStore.Interface.GoogleDrive
{
	public interface IGoogleDriveFileService
	{
		DriveService GoogleDriveService { get; }

		IList<Google.Apis.Drive.v3.Data.File> GetGoogleDriveFiles(string[] requestedFields);

		IList<Google.Apis.Drive.v3.Data.File> GetGoogleDriveFiles();
	}
}
