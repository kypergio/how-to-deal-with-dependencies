using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace CloudStorage.Core.StorageManagers
{
    public interface IStorageManager
    {
        Task<string> DownloadAsync(string photoId);
        string GetStorageName();
        Task<string> UploadAsync(IFormFile photo);
    }
}
