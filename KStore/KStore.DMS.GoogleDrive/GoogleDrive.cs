using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using KStore.Utility;
namespace KStore.DMS.GoogleDrive
{
	public class GoogleDrive : KStore.Interface.GoogleDrive.IGoogleDriveFileService
	{
		private DirectoryHelper dirHelper;
		public GoogleDrive()
		{
			dirHelper = new DirectoryHelper();
		}

		public IList<Google.Apis.Drive.v3.Data.File> GetGoogleDriveFiles(string[] requestedFields)
		{
			return GetFiles(requestedFields);
		}

		public IList<Google.Apis.Drive.v3.Data.File> GetGoogleDriveFiles()
		{
			//note that field names are case sensitive
			//See here for a list of reference: https://developers.google.com/drive/v3/reference/files
			var requestedFields = new [] {
				"id",
				"name",
				"size",
				"thumbnailLink",
				"md5Checksum",
				"fileExtension",
				"modifiedTime"
			};

			return GetFiles(requestedFields);
		}

		private IList<Google.Apis.Drive.v3.Data.File> GetFiles(string[] requestedFields)
		{
			FilesResource.ListRequest listRequest = GoogleDriveService.Files.List();
			listRequest.PageSize = 10;
			listRequest.Fields = $"nextPageToken, files({string.Join(", ", requestedFields)})";
			var googleDriveFiles = listRequest.Execute().Files;
			return googleDriveFiles;
		}

		public DriveService GoogleDriveService
		{
			get
			{
				string[] scopes = { DriveService.Scope.DriveReadonly };
				var applicationName = "KStore Project";
				UserCredential credential;
				var jSonPath = Path.Combine(dirHelper.CurrentAssemblyDirectory(), "client_secret.json");
				using (var stream = new FileStream(jSonPath, FileMode.Open, FileAccess.Read))
				{
					var credPath = System.Environment.GetFolderPath(
						System.Environment.SpecialFolder.Personal);
					credPath = Path.Combine(credPath, @"credentials\drive-dotnet-quickstart.json");
					var clientSecrect = GoogleClientSecrets.Load(stream).Secrets;
					credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
						clientSecrect,
						scopes,
						"user",
						CancellationToken.None,
						new FileDataStore(credPath, true)).Result;
				}

				var service = new DriveService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = credential,
					ApplicationName = applicationName,
				});
				return service;
			}
		}
	}
}
