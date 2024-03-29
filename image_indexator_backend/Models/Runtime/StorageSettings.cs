﻿namespace image_indexator_backend.Models.Runtime
{
	public class StorageSettings
	{
		/* This string to be passed with request url to tell ASP that we want to retrieve some static.
		 * It means, that when we want to add static file, we are using path like /images/imageName.jpeg,
		 * but when we want to retrieve it we need to use path like /staticfiles/images/imageName.jpeg.
		 * (so this variable is this *staticfiles*).
		 */
		public string? staticFilesUrnPath { get; set; }
		public string? imagesDirectoryPath { get; set; }
		public string? imageFileExtension { get; set; }
	}
}
